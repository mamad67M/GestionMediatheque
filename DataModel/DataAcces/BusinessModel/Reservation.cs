using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Business.Layer.DataAccess.BusinessObject
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ClientId { get; set; }
        [ForeignKey(nameof(ClientId))]
        public Client Client { get; set; }
        [Required]
        public int MediaId { get; set; }
        [ForeignKey(nameof(MediaId))]
        public Media Media { get; set; }
        public DateTime DateEmprunt { get; set; }
        public DateTime DateRetour { get; set; }
    }
}
