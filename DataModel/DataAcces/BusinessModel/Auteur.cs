﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Business.Layer.DataAccess.BusinessObject
{
    public class Auteur
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Nom { get; set; }
        [MaxLength(250)]
        public string Prenom { get; set; }
        public int AdresseId { get; set; }
        [ForeignKey(nameof(AdresseId))]
        public Adresse Adresse { get; set; }
        public EStyle Registre { get; set; }
    }

    public enum EStyle
    {
        chanteur,
        ecrivain,
        scenariste,
        acteur,
        musicien
    }
}