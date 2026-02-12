namespace DataLoggerViewer.Presentation.Services
{
    public class DateState : IDateState
    {
        private DateTime _from;
        private DateTime _to;

        public DateState()
        {
            // 1. On s'assure que _from a une valeur réelle (ex: aujourd'hui)
            _from = DateTime.Now;
            _to = _from;
        }

        public DateTime GetCurrentYearStart()
        {
            return _from;
        }

        public DateTime GetCurrentYearEnd()
        {
            return _to;
        }

        public DateTime From => new DateTime(_from.Year,_from.Month,_from.Day);
        public DateTime To => new DateTime(_to.Year, _to.Month, _to.Day);

        public event Action? RangeChanged;

        public void SetRange(DateTime from, DateTime to)
        {
            _from = from;
            _to = to;
            RangeChanged?.Invoke();
        }
    }
}
