namespace Assassin_sCreedWikiSked.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Weapon")]
    public partial class Weapon
    {
        public int ID { get; set; }

        [StringLength(300)]
        public string Name { get; set; }

        public string Description { get; set; }

        [StringLength(4000)]
        public string Statement { get; set; }

        [StringLength(4000)]
        public string ImageUri { get; set; }
    }
}
