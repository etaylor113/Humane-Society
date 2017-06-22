using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class MainPage
    {
        

        public void RunMainMenu()
        {
            Console.WriteLine("Welcome to the humane society! \nPlease enter your status. \n'1' - Adopter \n'2' - Employee");
            int decision = Int32.Parse(Console.ReadLine());
            switch (decision)
            {
                case 1:
                    Adopter.RunAdopterMenu();
                    break;
                case 2:
                    Employee.RunEmployeeMenu();
                    break;
            }
        }




       


    }
}
