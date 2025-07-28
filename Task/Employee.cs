using System.Globalization;

namespace Task
{
    public class Employee
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public SecurityLevel Security { get; set; }
        public decimal Salary { get; set; }
        public HiringDate HireDate { get; set; }

        private char gender;
        public char Gender
        {
            get => gender;
            set
            {
                if (value == 'M' || value == 'F')
                {
                    gender = value;
                }
                else
                {
                    throw new Exception("Gender must be 'M' or 'F' .");
                }
            }
        }
        // Constructor
        public Employee(int id, string name, SecurityLevel security, decimal salary, HiringDate hireDate, char gender)
        {
            ID = id;
            Name = name;
            Security = security;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }


        public override string ToString() => $"ID: {ID}\n" +
                                             $"Name: {Name}\n" +
                                             $"Gender: {(Gender == 'M' ? "Male" : "Female")}\n" +
                                             $"Security Level: {Security}\n" +
                                             $"Salary: {String.Format(CultureInfo.CurrentCulture, "{0:C}", Salary)}\n" +
                                             $"Hire Date: {HireDate.ToString()}";
    }



}
