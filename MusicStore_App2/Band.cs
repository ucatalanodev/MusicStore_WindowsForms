//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicStore_App2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Band
    {
        public long band_id { get; set; }
        public long artist_id { get; set; }
        public short members { get; set; }
        public string form_year { get; set; }
    
        public virtual Artist Artist { get; set; }
    }
}