using Practical_10_1.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_10_1.Data.Services
{
    /// <summary>
    /// here inherented interface
    /// all method are override 
    /// </summary>
    public class InMemoryUserData : IUserData
    {
        List<User> Users;
        /// <summary>
        /// InMemoryUserData has Constructor to assign some predefined values of lists
        /// </summary>
        public InMemoryUserData()
        {
            Users = new List<User>()
            {
                    new User{Id=1,Name="Rajesh Makwana",Date_Of_Brith="23/06/2003",Address="9/622, Wadifaliya Surat"},
                    new User{Id=2,Name="Raju Srivastava",Date_Of_Brith="16/06/1997",Address="B-23,Vijay Nagar Socity,Surat"},
                    new User{Id=3,Name="Reema Kagti",Date_Of_Brith="10/01/1999",Address="Udhna Darwaja Road,Surat"},
            };
        }
        //add data to list
        public void create(User user)
        {
            Users.Add(user);
            user.Id = Users.Max(r => r.Id) + 1;
        }
        //delete data into a list
        public void Delete(int id)
        {
            //fetch particular user data
            var res = Get(id);
            if (res != null)
            {
                //finally remove
                Users.Remove(res);
            }
        }
        //get particular user data
        public User Get(int id)
        {
            return Users.FirstOrDefault(r => r.Id == id);
        }
        //update particular user data
        public void update(User user)
        {
            var existing = Get(user.Id);
            if (existing != null)
            {
                existing.Name = user.Name;
                existing.Date_Of_Brith = user.Date_Of_Brith;
                existing.Address = user.Address;

            }
        }
        //get list of all data
        public IEnumerable<User> ViewAll()
        {
            return Users.OrderBy(r => r.Id);
        }
    }
}
