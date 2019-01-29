using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSSPreader
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Row> rows = new List<Row>();

            using (var reader = new StreamReader(@"C:\Users\i.khakimzhanov\Desktop\Выгрузка\Дети ФССП_РТ1.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split('|');
                    Row current = new Row
                    {
                        FullName = values[0],
                        OSP = values[1],
                        BirthDate = Convert.ToDateTime(values[2]),
                        BirthPlace = values[3],
                        Address = values[4],

                        DebtorFullName = values[5],
                        DebtorBirthDate = string.IsNullOrWhiteSpace(values[6]) ? new DateTime(1000, 1, 1) : DateTime.ParseExact(values[6], "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        DebtorAddress = values[7],

                        СlaimantFullName = values[8],
                        ClaimantBirthDate = string.IsNullOrWhiteSpace(values[9]) ? new DateTime(1000, 1, 1) : DateTime.ParseExact(values[9], "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        СlaimanAddress = values[10],
                        //IpId = decimal.Parse(values[11], CultureInfo.InvariantCulture),
                        //IpNumber = decimal.Parse(values[12], CultureInfo.InvariantCulture),
                        IpStatus = values[13]
                    };                    
                    using (StreamWriter file = new StreamWriter(@"C:\Users\i.khakimzhanov\Desktop\Выгрузка\Ready.csv", true))
                    {
                        file.WriteLine(current.ToString());
                    }
                }
            }
        }
    }
}
