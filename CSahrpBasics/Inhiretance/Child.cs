using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSahrpBasics.Inhiretance
{
    public class Child : Parent
    {
        public int Z { get; set; }

        public Child(int x , int y , int z) : base (x , y)
        {
            Z = z;
        }

        public new int ProductOfNumbers()
        {
            return X * Y * Z;
        }

        public override string? ToString()
        {
            return  $"X = {X}, Y = {Y},Z = {Z}";
        }
    }
}
