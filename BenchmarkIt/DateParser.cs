namespace BenchmarkIt
{
    public class DateParser
    {
        public int GetYearFromDateTime(string dateTime)
        {
            DateTime dt = DateTime.Parse(dateTime);

            return dt.Year;
        }

        public int GetYearFromSplit(string dateTime)
        {
            string[] split = dateTime.Split('-');

            return int.Parse(split[0]);
        }

        public int GetYearFromSubstring(string dateTime)
        {
            int hyphen = dateTime.IndexOf('-');

            return int.Parse(dateTime.Substring(0, hyphen));
        }

        public int GetYearFromSpan(ReadOnlySpan<char> dateTime)
        {
            int hyphen = dateTime.IndexOf('-');

            return int.Parse(dateTime.Slice(0, hyphen));
        }
    }
}
