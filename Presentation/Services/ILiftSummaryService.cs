using DataLoggerViewer.Presentation.ViewModels;

namespace DataLoggerViewer.Presentation.Services
{

    public interface ILiftSummaryService
    {
        Task<IReadOnlyList<LiftSummaryViewModel>> GetSummariesForRange(DateTime from, DateTime to);
        Task<IReadOnlyList<LiftEventSummaryViewModel>> GetEventsForSummaryId(int id);
        Task<IReadOnlyList<LiftTimeSeriesGroupViewModel>> GetTimeSeriesForSummaryId(int id);
    }
}
