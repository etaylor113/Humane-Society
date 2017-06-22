using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class AdopterUI
    {

        public string adopterFullName;
        public int classMenuChoice;
        public bool refineSearch = false;
        public string adopterBio;

        public AdopterUI()
        {
            adopterFullName = "";
            classMenuChoice = 0;
            adopterBio = "";
        }

        public void RunAdopterMenu()
        {
            GetName();
            GetBio();

            SearchByClass();            
            if (refineSearch == true)
            {
                SearchByOrder();
            }

        }

        public string GetName()
        {
            try
            {
                Console.WriteLine("You must create a profile before adopting a humane society animal. \nPlease enter your first name: \n");
                string adopterFirstName = Console.ReadLine();
                Console.WriteLine("\nPlease enter your last name:");
                string adopterLastName = Console.ReadLine();
                adopterFullName = adopterFirstName + adopterLastName;
                Console.Clear();
            }
            catch
            {
                GetName();
            }           
            return adopterFullName;
        }

        public string GetBio()
        {
            Console.WriteLine("Please type a short bio of yourself to help us to determine a good adoptee for you.");
            adopterBio = Console.ReadLine();
            Console.Clear();
            return adopterBio;
        }

        public void CompleteAccount()
        {
            Console.WriteLine("Profile completed. Continue to search for animals.");
            Console.ReadLine();
            Console.Clear();
        }

        public void SearchByClass()
        {
            try
            {
                Console.WriteLine("Please choose the category of animal to search by: \n'1' - Mammals \n'2' - Birds \n'3' - Reptiles");
                int searchClass = Int32.Parse(Console.ReadLine());
                switch (searchClass)
                {
                    case 1:
                        classMenuChoice = 1;

                        ContinueMenu();
                        break;
                    case 2:
                        classMenuChoice = 2;

                        ContinueMenu();
                        break;
                    case 3:
                        classMenuChoice = 3;

                        ContinueMenu();
                        break;
                    default:
                        SearchByClass();
                        break;
                }
            }
            catch
            {
                SearchByClass();
            }
            Console.Clear();
        }

        public void SearchByOrder()
        {
            Console.WriteLine("These are the types of animals currently available for adoption.");
            int decision = Int32.Parse(Console.ReadLine());
            switch (classMenuChoice)
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;

            }
            Console.Clear();
        }






        public void ContinueMenu()
        {
            try
            {
                Console.WriteLine("Would you like to select a pet do adopt from here or refine your search results? \n'1' - Select a pet \n'2' - Refine search results");
                int decision = Int32.Parse(Console.ReadLine());
                switch (decision)
                {
                    case 1:

                        break;
                    case 2:
                        SearchByOrder();
                        break;
                    default:
                        ContinueMenu();
                        break;
                }
            }
            catch
            {
                ContinueMenu();
            }
        }






    }
}
