using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.ProjectEntity.Patient.OperationSergury.AfterSergury
{
    public class ToDoForPatient
    {
        public int Id { get; set; }
        public Nurse Nurse { get; set; }
        public  string  ToDo { get; set; }
        public int after { get; set; }
        public bool IsDone { get; set; }





    }
}
