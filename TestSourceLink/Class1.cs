using System;
using System.Collections.Generic;
using System.Text;

namespace TestSourceLink
{
    public class Class1
    {
        public void F()
        {
            Console.WriteLine("222");
        }

        public void G()
        {
            using (var db = new MyDbContext())
            {
                db.Add(new Person { Name = "test" });
                db.SaveChanges();
            }
        }
    }
}
