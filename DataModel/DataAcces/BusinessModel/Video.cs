using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Layer.DataAccess.BusinessObject
{
    public class Video : Playable
    {
        public Ehd Resolution { get; set; }
    }

    public enum Ehd
    {
        HD,
        FHD,
        QuadHD,
        HuitKplus
    }
}
