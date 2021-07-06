using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Layer.DataAccess.BusinessObject
{
    public class Genre
    {
        public int Id { get; set; }
        [MaxLength(250)]
        public string Nom { get; set; }
    }
}
