using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                string[] splitArr = value.Split(' ');
                Surname = splitArr[0].Trim();
                Name = splitArr[1].Trim();
                Partonymic = splitArr[2].Trim();
            }
        }
        public string OSP { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string Address { get; set; }
        public string DebtorFullName { get; set; }
        public DateTime DebtorBirthDate { get; set; }
        public string DebtorAddress { get; set; }
        public string СlaimantFullName { get; set; }
        public DateTime ClaimantBirthDate { get; set; }
        public string СlaimanAddress { get; set; }

        public decimal IpId { get; set; }
        public decimal IpNumber { get; set; }
        public string IpStatus { get; set; }

        public int isDisabled { get; set; } = 0;

        public override string ToString()
        {
            return
            $@"{Surname.Trim()}|{Name.Trim()}|{Partonymic.Trim()}|{OSP.Trim()}|{BirthDate}|{BirthPlace.Trim()}|{Address}|{DebtorFullName.Trim()}|
               {DebtorBirthDate}|{DebtorAddress.Trim()}|{СlaimantFullName.Trim()}|{ClaimantBirthDate}|{СlaimanAddress.Trim()}|
               {IpId}|{IpNumber}|{IpStatus.Trim()}|{isDisabled}|";
        }
    }
}
