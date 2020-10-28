using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1= new Job();
            Job job2 = new Job();

           Assert.IsFalse(job1.Id == job2.Id);
        }

        [TestMethod]

        public void TestJobConstructorSetsAllFields()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreEqual(job1.Id, 1);
            Assert.AreEqual(job1.Name, "Product tester");
            Assert.AreEqual(job1.EmployerName.ToString(), "ACME");
            Assert.AreEqual(job1.EmployerLocation.ToString(), "Desert");
            Assert.AreEqual(job1.JobType.ToString(), "Quality control");
            Assert.AreEqual(job1.JobCoreCompetency.ToString(), "Persistence");

        }

        [TestMethod]

        public void TestJobsforEquality()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsFalse(job1.Equals(job2));
        }


        [TestMethod]

        public void TestToStringForBlankLines()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string job1string = job1.ToString();

            Assert.AreEqual(job1string.StartsWith("\n"), true);
            Assert.AreEqual(job1string.EndsWith("\n"), true);
        }

        [TestMethod]

        public void TestToStringForOwnFields()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
                

            Assert.AreEqual(job1.ToString(), "\n ID: " + job1.Id + "\n Name: " + job1.Name + "\n Employer: " + job1.EmployerName + "\n Location: " + job1.EmployerLocation + "\n Position Type: " + job1.JobType + "\n Core Competency: " + job1.JobCoreCompetency + "\n");

        }

        [TestMethod]

        public void TestToStringForDataNotAvailable()
        {
            Job job1 = new Job("Product tester", new Employer(""), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreEqual(job1.ToString().Contains("Data Not Available"), true);
           
        }

        [TestMethod]

        public void TestToStringForOops()
        {
            Job job1 = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));


            Assert.AreEqual(job1.ToString(), "OOPS! This job does not seem to exist.");

        }

    }
}
