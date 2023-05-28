// See https://aka.ms/new-console-template for more information


using AutoMapper.QueryableExtensions;
using AutoMapperPOC.Classes;
using AutoMapperPOC.MappingProfile;

var employeeData = new Employee
{
    ID = 1,
    FirstName = "Ajeet",
    LastName = "Rana",
    Code = "Aj-123",
    DepartmentID = 1,
    Department = new Department { Id = 1, Name = "Admin" }
};

var mapper = MapperConfig.InitializeAutomapper();

var detail = mapper.Map<EmployeeDetail>(employeeData);

bool s = detail.ID.Equals(employeeData.Department.Id);
bool q = detail.EmployeeCode?.Equals(employeeData.Code) ?? false;
bool r = detail.EmployeeName?.Equals(employeeData.FirstName + employeeData.LastName) ?? false;
bool u = detail.DepartmentName?.Equals(employeeData.Department.Name) ?? false;

if (s && q && r && u)
    Console.WriteLine("Same data mapped.");

IQueryable<Employee> employees = new List<Employee>() { employeeData, employeeData, employeeData }.AsQueryable();

var projectData = employees.ProjectTo<EmployeeDetail>(mapper.ConfigurationProvider);

if (projectData.Count().Equals(employees.Count()))
    Console.WriteLine("Same data projected.");
