using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Business.Layer.DataAccess.BusinessObject
{
    public class Piste
    {
        public int Id { get; set; }
        [Required]
        public int AlbumId { get; set; }
        [ForeignKey(nameof(AlbumId))]
        public Album Album { get; set; }
        public int Numero { get; set; }
        public TimeSpan Duree { get; set; }
    }
}
