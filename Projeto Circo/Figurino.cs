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
    
    public partial class Figurino
    {
        public int IDPec { get; set; }
        public int IDEspetaculo { get; set; }
        public int IDFigurino { get; set; }
    
        public virtual Espetaculos Espetaculos { get; set; }
        public virtual Peças Peças { get; set; }
    }
}
