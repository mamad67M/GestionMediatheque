using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Layer.DataAccess.BusinessObject
{
    public class Livre : Media
    {
        [MaxLength(50)]
        public string ISBN { get; set; }
        public int NombreDePage { get; set; }
    }
}
