//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restaurant
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sell1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sell1()
        {
            this.ProductSell = new HashSet<ProductSell>();
        }
    
        public int id { get; set; }
        public System.DateTime date { get; set; }
        public int UserId { get; set; }
        public int SellId { get; set; }
    
        public virtual Discount1 Discount1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductSell> ProductSell { get; set; }
        public virtual User1 User1 { get; set; }
    }
}
