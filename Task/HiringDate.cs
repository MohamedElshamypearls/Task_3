namespace Task
{

    public class HiringDate: IComparable<HiringDate>
    {
        // Properties
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        // Constructor
        public HiringDate(int day, int month, int year)
        {
            if (!IsValidDate(day, month, year))
                throw new ArgumentException("Invalid date provided.");

            Day = day;
            Month = month;
            Year = year;
        }

        // Validates if the date is real
        private bool IsValidDate(int day, int month, int year)
        {
            return DateTime.TryParse($"{year}-{month}-{day}", out _);
        }

        // Returns the date as a DateTime object
        public DateTime ToDateTime()
        {
            return new DateTime(Year, Month, Day);
        }

        public int CompareTo(HiringDate other)
        {
            if (other == null) return 1;
            return this.ToDateTime().CompareTo(other.ToDateTime());
        }



        // Override ToString to display formatted date
        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }
    }



}
