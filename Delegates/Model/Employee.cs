namespace Delegates.Model
{
    internal class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string DeptName { get; set; }
    }
    internal class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
        public string Location { get; set; }
    }
}


