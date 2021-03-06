using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class RmZyBackDtl
    {
        public int ID { get; set; }
        public int BillId { get; set; }
        public int InBatchId { get; set; }
        public int ItemId { get; set; }
        public int UnitId { get; set; }
        public decimal DrugNum { get; set; }
        public decimal RetailPrice { get; set; }
        public decimal StockPrice { get; set; }
        public string Memo { get; set; }
        public Nullable<int> BackreqItemId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual BsUnit BsUnit { get; set; }
        public virtual Rmstore Rmstore { get; set; }
        public virtual RmZyBack RmZyBack { get; set; }
    }
}
