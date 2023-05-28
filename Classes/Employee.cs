namespace AutoMapperPOC.Classes
{
    public class Employee
    {
        public int ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Code { get; set; }
        public int DepartmentID { get; set; }
        public Department? Department { get; set; }
    }
}
