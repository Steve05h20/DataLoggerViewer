public interface IDlogDirectoryService
{
    Task<IEnumerable<DlogFileInfo>> PickFolderAndGetDlogsAsync();
}

public record DlogFileInfo(
    string Name,
    string FullPath,
    long Size,
    DateTime CreatedAt
);
