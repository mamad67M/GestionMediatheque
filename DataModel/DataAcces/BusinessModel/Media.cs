using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Business.Layer.DataAccess.BusinessObject
{
    public abstract class Media
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        [Required]
        public string CodeBarre { get; set; }
        [MaxLength(250)]
        [Required]
        public string Titre { get; set; }
        public virtual ICollection<Auteur> Collaborateurs { get; set; }
        public DateTime DateDeParution { get; set; }
        public int? GenreId { get; set; }
        [ForeignKey(nameof(GenreId))]
        public Genre Genre { get; set; }
    }    
}
