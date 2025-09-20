using consoleapp2;
using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Xml.Linq;
namespace consoleApp2
{
    class ConnectionAnimalandOpps
    {
         static void Main(string[] args)
         {
            Rectangle rect1 = new Rectangle();
            rect1.length = 200;
            rect1.width = 50;
            Console.WriteLine("Area of rectangele {0}", rect1.Area()); //1000

            Rectangle rect2 = new Rectangle(100, 40); //length=100 and breadth=40

            rect2 = rect1;     //here we can interchange the link  then rect2 length changed to 200
            rect1.length = 33;    //and rect1.length was changed to 33
            Console.WriteLine("Recatngle Area :{0}", rect2.length);
            Console.WriteLine("Rectangle Area :{0}", rect1.length);
            Console.WriteLine("Area Of Rectangle {0}", rect2.Area());




             
            //ANOTHER CLASS Calling using static methods

            Animal fox = new Animal("Red","Raww");
            Console.WriteLine("#the no of animals", Animal.GetAnimals());

            //another class calling using static methods

            Console.WriteLine("Area Of Recatngle :{0}", Opps.GetArea("Rectangle",10,21));
            Console.WriteLine("----------------------------------");
            Console.WriteLine("New Concept");

            int? radnnum = null;                //nullable type
            if (radnnum == null)
            {
                Console.WriteLine("This is nullable");
            }
            if (!radnnum.HasValue)
            {
                Console.WriteLine("This is nullable");
            }




            Animal cat = new Animal();
            cat.setname("kitty");
            cat.sound122 = "mewow";
            Console.WriteLine("The cat is name {0} and says {1}", cat.getname(), cat.sound122);

            cat.Owner = "Derek";
            Console.WriteLine("The Owner os the cat is {0}",cat.Owner);


            Console.WriteLine("{0} shelter id  is {1}", cat.getname(), cat.idnum);






        }

        struct Rectangle
        {
            public double length;
            public double width;
            public Rectangle(double l = 1, double w = 1) //contsructor
            {
                this.length = l;
                this.width = w;
            }
            public double Area()
            {
                return length * width;
            }
        }
    }
}