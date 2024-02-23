namespace SelfCheckinWebApp.DBModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Site")]
    public partial class Site
    {
        public Site()
        {
            SiteFeatureSwitches = new HashSet<SiteFeatureSwitch>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<SiteFeatureSwitch> SiteFeatureSwitches { get; set; }
    }
}
