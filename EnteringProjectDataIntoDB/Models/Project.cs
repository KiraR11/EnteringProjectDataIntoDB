namespace EnteringProjectDataIntoDB.Models
{
    public class Project
    {
        public Project(int id, string name, string nameCustometCompany, string nameContractorCompany, Employee manager, WorkingTeam team, DateOnly dateStart, DateOnly dateEnd, int priority)
        {
            Id = id;
            Name = name;
            NameCustometCompany = nameCustometCompany;
            NameContractorCompany = nameContractorCompany;
            Manager = manager;
            Team = team;
            DateStart = dateStart;
            DateEnd = dateEnd;
            Priority = priority;
        }

        public int Id { get;}
        public string Name { get; set; }
        public string NameCustometCompany { get; set; }
        public string NameContractorCompany { get; set; }
        public Employee Manager { get; set; }
        public WorkingTeam Team { get; set; }
        public DateOnly DateStart { get; set; }
        public DateOnly DateEnd { get; set; }
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
