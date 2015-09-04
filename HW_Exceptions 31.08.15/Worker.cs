namespace HW_Exceptions_31._08._15
{
    struct Worker
    {
        public Worker(string surnameAndInitials, string position, int startYear)
        {
            SurnameAndInitials = surnameAndInitials;
            Position = position;
            StartYearJob = startYear;
        }
        public string SurnameAndInitials { get; set; }
        public string Position { get; set; }
        public int StartYearJob { get; set; }
    }
}
