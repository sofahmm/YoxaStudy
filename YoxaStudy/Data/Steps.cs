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
    
    public partial class Steps
    {
        public int ID { get; set; }
        public Nullable<int> IdTask { get; set; }
        public byte[] Image1 { get; set; }
        public byte[] Image2 { get; set; }
        public byte[] Image3 { get; set; }
        public byte[] Image4 { get; set; }
        public byte[] Image5 { get; set; }
        public byte[] Image6 { get; set; }
        public byte[] Image7 { get; set; }
        public byte[] Image8 { get; set; }
        public byte[] Image9 { get; set; }
        public byte[] Image10 { get; set; }
    
        public virtual Task Task { get; set; }
    }
}
