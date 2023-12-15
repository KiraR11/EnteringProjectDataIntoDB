using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Sockets;

namespace EnteringProjectDataIntoDB.Models
{
    public class Employee
    {
        public Employee(int id, string name, string surname, string patronymic, string email, List<int> idProjects)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Email = email;
            IdProjects = idProjects;
        }

        [Key]
        public int Id { get; }
        [DisplayName]
        public string Name { get;}
        public string Surname { get;}
        public string Patronymic { get;}
        public string Email { get;}
        List<int> IdProjects { get;}

        public void SignUpProjectById(int idProject)
        {
            if (IdProjects.IndexOf(idProject) != -1)
                IdProjects.Add(idProject);
            else
                throw new Exception("Сотрудник уже записан на данный проект");
        }
        /*public override bool Equals(object? obj)
        {
            if (obj is Employee)
            {
                var item = obj as Employee;
                if (item == null)
                    return false;
                else if (item.Id.Equals(Id))
                    return true;
                else
                    return false;
            }
            else return false;
        }
        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }*/
    }
}
