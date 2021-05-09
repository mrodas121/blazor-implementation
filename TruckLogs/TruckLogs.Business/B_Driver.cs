using Business.Interfaces;
using DataAccess;
using Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Driver: IB_Driver
    {
        private readonly IConfiguration Configuration;
        public B_Driver(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public List<DriverEntity> DriverList()
        {
            using (var db = new DataBaseContext(Configuration))
            {
                return db.Driver.ToList();
            }
        }

        public void CreateDriver(DriverEntity oDriver)
        {
            using (var db = new DataBaseContext(Configuration))
            {
                db.Driver.Add(oDriver);
                db.SaveChanges();
            }
        }

        public void EditDriver(DriverEntity oDriver)
        {
            using (var db = new DataBaseContext(Configuration))
            {
                db.Driver.Update(oDriver);
                db.SaveChanges();
            }
        }
        public void DeleteDriver(DriverEntity oDriver)
        {
            using (var db = new DataBaseContext(Configuration))
            {
                db.Driver.Remove(oDriver);
                db.SaveChanges();
            }
        }
        public DriverEntity GetDriver(int id)
        {
            using (var db = new DataBaseContext(Configuration))
            {
                return db.Driver.FirstOrDefault(d=>d.DriverId == id);
            }
        }
    }
}
