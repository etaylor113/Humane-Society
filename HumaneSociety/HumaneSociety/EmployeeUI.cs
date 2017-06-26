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
        
        HumaneSocietyEntities db = new HumaneSocietyEntities();
        Animal animal = new Animal();
        public bool adoptedStatus;
        public bool vaccinationStatus;
        public void RunEmployeeMenu()
        {
            try
            {
                Console.WriteLine("Type number for command. \n'1' - Add adoptee \n'2' - View all animals \n'3' - View User Profiles");
                int menuChoice = Int32.Parse(Console.ReadLine());
                Console.Clear();
                
                switch (menuChoice)
                {
                    case 1:
                        AddAdoptee();
                        break;
                    case 2:
                        ViewAllPets();
                        break;
                    case 3:
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
                RunEmployeeMenu();
                Console.Clear();
            }
        }

        public void ViewAllPets()
        {          
            Console.WriteLine("Below are all current animals registered at the humane society.\n");
            foreach (Animal row in db.Animals)
            {
                Console.WriteLine("----------------------");
                foreach (var item in db.Animals)
                {
                    Console.WriteLine(item.Name);
                    Console.WriteLine(item.ID);
                    Console.WriteLine(item.Animal_Class);
                    Console.WriteLine(item.Animal_Order);
                    Console.WriteLine(item.Animal_Species);
                    Console.WriteLine(item.Adoption_Status);
                    Console.WriteLine(item.Price);
                    Console.WriteLine(item.Room_Number);
                    Console.WriteLine(item.Personality);
                    Console.WriteLine(item.Vaccinations);
                    Console.WriteLine(item.Food_Type);
                    Console.WriteLine(item.Amount_Food_Week);
                }
            }
            Console.Read();
        }

        public void ViewUserProfile()
        {
            Console.WriteLine("Below are a list of all current humane society users.\n");
            //linq sql
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
            db.Animals.Add(animal);
            db.SaveChanges();
            ConfirmAnimal();
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
