namespace Domain.Entity.ProjectEntity.Financial
{
    public class ReceiptMaterial
    {
        public int Id { get; set; }
        public virtual Material Material { get; set; }
        public int Qty { get; set; }
        public string Note { get; set; }
    }
}
