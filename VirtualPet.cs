using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet2
{
    class VirtualPet
    {
        //fields

        private string name;
        private int flower;
        private int swat;
        private int honey;


        //properties
        //so fields can be accessed

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Flower
        {
            get { return this.flower; }
            set { this.flower = value; }
        }

        public int Swat
        {
            get { return this.swat; }
            set { this.swat = value; }
        }

        public int Honey
        {
            get { return this.honey; }
            set { this.honey = value; }
        }

        //constructors

        public VirtualPet(int flower, int swat, int honey)
        {
            this.flower = flower;
            this.swat = swat;
            this.honey = honey;
        }

        //methods
        //the actions

        public void Status()
        {
            Console.WriteLine("Flower = " + flower);
            Console.WriteLine("Swat = " + swat);
            Console.WriteLine("Honey = " + honey);
        }

        public void Flowers()
        {
            flower -= 10;
            swat += 5;
        }

        public void Swatting()
        {
            swat -= 10;
            honey += 5;
        }

        public void GiveHoney()
        {
            honey -= 10;
            flower += 7;
        }

        public void Tick()
        {
            flower += 3;
            honey += 6;
        }
    }
}
    

