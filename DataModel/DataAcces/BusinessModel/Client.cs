using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Business.Layer.DataAccess.BusinessObject
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250)]
        [Required]
        public string Nom { get; set; }

        [MaxLength(250)]
        [Required]
        public string Prenom { get; set; }

        public int? AdresseId { get; set; }
        [ForeignKey(nameof(AdresseId))]
        public Adresse Adresse { get; set; }

        [MaxLength(250)]
        public string Telephone { get; set; }
    }
}
