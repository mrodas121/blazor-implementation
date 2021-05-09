using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IB_Driver
    {
        public void CreateDriver(DriverEntity oDriver);
        public List<DriverEntity> DriverList();
        void EditDriver(DriverEntity oDriver);
        public DriverEntity GetDriver(int id);
        void DeleteDriver(DriverEntity oDriver);
    }
}
