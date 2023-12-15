using System.ComponentModel.DataAnnotations;

namespace EnteringProjectDataIntoDB.Models
{
    public class Project
    {
        public Project(int id, string name, string nameCustometCompany, string nameContractorCompany, int idManager, List<int> idEmployees, DateOnly dateStart, DateOnly dateEnd, int priority)
        {
            Id = id;
            Name = name;
            NameCustometCompany = nameCustometCompany;
            NameContractorCompany = nameContractorCompany;
            IdManager = idManager;
            IdEmployees = idEmployees;
            DateStart = dateStart;
            DateEnd = dateEnd;
            Priority = priority;
        }
        public Project(int id, string name, string nameCustometCompany, string nameContractorCompany, int idManager,List<int> idEmployees, DateOnly dateStart, int priority)
        {
            Id = id;
            Name = name;
            NameCustometCompany = nameCustometCompany;
            NameContractorCompany = nameContractorCompany;
            IdManager = idManager;
            IdEmployees = idEmployees;
            DateStart = dateStart;
            Priority = priority;
        }
        public int Id { get;}
        public string Name { get; set; }
        public string NameCustometCompany { get; set; }
        public string NameContractorCompany { get; set; }
        public int IdManager { get; set; }
        public List<int> IdEmployees { get;}
        public DateOnly DateStart { get; set; }
        public DateOnly? DateEnd { get; set; }
        public int Priority { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj is Project)
            {
                var item = obj as Project;
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
        }
    }
}
