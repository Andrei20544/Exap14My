using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exap_14.ViewModel
{
    class DopStud
    {
        public string FIO { get; set; }
        public string POL { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Parents { get; set; }
        public string Adres { get; set; }
        public string Mobile { get; set; }
        public string PassData { get; set; }
        public long? NumZ { get; set; }
        public DateTime? DateInvite { get; set; }
        public string Group { get; set; }
        public byte? Cours { get; set; }
        public string Spec { get; set; }
        public bool? OchForm { get; set; }

        public DopStud(string fIO, string pOL, DateTime? dateOfBirth, string parents, 
            string adres, string mobile, string passData, long? numZ, DateTime? dateInvite, 
            string group, byte? cours, string spec, bool? ochForm)
        {
            FIO = fIO;
            POL = pOL;
            DateOfBirth = dateOfBirth;
            Parents = parents;
            Adres = adres;
            Mobile = mobile;
            PassData = passData;
            NumZ = numZ;
            DateInvite = dateInvite;
            Group = group;
            Cours = cours;
            Spec = spec;
            OchForm = ochForm;
        }
    }
}
