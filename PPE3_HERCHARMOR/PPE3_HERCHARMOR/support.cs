//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PPE3_HERCHARMOR
{
    using System;
    using System.Collections.Generic;
    
    public partial class support
    {
        public support()
        {
            this.emprunt = new HashSet<emprunt>();
        }
    
        public int idSupport { get; set; }
        public string titreSupport { get; set; }
        public string realisateur { get; set; }
        public string image { get; set; }
        public int idGenre { get; set; }
        public string lienTelechargement { get; set; }
    
        public virtual ICollection<emprunt> emprunt { get; set; }
        public virtual film film { get; set; }
        public virtual genre genre { get; set; }
        public virtual serie serie { get; set; }
    }
}
