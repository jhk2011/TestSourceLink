namespace TestSourceLink.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Fail()
        {
            Assert.Fail("fail");
        }

        [TestMethod]
        public void Pass()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestDb()
        {
            using (var db = new MyDbContext())
            {
                db.Database.EnsureCreated();

                db.Person.Add(new Person { Name = "test" });
                db.SaveChanges();
            }

            using (var db = new MyDbContext())
            {
                var items = db.Person.ToList();
                Assert.IsTrue(items.Any(x => x.Name == "test"));
            }
        }
    }
}