//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MegaService
{
    using System;
    using System.Collections.Generic;
    
    public partial class MG_OTK
    {
        public int ID { get; set; }
        public int MG_Client_id { get; set; }
        public string Description { get; set; }
        public int UserID { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<int> Culprit { get; set; }
    
        public virtual MG_Client MG_Client { get; set; }
        public virtual Scrap_Culprit Scrap_Culprit { get; set; }
    }
}
