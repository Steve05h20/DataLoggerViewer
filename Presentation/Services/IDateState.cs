using System;

namespace DataLoggerViewer.Presentation.Services 
{
    public interface IDateState
    {
        /// <summary>
        /// Gets the first day of the current year at midnight UTC
        /// </summary>
        DateTime GetCurrentYearStart();

        /// <summary>
        /// Gets the last day of the current year at 23:59:59 UTC
        /// </summary>
        DateTime GetCurrentYearEnd();

        /// <summary>
        /// Gets the current date range.
        /// </summary>
        DateTime From { get; }
        DateTime To { get; }

        /// <summary>
        /// Sets the current date range and notifies listeners.
        /// </summary>
        void SetRange(DateTime from, DateTime to);

        /// <summary>
        /// Event fired when the date range changes.
        /// </summary>
        event Action? RangeChanged;
    }
}
