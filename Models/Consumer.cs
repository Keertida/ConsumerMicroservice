using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ConsumerMicroservice.Models
{
    public partial class Consumer
    {
        public int ConsumerId { get; set; }
        public string Name { get; set; }

        //[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = false)]
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public string Pancard { get; set; }
       public string business_Overview { get; set; }
          public int no_of_employees { get; set; }
  public int annual_turnover { get; set; }
 public int capitalInvested { get; set; }
 public int BusinessValue { get; set; } 
        public int AgentId { get; set; }

    }
}
