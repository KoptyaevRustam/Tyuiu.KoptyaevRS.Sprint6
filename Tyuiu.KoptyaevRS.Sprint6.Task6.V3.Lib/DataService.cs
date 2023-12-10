using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KoptyaevRS.Sprint6.Task6.V3.Lib
{
    public class DataService : ISprint6Task6V3
    {
        public string CollectTextFromFile(string str, string path)
        {
            string resStr = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(str))
                    {
                        string[] z = line.Split();
                        foreach (string x in z.Where(k => k.Contains('r')))
                        {
                            resStr = resStr + x;
                        }
                    }
                }
            }
            return resStr;
            
        }
    }
}
