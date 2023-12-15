namespace EnteringProjectDataIntoDB.Models
{
    public class WorkingTeam
    {
        public WorkingTeam(List<Employee> employees)
        {
            Employees = employees;
        }

        public List<Employee> Employees { get;}

        public void IncludeEmployee(Employee employee)
        {
            if (Employees.IndexOf(employee) != -1)
                Employees.Add(employee);
            else
                throw new Exception("Сотрудник состоит в рабочей группе");
        }
        public void ExcludeEmployeeById(Employee employee)
        {
            int IdEmployee = Employees.IndexOf(employee);
            if (EmployeeIsAvailable(employee))
                Employees.Remove(employee);
            else
                throw new Exception("Такого сотрудника нет в рабочей группе");
        }
        public bool EmployeeIsAvailable(Employee employee)
        {
            int IdEmployee = Employees.IndexOf(employee);
            if (IdEmployee != -1)
                return true;
            else
                return false;
        }

    }
}
