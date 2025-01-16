using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSahrpBasics.Relationships.Composition
{
    public class Car
    {
        public Engine Engine { get; set; }

        public Car()
        {
            Engine = new Engine();
        }

        public void Start()
        {
            Engine.Run();
        }

    }
}
