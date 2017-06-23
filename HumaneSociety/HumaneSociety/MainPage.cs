using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class MainPage
    {
        AdopterUI adopterUI = new AdopterUI();
        EmployeeUI employeeUI = new EmployeeUI();

        public void RunMainMenu()
        {
            try
            {
                Console.WriteLine("Welcome to the humane society! \nPlease enter your status. \n'1' - Adopter \n'2' - Employee");
                int decision = Int32.Parse(Console.ReadLine());
                Console.Clear();
                switch (decision)
                {
                    case 1:
                        adopterUI.RunAdopterMenu();
                        break;
                    case 2:
                        employeeUI.RunEmployeeMenu();
                        break;
                    default:
                        RunMainMenu();
                        break;
                }
            }
            catch
            {
                RunMainMenu();
            }           
        }

   


    }
}




