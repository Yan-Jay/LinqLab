using System.Collections.Generic;
using System.Linq;

namespace LinqLab
{
    public class WhereLab
    {
        private static IEnumerable<Sample> Source { get; set; }

        public WhereLab()
        {
            Source = new SampleDate().GetData();
        }

        public List<Sample> 搜尋Id大於8的資料()
        {
            var result = Source.Where(x => x.Id > 8).ToList();
            return result;
        }

        public List<Sample> 搜尋Price等於200的資料()
        {
            var result = Source.Where(x => x.Price == 200).ToList();
            return result;
        }

        public List<Sample> 搜尋UserName開頭為d的資料()
        {
            var result = Source.Where(x => x.UserName.StartsWith("d")).ToList();
            return result;
        }

        public List<Sample> 搜尋UserName包含e的資料()
        {
            var result = Source.Where(x => x.UserName.Contains("e")).ToList();
            return result;
        }

        public List<Sample> 搜尋UserName結尾為o的資料()
        {
            var result = Source.Where(x => x.UserName.EndsWith("o")).ToList();
            return result;
        }

        public List<Sample> 搜尋UserName是demo和joey的資料()
        {
            var whereStr = new[] { "demo", "joey" };
            var result = new List<Sample>();
            result = Source.Where(x => x.UserName == whereStr[0] || x.UserName == whereStr[1]).ToList();
            return result;
        }

        public bool 判斷是否有Id等於99的資料()
        {
            var result = true;
            result = Source.Any(x => x.Id.Equals(99));
            return result;
        }
    }
}