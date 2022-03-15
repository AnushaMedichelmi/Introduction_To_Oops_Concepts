using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductonToOops
{
    /* Introduction to Classes
     * Class is a blueprint that defines an object.
     * It has actions/methods,properties, and so on of similar functonalities.
     * Examples: String is a class
     * Object : It has almost similar kind of properties/methods/behaviour of class.
     * Properties: Doors, Wheels, Lights etc
     * Methods: Driving, Putting Lights on and off, Opening doors etc
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Human anusha = new Human("Anusha","Medichelmi");
            Human anusha1 = new Human("Lavanya","Reddaboina","Black",21);
            Human anusha2 = new Human();
            // Created an object of a Human class or instance of a Human class
            //anusha.firstName = "Anusha";
            //anusha1.firstName = "Lavanya";
            // Acess public variable from outside the class and even changed it.
            shivani.IntroduceMySelf();// Call the method of the class
            shivani2.IntroduceMySelf();
            shivani3.IntroduceMySelf();
            */
            //BoxClass box = new BoxClass(2,3,5);
            BoxClass box = new BoxClass();
            //box.SetLength(4);
            box.Length = 4;
            box.Height = 5;
            box.Width = 6;
            box.Volume=0;
            box.Display();
            Console.WriteLine(box.Volume);
            Console.ReadLine();
            
        }
    }
}
