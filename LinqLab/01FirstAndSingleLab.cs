using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
   public class FirstAndSingleLab
    {
        private static IEnumerable<Sample> Source { get; set; }

        public FirstAndSingleLab()
        {
            Source = new SampleDate().GetData();
        }

        public Sample 搜尋UserName等於demo的資料使用First()
        {
            var result = Source.First(x => x.UserName == "demo");
            return result;
        }

        public Sample 搜尋UserName等於skilltree的資料使用FirstOrDefault()
        {
            var result = Source.FirstOrDefault(x => x.UserName == "skilltree");
            return result;
        }

        public Sample 搜尋UserName等於skilltree的資料使用First()
        {
            var result = Source.First(x => x.UserName == "skilltree");
            return result;
        }

        public Sample 搜尋UserName等於demo的資料使用Single()
        {
            var result = Source.Single(x => x.UserName == "demo");
            return result;
        }

        public Sample 搜尋UserName等於bill的資料使用Single()
        {
            var result = Source.Single(x => x.UserName == "bill");
            return result;
        }
        public Sample 搜尋UserName等於bill的資料使用SingleOrDefault()
        {
            var result = Source.SingleOrDefault(x => x.UserName == "bill");
            return result;
        }

        public Sample 搜尋UserName等於skilltree的資料使用SingleOrDefault()
        {
            var result = Source.SingleOrDefault(x => x.UserName == "skilltree");
            return result;
        }
    }
}
