using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Layer.DataAccess.BusinessObject
{
    public class Adresse
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(5)]
        public string CodePostal { get; set; }
        [MaxLength(250)]
        public string Ville { get; set; }
        [MaxLength(6)]
        public string Numero { get; set; }
        [MaxLength(250)]
        public string Rue { get; set; }
    }
}
