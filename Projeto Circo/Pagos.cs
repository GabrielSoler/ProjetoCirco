//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projeto_Circo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pagos
    {
        public int IDArtista { get; set; }
        public int IDEspetaculo { get; set; }
        public Nullable<bool> Pago { get; set; }
        public int IDPago { get; set; }
    
        public virtual Artistas Artistas { get; set; }
        public virtual Espetaculos Espetaculos { get; set; }
    }
}
