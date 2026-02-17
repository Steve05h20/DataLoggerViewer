using Microsoft.Maui.Storage;

public class DlogDirectoryService : IDlogDirectoryService
{
    public async Task<IEnumerable<DlogFileInfo>> PickFolderAndGetDlogsAsync()
    {
        var result = await FilePicker.Default.PickAsync(new PickOptions
        {
            PickerTitle = "Sélectionner un fichier .dlog"
        });

        if (result == null)
            return Enumerable.Empty<DlogFileInfo>();

        var selectedDirectory = Path.GetDirectoryName(result.FullPath);
        if (string.IsNullOrWhiteSpace(selectedDirectory) || !Directory.Exists(selectedDirectory))
            return Enumerable.Empty<DlogFileInfo>();

        var files = Directory
            .EnumerateFiles(selectedDirectory, "*.dlog", SearchOption.TopDirectoryOnly)
            .Select(path =>
            {
                var info = new FileInfo(path);
                return new DlogFileInfo(
                    info.Name,
                    info.FullName,
                    info.Length,
                    info.CreationTime
                );
            });

        return files;
    }
}