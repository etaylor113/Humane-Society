//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HumaneSociety
{
    using System;
    using System.Collections.Generic;
    
    public partial class Animal
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Animal_Class { get; set; }
        public string Animal_Order { get; set; }
        public string Animal_Species { get; set; }
        public Nullable<int> Room_Number { get; set; }
        public Nullable<bool> Adoption_Status { get; set; }      
        public string Food_Type { get; set; }
        public Nullable<int> Amount_Food_Week { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<bool> Vaccinations { get; set; }
        public string Personality { get; set; }
    }
}
