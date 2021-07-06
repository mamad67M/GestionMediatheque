using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Layer.DataAccess.BusinessObject
{
    public abstract class Playable : Media
    { 
        public TimeSpan Duree { get; set; }
    }
}
