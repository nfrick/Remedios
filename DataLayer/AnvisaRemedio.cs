//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class AnvisaRemedio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AnvisaRemedio()
        {
            this.PrincipiosAtivos = new ObservableListSource<PrincipioAtivo>();
        }
    
        public int ID { get; set; }
        public int LaboratorioID { get; set; }
        public int ProdutoID { get; set; }
        public string Apresentacao { get; set; }
        public int ClasseTerapeuticaID { get; set; }
        public int TipoDeProdutoID { get; set; }
        public bool RestricaoHospitalar { get; set; }
        public int TarjaID { get; set; }
    
        public virtual ClasseTerapeutica ClasseTerapeutica { get; set; }
        public virtual Laboratorio Laboratorio { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual Tarja Tarja { get; set; }
        public virtual TipoDeProduto TiposDeProduto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<PrincipioAtivo> PrincipiosAtivos { get; set; }
    }
}
