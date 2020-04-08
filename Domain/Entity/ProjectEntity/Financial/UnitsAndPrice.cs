namespace Domain.Entity.ProjectEntity.Financial
{
    public class UnitsAndPrice
    {
        public virtual Material  Material { get; set; }
        public int Id { get; set; }
        public string UnitName { get; set; }
        public int UnitWight { get; set; }
        public string unitPerBox { get; set; }// الصندوق هو وحدة التغليف النعائي 
        public string retailPrice { get; set; }
        public string WholesalePrice { get; set; }

    }
}