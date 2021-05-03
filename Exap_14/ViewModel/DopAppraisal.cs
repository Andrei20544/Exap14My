using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exap_14.ViewModel
{
    class DopAppraisal
    {

        public string FIOStud { get; set; }
        public DateTime? DateExam1 { get; set; }
        public byte? Appr1 { get; set; }
        public string Pred1 { get; set; }
        public DateTime? DateExam2 { get; set; }
        public byte? Appr2 { get; set; }
        public string Pred2 { get; set; }
        public DateTime? DateExam3 { get; set; }
        public byte? Appr3 { get; set; }
        public string Pred3 { get; set; }
        public float? AvgAppr { get; set; }

        public DopAppraisal(string fIOStud,
            DateTime? dateExam1, byte? appr1, string pred1,
            DateTime? dateExam2, byte? appr2, string pred2,
            DateTime? dateExam3, byte? appr3, string pred3, float? avgAppr)
        {
            FIOStud = fIOStud;
            DateExam1 = dateExam1;
            Appr1 = appr1;
            Pred1 = pred1;
            DateExam2 = dateExam2;
            Appr2 = appr2;
            Pred2 = pred2;
            DateExam3 = dateExam3;
            Appr3 = appr3;
            Pred3 = pred3;
            AvgAppr = avgAppr;
        }
    }
}
