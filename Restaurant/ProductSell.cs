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
    
    public partial class ProductSell
    {
        public int id { get; set; }
        public int ProductId { get; set; }
        public int SellId { get; set; }
        public int count { get; set; }
    
        public virtual Product1 Product1 { get; set; }
        public virtual Sell1 Sell1 { get; set; }
    }
}
