
using System;
using System.Collections.Generic;

namespace Domain.Entity.ProjectEntity.Financial
{
    public class Receipt
    {
        public Suppliers Suppliers { get; set; }
        public int Id { get; set; }
        public string DateAndTime { get; set; }
        private ICollection<ReceiptMaterial> _receiptMaterial;
        public virtual ICollection<ReceiptMaterial> ReceiptMaterial
        {

            get { return _receiptMaterial ?? (_receiptMaterial = new List<ReceiptMaterial>()); }
            set { _receiptMaterial = value; }
        }

        public double CommercialDiscount { get; set; }
        private ICollection<Stores> _stores;
        public virtual ICollection<Stores> Stores
        {

            get { return _stores ?? (_stores = new List<Stores>()); }
            set { _stores = value; }
        }





    }
}