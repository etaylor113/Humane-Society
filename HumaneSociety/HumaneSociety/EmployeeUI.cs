using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.SqlClient;

namespace HumaneSociety
{
    public class EmployeeUI
    {
        
        HumaneSocietyEntities humanSocietydb = new HumaneSocietyEntities();
        Animal animal = new Animal();
        Adopter adopter = new Adopter();
        public bool adoptedStatus;
        public bool vaccinationStatus;
        public string convertAdoptionStatus;
        public string convertVaccinationStatus;
        public void RunEmployeeMenu()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Type number for command. \n'1' - Add adoptee \n'2' - Update information \n'3' - View all animals \n'4' - View User Profiles");
                int menuChoice = Int32.Parse(Console.ReadLine());
                Console.Clear();
                
                switch (menuChoice)
                {
                    case 1:
                        AddAdoptee();
                        break;
                    case 2:
                        UpdateInformation();
                        break;
                    case 3:
                        ViewAllPets();
                        break;
                    case 4:
                        ViewUserProfile();
                        break;
                    default:
                        RunEmployeeMenu();
                        break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Clear();
                RunEmployeeMenu();                
            }
        }

        public void ViewAllPets()
        {            
            Console.WriteLine("Below are all current animals registered at the humane society.\n");                       
                foreach (var animal in humanSocietydb.Animals)
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine("Name: " + animal.Name);
                    Console.WriteLine("ID: " + animal.ID);
                    Console.WriteLine("Animal Class: " + animal.Animal_Class);
                    Console.WriteLine("Animal Order: " + animal.Animal_Order);
                    Console.WriteLine("Animal Species: " + animal.Animal_Species);
                    ConvertAdoptionToString();
                    Console.WriteLine("Price: " + animal.Price);
                    Console.WriteLine("Room Number: " + animal.Room_Number);
                    Console.WriteLine("Personality: " + animal.Personality);
                    ConvertVaccinationToString();
                    Console.WriteLine("Food Type: " + animal.Food_Type);
                    Console.WriteLine("Amount Food per Week: " + animal.Amount_Food_Week);
                }           
            Console.Read();
            RunEmployeeMenu();
        }

        public void ViewUserProfile()
        {
            Console.WriteLine("Below are a list of all current humane society users.\n");            
                foreach (var adopter in humanSocietydb.Adopters)
                {
                    Console.WriteLine("\n-----------------------");
                    Console.WriteLine("ID: " + adopter.ID);
                    Console.WriteLine("First Name: " + adopter.First_Name);
                    Console.WriteLine("Last Name: " + adopter.Last_Name);
                    Console.WriteLine("Address: " + adopter.User_Address);
                    Console.WriteLine("Contact Number: " + adopter.Contact_Number);
                    Console.WriteLine("Pet Preference: " + adopter.Pet_Preference);
                    Console.WriteLine("Bio: " + adopter.User_Bio);
                }          
            Console.Read();
            RunEmployeeMenu();
        }

        public void ConvertAdoptionToString()
        {
            if (animal.Adoption_Status == true)
            {
                Console.WriteLine("Adoption Status: Adopted");
            }
            else if (animal.Adoption_Status == false)
            {
                Console.WriteLine("Adoption Status: Not adopted");
            }               
        }

        public void ConvertVaccinationToString()
        {
            if (animal.Vaccinations == true)
            {
                Console.WriteLine("Vaccination Status: Vaccinated");
            }
            else if (animal.Vaccinations == false)
            {
                Console.WriteLine("Vaccination Status: Not vaccinated");
            }
        }

        public void AddAdoptee()
        {                                 
            Console.WriteLine("Fill out preceding adoptee information to input into the database.");          
            animal.Name = AddName();
            animal.Animal_Class = AddClass();
            animal.Animal_Order = AddOrder();
            animal.Animal_Species = AddSpecies();
            animal.Room_Number = AddRoomNumber();
            animal.Adoption_Status = AddAdoptionStatus();
            animal.Vaccinations = AddVaccinationStatus();
            animal.Food_Type = AddFoodType();
            animal.Amount_Food_Week = AddAmountFoodWeek();
            animal.Price = AddPrice();
            animal.Personality = AddPersonality();
            humanSocietydb.Animals.Add(animal);
            humanSocietydb.SaveChanges();
            ConfirmAnimal();
            RunEmployeeMenu();
        }

        public void UpdateInformation()
        {          
            Console.WriteLine("What would you like to update? \n'1' - Adoption status \n'2' - Vaccination status");
            int updateStatus = Int32.Parse(Console.ReadLine());
            switch (updateStatus)
            {
                case 1:
                    UpdateAdoptionStatus();
                    break;
                case 2:
                    UpdateVaccinationStatus();
                    break;
                default:
                    UpdateInformation();
                    break;
            }
        }

        public void UpdateAdoptionStatus()
        {
            Console.WriteLine("Please type the ID of the animal you want to update.");
            int animalID = Int32.Parse(Console.ReadLine());
            var adoptionStatus =
                from animal in humanSocietydb.Animals
                where animal.ID == animalID
                select animal;
            foreach (var animal in adoptionStatus)
            {
                if (animal.Adoption_Status == true)
                {
                    animal.Adoption_Status = false;
                }
                else if (animal.Adoption_Status == false)
                {
                    animal.Adoption_Status = true;
                }
            }
            Console.WriteLine("Adoption status changed to " + animal.Adoption_Status);
            RunEmployeeMenu();
        }

        public void UpdateVaccinationStatus()
        {
            Console.WriteLine("Please type the ID of the animal you want to update.");
            int animalID = Int32.Parse(Console.ReadLine());
            var vaccinationStatus =
                from animal in humanSocietydb.Animals
                where animal.ID == animalID
                select animal;
            foreach (var animal in vaccinationStatus)
            {
                if (animal.Vaccinations == true)
                {
                    animal.Vaccinations = false;
                }
                else if (animal.Vaccinations == false)
                {
                    animal.Vaccinations = true;
                }
            }
            Console.WriteLine("Vaccination status has been changed to " + animal.Vaccinations);
            RunEmployeeMenu();
        }

        public string AddName()
        {           
            Console.WriteLine("\nPlease type adoptee name:");
            return Console.ReadLine();           
        }      

        public string AddClass()
        {
            Console.WriteLine("\nType Class of animal: (Mammal, Bird, or Reptile)");
            return Console.ReadLine();
        }

        public string AddOrder()
        {
            Console.WriteLine("\nType Order of animal: (Example: Dog, Cat, Duck, Lizard)");
            return Console.ReadLine();
        }

        public string AddSpecies()
        {
            Console.WriteLine("\nType Species of animal: (Example: Poodle, Siamese, Mallard, Iguana)");
            return Console.ReadLine();
        }

        public int AddRoomNumber()
        {
            Console.WriteLine("\nType room number animal populates: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public bool AddAdoptionStatus()
        {           
            Console.WriteLine("\nType adoption status: \n'Yes' - Adopted \n'No' - Not Adopted");
            string response = Console.ReadLine();
            switch (response)
            {
                case "Yes":
                    adoptedStatus = true;
                    break;
                case "No":
                    adoptedStatus = false;
                    break;
                default:
                    AddAdoptionStatus();
                    break;
            }
            return adoptedStatus;
        }

        public bool AddVaccinationStatus()
        {
            Console.WriteLine("\nType vaccination status: \n'Yes' - Vaccinated \n'No' - not vaccinated");
            string response = Console.ReadLine();
            switch (response)
            {
                case "Yes":
                    vaccinationStatus = true;
                    break;
                case "No":
                    vaccinationStatus = false;
                    break;
                default:
                    AddVaccinationStatus();
                    break;
            }
            return vaccinationStatus;
        }
    
        public string AddFoodType()
        {
            Console.WriteLine("\nType animal's food type: (Example: Kibble, Canned, Lettuce)");
            return Console.ReadLine();
        }

        public int AddAmountFoodWeek()
        {
            Console.WriteLine("\nType number of feedings required on a weekly basis:");
            return Convert.ToInt32(Console.ReadLine());
        }

        public decimal AddPrice()
        {
            Console.WriteLine("\nType adoption price:");
            return Convert.ToDecimal(Console.ReadLine());
        }

        public string AddPersonality()
        {
            Console.WriteLine("\nType personality of animal. If animal does not have a personality, type N/A:");
            return Console.ReadLine();
        }

        public void ConfirmAnimal()
        {
            Console.WriteLine("\nAnimal has been added to database.");
            Console.Read();
        }




    }
}
