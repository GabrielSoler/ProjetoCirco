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
    
    public partial class Espetaculos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Espetaculos()
        {
            this.Figurino = new HashSet<Figurino>();
            this.LocalEspetaculo = new HashSet<LocalEspetaculo>();
            this.Pagos = new HashSet<Pagos>();
        }
    
        public int IDEspetaculo { get; set; }
        public string NMEspetaculo { get; set; }
        public string DTEspetaculo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Figurino> Figurino { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocalEspetaculo> LocalEspetaculo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pagos> Pagos { get; set; }

		public override string ToString()
		{
			return NMEspetaculo + "";
		}
	}
}
