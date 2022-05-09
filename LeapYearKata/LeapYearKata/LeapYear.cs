namespace LeapYearKata
{
    public class LeapYear
    {
        public static bool CheckLeapYear(int year)
        {
            if(YearIsDivisibleBy400(year))
                return true;
            if (YearIsDivisibleBy4NotBy100(year))
                return true;
            return false;
        }

        private static bool YearIsDivisibleBy4NotBy100(int year)
        {
            return year % 4 == 0 && year % 100 != 0;
        }

        private static bool YearIsDivisibleBy400(int year)
        {
            return year % 400 == 0;
        }
    }
}