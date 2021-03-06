﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mod.Models
{
    public class MembershipType
    {
   
        public byte Id { get; set; } 
        [Required]
        public string Name { get; set; }    
        public short SignUpFee { get; set; }
        public byte DurationInMonth { get; set; }
        public byte DiscountRate { get; set; }
        
        //added Name, check Index for error
    }
}