﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Technines_irangos_rezervacij.Models
{
    public class Equipment
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public int EquipmentTypeId { get; set; }
        public EquipmentType EquipmentType { get; set; }

        public List<EquipmentBundle> EquipmentBundles { get; set; }
    }
}