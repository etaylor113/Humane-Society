﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class AdopterUI
    {

        HumaneSocietyEntities humaneSocietydb = new HumaneSocietyEntities();
        Adopter adopter = new Adopter();

        public string adopterFirstName;
        public string adopterLastName;
        public string userAddress;
        public string contactNumber;
        public string petPreference;
        public string adopterBio;
        public int navCounter;
        public bool refineSearch;

        public AdopterUI()
        {
            adopterFirstName = "";
            adopterLastName = "";
            userAddress = "";
            contactNumber = "";
            petPreference = "";
            adopterBio = "";
            navCounter = 0;
            refineSearch = false;
        }


        public void RunAdopterMenu()
        {
            Console.WriteLine("Are you already a member? Type number to continue. \n'1' - Sign up \n'2' - Skip to search");
            int response = Int32.Parse(Console.ReadLine());
            if (response == 1)
            {
                adopter.First_Name = GetFirstName();
                adopter.Last_Name = GetLastName();
                adopter.User_Address = GetAddress();
                adopter.Contact_Number = GetContactNumber();
                adopter.Pet_Preference = GetPetPreference();
                adopter.User_Bio = GetBio();
                humaneSocietydb.Adopters.Add(adopter);
                humaneSocietydb.SaveChanges();
                CompleteAccount();
                SkipToSearch();
                Console.Clear();
            }
            else if (response == 2)
            {
                SkipToSearch();
            }
        }

        public void SkipToSearch()
        {
            SearchByClass();
            if (refineSearch == true)
            {
                SearchByOrder();
            }

            if (refineSearch == true)
            {
                SearchByClass();
            }
            Console.Clear();
        }

        public string GetFirstName()
        {
            Console.WriteLine("You must create a profile before adopting a humane society animal. ");
            Console.WriteLine("\nPlease enter your first name: \n");
            string adopterFirstName = Console.ReadLine();
            return adopterFirstName;
        }

        public string GetLastName()
        {
            Console.WriteLine("\nPlease enter your last name:");
            string adopterLastName = Console.ReadLine();
            Console.Clear();
            return adopterLastName;
        }

        public string GetAddress()
        {
            Console.WriteLine("\nPlease enter your current address:");
            userAddress = Console.ReadLine();
            Console.Clear();
            return userAddress;
        }

        public string GetContactNumber()
        {
            Console.WriteLine("\nPlease enter a contact number:");
            contactNumber = Console.ReadLine().ToString();
            Console.Clear();
            return contactNumber;
        }

        public string GetPetPreference()
        {
            Console.WriteLine("\nEnter your pet preference below:");
            petPreference = Console.ReadLine();
            Console.Clear();
            return petPreference;
        }

        public string GetBio()
        {
            Console.WriteLine("\nPlease type a short bio of yourself to help us to determine a good adoptee for you.");
            adopterBio = Console.ReadLine();
            Console.Clear();
            return adopterBio;
        }

        public void CompleteAccount()
        {
            Console.WriteLine("\nProfile completed. Press enter to search for animals.");
            Console.ReadLine();
            Console.Clear();
        }

        public void SearchByClass()
        {
            try
            {
                Console.WriteLine("\nPlease choose the category of animal to search by: \n'1' - Mammals \n'2' - Birds \n'3' - Reptiles");
                int searchClass = Int32.Parse(Console.ReadLine());
                Console.Clear();
                switch (searchClass)
                {
                    case 1:
                        SearchForMammals();
                        ContinueMenu();
                        break;
                    case 2:
                        SearchForBirds();
                        ContinueMenu();
                        break;
                    case 3:
                        SearchForReptiles();
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
        }

        public void SearchByOrder()
        {
            Console.WriteLine("\nWould you like to select a pet to adopt or refine your search results? \n'1' - Select a pet \n'2' - Refine search results");
            int decision = Int32.Parse(Console.ReadLine());
            switch (decision)
            {
                case 1:
                    //linq sql
                    break;
                case 2:
                    ContinueMenu();
                    break;
            }
            Console.Clear();
            refineSearch = false;
        }

        public void SearchBySpecies()
        {
            Console.WriteLine("\nSelect a pet to adopt.");
            //linq sql
            Console.Clear();
            refineSearch = false;
        }

        public void SearchForMammals()
        {
            Console.WriteLine("Below are all available animals for adoption: \n");
            var mammals =
                from animals in humaneSocietydb.Animals
                where animals.Adoption_Status == false
                 && animals.Animal_Class == "Mammal"
                select new
                {
                    animals.Name,
                    animals.Personality,
                    animals.Price,
                    animals.Animal_Order,
                    animals.Animal_Species
                };                
            foreach (var mammal in mammals)
            {
                Console.WriteLine(mammal + "\n");
            }
        }

        public void SearchForBirds()
        {

        }

        public void SearchForReptiles()
        {

        }

        public void ContinueMenu()
        {
            try
            {
                Console.WriteLine("Would you like to select a pet to adopt or refine your search results? \n'1' - Select a pet \n'2' - Refine search results");
                int decision = Int32.Parse(Console.ReadLine());
                Console.Clear();
                switch (decision)
                {
                    case 1:
                        AdoptPet();
                        break;
                    case 2:
                        refineSearch = true;
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

        public void AdoptPet()
        {
            Console.WriteLine("Here is a list of available pets to adopt.");
            Console.Read();
        }



    }
}
