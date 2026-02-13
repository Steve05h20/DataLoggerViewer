namespace DataLoggerViewer.Presentation.ViewModels
{
    public record LiftSummaryViewModel(
        DateTime Start,
        DateTime End,
        double MaxSWLReached,
        int NbApproach,
        int NbOver,
        int NbCutOff
    );

    public record LiftEventSummaryDetailViewModel(
        List<ObjectValue<string>> EventDetails
    );

    public record ObjectValue<T>(
        string Key,
        T Value
    );
    public record LiftSummariesDetailViewModel(
        List<ObjectValue<int>> SummariesDetails,
        List<ObjectValue<DateTime>> SummariesTimeDetails,
        List<ObjectValue<int>> LiftBuckets
    );

    public record LiftEventSummaryViewModel(
        string Event,
        DateTime DateTime,
        double Radius,
        double Load,
        double Capacity,
        double Angle,
        double Length,
        double Slew,
        double WindSpeed,
        double WindGust
    );

    public record LiftTimeSeriesPointViewModel(
     DateTime Timestamp,
     bool value
    );

   public record LiftTimeSeriesGroupViewModel(string Title, LiftTimeSeriesPointViewModel[] Points)
{
    public List<DateTime> Timestamps()
    {
        return Points.Select(p => p.Timestamp).ToList();
    }
}
}

