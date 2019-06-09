using SilkPlaster.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilkPlaster.DataAccessLayer.EntityFramework
{
    public class MyInitializer : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            Member member = new Member()
            {
                FirstName = "Yusuf",
                LastName = "Yılmaz",
                Email = "yusufyilmazfr@gmail.com",
                Password = "123",
                AddedDate = DateTime.Now
            };

            context.Members.Add(member);
            context.SaveChanges();


            for (int i = 0; i < 10; i++)
            {
                Member tempMember = new Member()
                {
                    FirstName = FakeData.NameData.GetFirstName(),
                    LastName = FakeData.NameData.GetSurname(),
                    Email = FakeData.NetworkData.GetEmail(),
                    Password = FakeData.NumberData.GetNumber(2656).ToString(),
                    AddedDate = FakeData.DateTimeData.GetDatetime()
                };

                context.Members.Add(member);
            }
            context.SaveChanges();
        }
    }
}
