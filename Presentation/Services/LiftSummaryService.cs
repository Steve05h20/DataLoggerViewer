using DataLoggerViewer.Presentation.ViewModels;

namespace DataLoggerViewer.Presentation.Services
{
    public class LiftSummaryService : ILiftSummaryService
    {
        public Task<IReadOnlyList<LiftSummaryViewModel>> GetSummariesForRange(DateTime from, DateTime to)
        {
            var items = new List<LiftSummaryViewModel>
            {
                new (new DateTime(2026, 1, 1), new DateTime(2026, 1, 1), 1000, 10, 5,1),
                new (new DateTime(2026, 2, 1), new DateTime(2026, 2, 1), 1500, 15, 7,1),
                new (new DateTime(2026, 3, 1), new DateTime(2026, 3, 1), 2000, 20, 10,1),
                new (new DateTime(2026, 4, 1), new DateTime(2026, 4, 1), 2500, 25, 12,1),
                new (new DateTime(2026, 5, 1), new DateTime(2026, 5, 1), 3000, 30, 15,1),
                new (new DateTime(2026, 6, 1), new DateTime(2026, 6, 1), 3500, 35, 17,1),
                new (new DateTime(2026, 7, 1), new DateTime(2026, 7, 1), 4000, 40, 20,1),
                new (new DateTime(2026, 8, 1), new DateTime(2026, 8, 1), 4500, 45, 22,1),
                new (new DateTime(2026, 9, 1), new DateTime(2026, 9, 1), 5000, 50, 25,1),   
                new (new DateTime(2026, 10, 1), new DateTime(2026, 10, 1), 5500, 55, 27,1),
                new (new DateTime(2026, 11, 1), new DateTime(2026, 11, 1), 6000, 60, 30,1),
                new (new DateTime(2026, 12, 1), new DateTime(2026, 12, 1), 6500, 65, 32,1)
            };

            return Task.FromResult((IReadOnlyList<LiftSummaryViewModel>)items);
        }

        public Task<IReadOnlyList<LiftEventSummaryViewModel>> GetEventsForSummaryId(int id)
        {
            var events = new List<LiftEventSummaryViewModel>
            {
                new ("Event", DateTime.Parse("2025-01-05 13:33:45"), 6.0, 376.0, 4.0, 53.2, 11.9, 0.0, 0.0, -1.0),
                new ("Approach Set", DateTime.Parse("2025-01-05 13:33:45"), 6.0, 376.0, 4.0, 53.2, 11.9, 0.0, 0.0, -1.0),
                new ("Over Load Set", DateTime.Parse("2025-01-05 13:33:45"), 6.0, 376.0, 4.0, 53.2, 11.9, 0.0, 0.0, -1.0),
                new ("Cut Off Set", DateTime.Parse("2025-01-05 13:33:46"), 6.0, 376.0, 4.0, 53.2, 11.9, 0.0, 0.0, -1.0),
                new ("Cut Off Clear", DateTime.Parse("2025-01-05 13:37:14"), 6.0, 0.0, 4.0, 53.2, 11.9, 0.0, 0.0, -1.0),
                new ("Over Load Clear", DateTime.Parse("2025-01-05 13:37:15"), 6.0, 0.0, 4.0, 53.2, 11.9, 0.0, 0.0, -1.0),
                new ("Approach Clear", DateTime.Parse("2025-01-05 13:37:15"), 6.0, 0.0, 4.0, 53.2, 11.9, 0.0, 0.0, -1.0),
                new ("End of Lift", DateTime.Parse("2025-01-05 13:37:15"), 6.0, 0.0, 4.0, 53.2, 11.9, 0.0, 0.0, -1.0)
            };
            return Task.FromResult((IReadOnlyList<LiftEventSummaryViewModel>)events);
        }

        public Task<IReadOnlyList<LiftTimeSeriesGroupViewModel>> GetTimeSeriesForSummaryId(int id)
        {
            var liftTimeSeriesPoints = new List<LiftTimeSeriesGroupViewModel>
{
    new ("Lift", new []
    {
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 08:00:00"), true),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 08:15:30"), false),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 09:22:10"), false),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 09:45:00"), false),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 10:30:15"), false),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 11:05:45"), false),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 13:33:45"), false),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 13:37:15"), false),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 14:20:30"), true),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 14:55:00"), false),
    }),
    new ("Bridging", new []
    {
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 08:00:00"), true),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 08:15:30"), true),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 09:22:10"), true),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 09:45:00"), true),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 10:30:15"), true),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 11:05:45"), true),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 13:33:45"), true),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 13:37:15"), true),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 14:20:30"), true),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 14:55:00"), true)
    }),
    new ("Bypass", new []
    {
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 08:00:00"), true),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 08:15:30"), true),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 09:22:10"), true),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 09:45:00"), true),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 10:30:15"), true),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 11:05:45"), true),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 13:33:45"), true),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 13:37:15"), true),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 14:20:30"), true),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 14:55:00"), true)
    }),
    new ("Atb", new []
    {
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 08:00:00"), true),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 08:15:30"), true),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 09:22:10"), true),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 09:45:00"), false),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 10:30:15"), true),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 11:05:45"), false),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 13:33:45"), true),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 13:37:15"), true),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 14:20:30"), true),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 14:55:00"), true)
    }),
    new ("High Angle", new []
    {
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 08:00:00"), true),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 08:15:30"), true),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 09:22:10"), true),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 09:45:00"), true),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 10:30:15"), true),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 11:05:45"), true),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 13:33:45"), true),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 13:37:15"), true),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 14:20:30"), true),
        new LiftTimeSeriesPointViewModel(DateTime.Parse("2025-01-05 14:55:00"), true)
    })};
            return Task.FromResult((IReadOnlyList<LiftTimeSeriesGroupViewModel>)liftTimeSeriesPoints);
        }

        public Task<LiftSummariesDetailViewModel> GetDetailsForSummariesRange(DateTime from, DateTime to)
        {
            var details = new LiftSummariesDetailViewModel(
                new List<ObjectValue<int>>
                {
                    new ("Nb Bridging", 0),
                    new ("Nb Bypass", 0),
                    new ("Nb ATB", 0),
                    new ("Nb Cut Off", 0),
                    new ("Nb Overload", 0),
                    new ("Nb Approach", 0),
                    new ("Nb Lift(total)", 0),
                },
                new List<ObjectValue<DateTime>>
                {
                    new ("Time in App", DateTime.Parse("2025-01-05 08:00:00")),
                    new ("Time in Over", DateTime.Parse("2025-01-05 14:55:00")),
                    new ("Time in Cut", DateTime.Parse("2025-01-05 10:30:15")),
                    new ("Time in Lift", DateTime.Parse("2025-01-05 10:30:15"))
                },
                new List<ObjectValue<int>>
                {
                    new ("<20%", 0),
                    new (">20%", 0),
                    new (">30%", 0),
                    new (">40%", 0),
                    new (">50%", 0),
                    new (">60%", 0),
                    new (">70%", 0),
                    new (">80%", 0),
                    new (">90%", 0),
                    new (">100%", 0),
                    new (">120%", 0)

                }
            );
            return Task.FromResult(details);

        }
    }
}
