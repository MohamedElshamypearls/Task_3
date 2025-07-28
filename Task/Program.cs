namespace Task
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Employee[] EmpArr = new Employee[3] 
                {
                    new Employee(
                                    id: 1,
                                    name: "Ahmed",
                                    security: SecurityLevel.DBA,
                                    salary: 120000m,
                                    hireDate: new HiringDate(15, 3, 2025),
                                    gender: 'F'
                                ),
                    
                    new Employee(
                                    id: 2,
                                    name: "Salah",
                                    security: SecurityLevel.Guest,
                                    salary: 50000m,
                                    hireDate: new HiringDate(10, 8, 2023),
                                    gender: 'M'
                                ), 
                    
                    new Employee(
                                    id: 3,
                                    name: "Mohamed",
                                    security: SecurityLevel.Secretary,
                                    salary: 95000m,
                                    hireDate: new HiringDate(5, 1, 2024),
                                    gender: 'M'
                                )
                };


                foreach (var item in EmpArr)
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine(item);
                }

                Console.WriteLine("--------------------------------- After Sorting ---------------------------------");
                Array.Sort(EmpArr, (e1, e2) => e1.HireDate.CompareTo(e2.HireDate));


                foreach (var emp in EmpArr)
                {
                    Console.WriteLine(emp);
                    Console.WriteLine("---------------------------------");
                }

                Console.WriteLine("\n Boxing and Unboxing Count: 0");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
