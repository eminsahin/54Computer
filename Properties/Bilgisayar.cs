//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _54Computer.Properties
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bilgisayar
    {
        public int BilgisayarID { get; set; }
    
        public virtual Laptop Laptop { get; set; }
        public virtual PC PC { get; set; }
        public virtual Urun Urun { get; set; }
    }
}