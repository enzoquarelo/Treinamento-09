//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Desktop2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Notificaco
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Notificaco()
        {
            this.NotificacoesUsuarios = new HashSet<NotificacoesUsuario>();
        }
    
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public System.DateTime DataHoraCadastro { get; set; }
        public Nullable<System.DateTime> DataHoraEnvio { get; set; }
        public string Importancia { get; set; }
        public Nullable<int> SelecaoId { get; set; }
    
        public virtual Seleco Seleco { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotificacoesUsuario> NotificacoesUsuarios { get; set; }
    }
}
