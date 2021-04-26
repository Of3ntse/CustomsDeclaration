using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace CustomsDeclaration.Models
{
    public partial class MyTable
    {
        [Key]
        public int? Id { get; set; }
        public string Name { get; set; }
    }
}
