using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Human h1 = new Human(Human.Gender.female, Human.EyeColor.black, Human.HairColor.black, Human.Height.tall);
            //Human h2 = new Human(false, "White", "Blue", 4);
            //Human h3 = new Human(true, "Blond", "Green", 8);

            Console.WriteLine(h1.GetDescription());
            //Console.WriteLine(h2.GetDescription());
            //Console.WriteLine(h3.GetDescription());


            // The LAST line of code should be ABOVE this line
        }
    }
}
