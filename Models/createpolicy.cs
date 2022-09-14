using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumerMicroservice.Models
{
    public class createpolicy
    {
      public int PolicyId { get; set; }
        public int ConsumerId { get; set; }
        public string Name { get; set; }
        public int BusinessId { get; set; }
        public int AgentId { get; set; }
        public int AcceptedQuotes { get; set; }
    }
}
