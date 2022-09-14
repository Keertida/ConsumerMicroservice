using System;
using System.Collections.Generic;

#nullable disable

namespace ConsumerMicroservice.Models
{
    public partial class Property
    {
        public int PropertyId { get; set; }
        public string BuildingType { get; set; }
        public int Buildingsqft { get; set; }
        public int BuildingStoreys { get; set; }
        public int BuildingAge { get; set; }
        public int CostOfAssest { get; set; }
        public int SalvageValue { get; set; }
        public int UsefulLifeOfAssest { get; set; }
        public int PropertyValue { get; set; }
        public int ConsumerId { get; set; }
        //public virtual PropertyMaster PropertyMaster { get; set; }

    }
}
