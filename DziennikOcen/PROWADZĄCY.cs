//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DziennikOcen
{
    using System;
    using System.Collections.Generic;
    
    public partial class PROWADZĄCY
    {
        public PROWADZĄCY()
        {
            this.projekty = new HashSet<projekty>();
            this.przedmioty = new HashSet<przedmioty>();
        }
    
        public int id_PROWADZĄCEGO { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string telefon { get; set; }
        public string adres { get; set; }
        public string e_mail { get; set; }
        public string haslo { get; set; }
        public string stanowisko { get; set; }
    
        public virtual ICollection<projekty> projekty { get; set; }
        public virtual ICollection<przedmioty> przedmioty { get; set; }
    }
}
