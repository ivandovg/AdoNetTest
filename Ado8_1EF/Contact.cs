//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ado8_1EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contact
    {
        public int Id { get; set; }
        public string TypeInfo { get; set; }
        public string Value { get; set; }
    
        public virtual Person Person { get; set; }
    }
}