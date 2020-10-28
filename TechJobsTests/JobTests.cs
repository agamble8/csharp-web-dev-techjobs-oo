using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            Job testJob1 = new Job();
            Job testJob2 = new Job();
            Assert.IsTrue(testJob2.Id - testJob1.Id == 1);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual(job1.Name, "Product tester");
            Assert.AreEqual(job1.EmployerName.ToString(), "ACME");
            Assert.AreEqual(job1.EmployerLocation.ToString(), "Desert");
            Assert.AreEqual(job1.JobType.ToString(), "Quality control");
            Assert.AreEqual(job1.JobCoreCompetency.ToString(), "Persistence");
            Assert.IsNotNull(job1.Id);
        }
    }
}
