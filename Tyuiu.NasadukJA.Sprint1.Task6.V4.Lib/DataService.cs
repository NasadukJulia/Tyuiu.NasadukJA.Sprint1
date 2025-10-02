using System.Xml.XPath;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NasadukJA.Sprint1.Task6.V4.Lib
{
    public class DataService : ISprint1Task6V4
    {
        public string CheckDoubleN(string value)
        {
            value = value.Trim();
            string[] words = value.Split(' ');
            string result = "";
            foreach (string word in words)
            {
                if (word.Contains("нн"))
                {
                    result += word + " ";
                }
            }
            if (result == "")
            {
                return "Нет слов с удвоенной 'нн'";
            }
            return result.Trim();
        }
    }
}
