using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excel_Exporter
{
    public class SimpleData
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public static List<SimpleData> GetSimpleDatas()
        {
            List<SimpleData> simpleDataList = new List<SimpleData>();
            simpleDataList.Add(GetCreatedSimpleData("Simple","Dev", 28));
            simpleDataList.Add(GetCreatedSimpleData("So","Simple", 30));
            simpleDataList.Add(GetCreatedSimpleData("OK","OK", 25));
            simpleDataList.Add(GetCreatedSimpleData("Not That","Simple", 35));
            simpleDataList.Add(GetCreatedSimpleData("Is It","Simple", 18));
            return simpleDataList;
        }

        private static SimpleData GetCreatedSimpleData(string name, string surname, int age)
        {
            SimpleData simpleData = new SimpleData();
            simpleData.Name = name;
            simpleData.Surname = surname;
            simpleData.Age = age;
            return simpleData;
        }
    }
}
