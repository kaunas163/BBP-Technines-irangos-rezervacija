using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Technines_irangos_rezervacij.Models
{
    public class Notification
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Tema")]
        public string Topic { get; set; }

        [Display(Name = "Žinutė")]
        public string Text { get; set; }

        [Display(Name = "Archyvuota?")]
        public bool IsArchived { get; set; }

        [Display(Name = "Sukūrimo data")]
        public DateTime DateCreated { get; set; }

        [Display(Name = "Perskaityta")]
        public DateTime? DateRead { get; set; }
    }
}