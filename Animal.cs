using System;
using System.Diagnostics;
namespace consoleapp2
{
    class Animal
    {
        private string name;
        private string sound;
        public static int numofanimals = 0;

        public const string Shelter = "derks home animals";

        public readonly int idnum;


        /* public Animal()
         {
             name = "No Name";
             sound = "No Sound";
             numofanimals++;

         }  or
        */



        public Animal(): this("No Name", "No Sound") { }


        /**

        public Animal(string name="No Name")
        {
            this.sound = "No Sound";
            this.name = name;
            numofanimals++;
        }
        **/

        public Animal(string name) : this(name, "No  Sound") { }

        /**
         public Animal(string name="No Name",string sound="No Sound")
        {
            this.name = name;
            this.sound = sound;
            numofanimals++;
        
        **/

        public Animal(string name, string sound)
        {

            setname(name);
            sound122 = sound;
            numofanimals = 1;
            Random rand = new Random();
            idnum = rand.Next(1, 21473299);

        }


        public void MakeSound()
        {
            Console.WriteLine("{0} Says {1} sound:", this.name, this.sound);
        }

        public static int GetAnimals()
        {
            return numofanimals;
        }



        public void setname(string name)
        {
            if (!(name.Any(char.IsDigit)))
            {
                this.name = name;
            }
            else
            {
                this.name = "No Name";
                Console.WriteLine("Name cannot contains Numbers");

            }
        }


        public string getname()
        {
            return name;
        }

        public string sound122
        {
            get { return sound; }

            set
            {
                if(value.Length> 10)
                {
                    sound = "No sound";
                    Console.WriteLine("Sound is Too Long");
                }
                else
                {
                    this.sound = value;
                }

            }
        }

        public string Owner { get; set; } = "No Owner";

        public static int numofAnimals
        {
            get { return numofAnimals; }
            set
            {
                numofAnimals += value;
            }
        }
    }
   
}