//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AuthenticateIMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Shelves_Table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shelves_Table()
        {
            this.Shelf_Compartment = new HashSet<Shelf_Compartment>();
        }
    
        public int id { get; set; }
        public string shelf_ID { get; set; }
        public string shelf_allocation { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shelf_Compartment> Shelf_Compartment { get; set; }
    }
}