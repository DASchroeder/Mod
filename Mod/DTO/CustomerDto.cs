using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Mod.Models;

namespace Mod.DTO
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        public byte MembershipTypeId { get; set; }

        public DateTime? BirthDate { get; set; }

    }
}