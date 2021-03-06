using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class BsLabSourceItem
    {
        public int ID { get; set; }
        public int SourceId { get; set; }
        public Nullable<int> TubeTypeId { get; set; }
        public int ItemId { get; set; }
        public decimal Totality { get; set; }
        public short LsUseArea { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsLabSource BsLabSource { get; set; }
        public virtual BsTubeType BsTubeType { get; set; }
    }
}
