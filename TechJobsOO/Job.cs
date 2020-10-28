using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }


        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }



        // TODO: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, object employerName, object employerLocation, object positionType, object coreCompetency) : this()
        {
            Name = name;
            EmployerName = new Employer(employerName.ToString());
            EmployerLocation = new Location(employerLocation.ToString());
            JobType = new PositionType(positionType.ToString());
            JobCoreCompetency = new CoreCompetency(coreCompetency.ToString());
            
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        // TODO: Generate Equals() and GetHashCode() methods.

        public override string ToString()
        {
            string errorMessage = "Data Not Available";

            if (Name == "" || Name == null &&
             EmployerName.ToString() == "" &&
             EmployerLocation.ToString() == "" &&
             JobType.ToString() == "" &&
             JobCoreCompetency.ToString() == "")
            {
                return "OOPS! This job does not seem to exist.";
            }

            if (Name == null)
            {
                Name = errorMessage;
            } 
            if (EmployerName.ToString() == "")
            {
                EmployerName = new Employer(errorMessage);
            }
            if (EmployerLocation.ToString() == "")
            {
                EmployerLocation = new Location(errorMessage);
            }
            if (JobType.ToString() == "")
            {
                JobType = new PositionType(errorMessage);
            }
            if (JobCoreCompetency.ToString() == "")
            {
                JobCoreCompetency = new CoreCompetency(errorMessage);
            }

         
            return "\n ID: " + Id + 
                "\n Name: " + Name + 
                "\n Employer: " + EmployerName + 
                "\n Location: " + EmployerLocation + 
                "\n Position Type: " + JobType + 
                "\n Core Competency: " + JobCoreCompetency + "\n";

        }


    }
}
