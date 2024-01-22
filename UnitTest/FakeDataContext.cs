using calendar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    
    internal class FakeDataContext:IDataContext
    {

        public List<Event> events { get; set; }
        public FakeDataContext()
        {
            events = new List<Event>
                { new Event { Id = 1, Title = "event 1", Start = new DateTime(2023,12,09),End = new DateTime(2023,12,09) },
                  new Event { Id = 2, Title = "event 2", Start = new DateTime(2023,01,09),End = new DateTime(2023,02,09) },
                  new Event { Id = 3, Title = "event 3", Start = new DateTime(2023,01,09),End = new DateTime(2023,01,09) }
                };
        }

    }
}
