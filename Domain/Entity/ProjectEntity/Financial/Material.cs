using System.Collections.Generic;

namespace Domain.Entity.ProjectEntity.Financial
{
    public class Material
    {
        
        public int Id { get; set; }
        public int Name { get; set; }
        public byte[] BarCode { get; set; }
        public string Producer { get; set; }
        public string Descriptioin { get; set; }
        private ICollection<UnitsAndPrice> _unitsAndPrice;
        public virtual ICollection<UnitsAndPrice> UnitsAndPrice
        {

            get { return _unitsAndPrice ?? (_unitsAndPrice = new List<UnitsAndPrice>()); }
            set { _unitsAndPrice = value; }
        }

        private ICollection<ReceiptMaterial> _receiptMaterial;
        public virtual ICollection<ReceiptMaterial> ReceiptMaterial
        {

            get { return _receiptMaterial ?? (_receiptMaterial = new List<ReceiptMaterial>()); }
            set { _receiptMaterial = value; }
        }
      
        public string Create { get; set; }
        public AspNetUser CreatedBy { get; set; }
        public string Update { get; set; }
        public AspNetUser UpdetedBy { get; set; }
        public  virtual Stocks Stocks { get; set; }

        public float Price { get; set; }
        public float Price2 { get; set; }
        public float Cost { get; set; }
        public int prop { get; set; }

    }
}