using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Technines_irangos_rezervacij.Models
{
    public class EquipmentTypeField
    {
        public int Id { get; set; }

        public string Key { get; set; }

        public string Value { get; set; }

        public string ValuePlaceholder { get; set; }

        public string Explanation { get; set; }

        public int EquipmentTypeId { get; set; }
        public EquipmentType EquipmentType { get; set; }
    }
}