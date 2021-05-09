using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class DriverStates
    {
        public int Id { get; set; }
        public string State { get; set; }

        public List<DriverStates> GetStates()
        {
            var states = new List<DriverStates>();
            states.Add(new DriverStates() { Id = 1, State = "Activo" });
            states.Add(new DriverStates() { Id = 2, State = "Incapacitado" });
            states.Add(new DriverStates() { Id = 3, State = "Inactivo" });
            return states;
        }
    }
}
