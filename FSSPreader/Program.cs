using System.Collections.Generic;
using System.IO;

namespace FSSPreader
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Row> rows = new List<Row>();

            using (var reader = new StreamReader(@"C:\Users\i.khakimzhanov\Desktop\Дети УФССП по РТ 04032019.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split('|');
                    Row current = new Row
                    {
                        FullName = values[1]
                    };
                    string str = $@"{values[0]}|{current.ToString()}{values[2]}|{values[3]}|{values[4]}|{values[5]}|{values[6]}|{values[7]}|";
                    using (StreamWriter file = new StreamWriter(@"C:\Users\i.khakimzhanov\Desktop\NewReady.csv", true))
                    {
                        file.WriteLine(str);
                    }
                }
            }
        }
    }
}
