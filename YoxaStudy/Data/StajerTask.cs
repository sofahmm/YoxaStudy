//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YoxaStudy.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class StajerTask
    {
        public int ID { get; set; }
        public Nullable<int> IdStajer { get; set; }
        public Nullable<int> IdTask { get; set; }
        public Nullable<bool> IsDone { get; set; }
    
        public virtual Stajer Stajer { get; set; }
        public virtual Task Task { get; set; }
    }
}