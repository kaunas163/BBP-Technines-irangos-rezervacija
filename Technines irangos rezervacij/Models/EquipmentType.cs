using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Technines_irangos_rezervacij.Models
{
    public class EquipmentType
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Pavadinimas")]
        public string Name { get; set; }

        [Display(Name = "Aprašymas")]
        public string Description { get; set; }

        public List<EquipmentTypeField> EquipmentTypeFields { get; set; }
    }
}