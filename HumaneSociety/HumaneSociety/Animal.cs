using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HumaneSociety
{

    [Table(Name = "Animals")]
    public class Animals
    {

    }



    public class Animal
    {
        public string animalName;
        public int animalID;
        public string animalClass;
        public string animalOrder;
        public string animalSpecies;
        public int roomNumber;
        public bool adoptionStatus;
        public string foodType;
        public int amountFoodWeek;
        public double animalPrice;
        public string personality;

        public Animal()
        {
            animalName = "";
            animalID = 0;
            animalClass = "";
            animalOrder = "";
            animalSpecies = "";
            roomNumber = 0;
            adoptionStatus = true;
            foodType = "";
            amountFoodWeek = 0;
            animalPrice = 0;
            personality = "";
        }




    }
}
