using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MobileStore.Models.Metadata
{
    public class ManufacturerMetadata
    {
        [Required(ErrorMessage="Наименование обязательно")]
        [Display(Name = "Наименование")]
        [StringLength(50)]
        public string Name { get; set; }

        [Display(Name="Описание")]
        public string Description { get; set; }
    }
}