using System;

namespace FSSPreader
{
    public class Row
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Partonymic { get; set; }
        public string FullName
        {
            get
            {
                return Surname + " " + Name + " " + Partonymic;
            }
            set
            {
                string val = value;
                val = val.Replace('C', 'С');
                val = val.Replace('M', 'M');
                val = val.Replace('P', 'Р');
                val = val.Replace(@"\", "");
                string[] splitArr = val.Split(' ');
                for (int i = 0; i < splitArr.Length; i++)
                {
                    if (i == 0)
                    {
                        Surname = splitArr[i].Trim();
                    }
                    else if (i == 1)
                    {
                        Name = splitArr[i].Trim();
                    }
                    else if (i == 2)
                    {
                        Partonymic = splitArr[i].Trim();
                        if (val.ToUpper().Contains("ОГЛЫ")){
                            Partonymic += " оглы";
                        }
                    }
                }
            }
        }

        public override string ToString()
        {
            return $@"{Surname ?? ""}|{Name ?? ""}|{Partonymic ?? ""}|";           
        }
    }
}
