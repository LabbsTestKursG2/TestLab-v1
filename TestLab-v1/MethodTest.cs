using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestLab_v1
{
    public class MethodTest
    {
        public int Average(int value1, int value2)
        {
            var averageValue = (value1 + value2) / 2;

            return averageValue;
        }
        public string Capitalize(string value)
        {
            value = Regex.Replace(value, @"(^\w)|(\s\w)", m => m.Value.ToUpper());
            value = Regex.Replace(value, @"[\d-]", string.Empty);
            value = value.Replace(" ", "_");
            
            return value;
        }
        public string[] ConcatArrayWithSpace(string[] value)
        {
            var count = 1;
            for (int i = 0; i < value.Length; i++)
            {
                if (value.Length > count)
                {
                    value[i] += new string(' ', 1);
                }
                count += 1;
            }
            var teststring = string.Join("", value);
            string[] testArray = new string[] { teststring };
        
            return testArray;
        }
        public string UppercaseFirstEach(string value)
        {
            value = Regex.Replace(value, @"(^\w)|(\s\w)", m => m.Value.ToUpper());

            return value;
        }
    }
}
