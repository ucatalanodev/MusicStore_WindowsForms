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
    
    public partial class Song
    {
        public long song_id { get; set; }
        public long album_id { get; set; }
        public string song_name { get; set; }
        public string song_duration { get; set; }
    
        public virtual Album Album { get; set; }
    }
}