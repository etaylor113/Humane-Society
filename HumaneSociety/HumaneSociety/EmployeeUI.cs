using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public  class EmployeeUI
    {

        


        public void RunEmployeeMenu()
        {
            try
            {
                Console.WriteLine("Type number for command. \n'1' - Add adoptee \n'2' - View User Profiles");
                int menuChoice = Int32.Parse(Console.ReadLine());
                Console.Clear();
                switch (menuChoice)
                {
                    case 1:
                        AddAdoptee();
                        break;
                    case 2:
                        ViewUserProfile();
                        break;
                    default:
                        RunEmployeeMenu();
                        break;
                }
            }
            catch
            {
                RunEmployeeMenu();
                Console.Clear();
            }          
        }

        public void AddAdoptee()
        {

        }

        public void ViewUserProfile()
        {

        }


    }
}
