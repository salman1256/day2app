// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** Welcome to Employee Management App ***");
List<Employee> lstEmployees=new List<Employee> 
{
    new Employee{Id=1,Name="Sam",Designation="Manager",Salary=98000.70,
    DoJ=new DateTime(day:18,month:10,year:2021)},
    new Employee{Id=2,Name="Raj",Designation="Developer",Salary=58000.70,
    DoJ=new DateTime(day:12,month:03,year:2022)},
    new Employee{Id=3,Name="Rinu",Designation="Hr",Salary=45000.50,
    DoJ=new DateTime(day:21,month:02,year:2022)}
       

};
Console.WriteLine($"Number of Employees:{lstEmployees.Count}");
Console.WriteLine("ID \t Name \t Designation \t \t Salary \t \t Dateof Joining");
foreach(Employee e in lstEmployees)
{
    Console.WriteLine(e.Id+"\t"+e.Name +"\t "+e.Designation +"\t \t"+e.Salary +"\t \t"+e.DoJ.ToShortDateString());
    System.Console.WriteLine();

}
