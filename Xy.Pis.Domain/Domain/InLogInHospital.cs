using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class InLogInHospital
    {
        public int ID { get; set; }
        public int HospId { get; set; }
        public int LocationID { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> LsInIllness { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
    }
}
