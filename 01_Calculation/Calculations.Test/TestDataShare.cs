namespace Calculations.Test
{
    public static class TestDataShare
    {
        public static IEnumerable<object[]> IsOddOrEvenData
        {
            get
            {
                yield return new object[] { 1, true };
                yield return new object[] { 1, true };
            }
        }
        public static IEnumerable<object[]> IsEvenOrOddExternalData
        {
            get
            {
                var allLines = System.IO.File.ReadAllLines("IsEvenOrOddTestData.txt");
                return allLines.Select(x =>
                {
                    var lineSplit = x.Split(',');
                    var list = new object[] {
                        int.Parse(lineSplit[0]),bool.Parse(lineSplit[1])
                    };
                    return list;
                });
            }
        }
    }
}
