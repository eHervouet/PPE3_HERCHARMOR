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
    
    public partial class genre
    {
        public genre()
        {
            this.support = new HashSet<support>();
        }
    
        public int idGenre { get; set; }
        public string libelleGenre { get; set; }
        public string images { get; set; }
    
        public virtual ICollection<support> support { get; set; }
    }
}
