using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Layer.DataAccess.BusinessObject
{
    public class Album : Playable
    {
        public int NombrePiste { get; set; }
        public virtual ICollection<Piste> Pistes { get; set; }
    }

}
