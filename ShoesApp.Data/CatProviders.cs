//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShoesApp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class CatProviders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CatProviders()
        {
            this.CatCatalogs = new HashSet<CatCatalogs>();
            this.Products = new HashSet<Products>();
        }
    
        public int IdProvider { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<bool> IsEnabled { get; set; }
        public Nullable<System.DateTime> DateUpdate { get; set; }
        public string Url { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CatCatalogs> CatCatalogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Products> Products { get; set; }
    }
}
