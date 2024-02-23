using SelfCheckinWebApp.Enums;
using System.Collections.Generic;
using System.Linq;

namespace SelfCheckinWebApp.DBModels
{
	public partial class GuestCheckInDBContext
	{
        public bool IsFeatureSwitchOn(FeatureSwitchEnum featureSwitchEnum, string siteName, string mode)
        {
            bool result=false;
            if (mode == "Assisted")
            {
                result = SiteFeatureSwitches.Any(sfs => sfs.Site.Name == siteName && sfs.FeatureSwitchId == (int)featureSwitchEnum && (sfs.AppMode == "A" || sfs.AppMode == "") && sfs.Value == "true");
            }
            else if (mode == "")
            {

                result = SiteFeatureSwitches.Any(sfs => sfs.Site.Name == siteName && sfs.FeatureSwitchId == (int)featureSwitchEnum && (sfs.AppMode == "S" || sfs.AppMode == "") && sfs.Value == "true");
            }

            return result;
        }

        public Dictionary<FeatureSwitchEnum, string> GetFeatureSwitchValuesForSite(string siteName)
        {
            return SiteFeatureSwitches.Where(sfs => sfs.Site.Name == siteName).ToList().ToDictionary(x => (FeatureSwitchEnum)x.FeatureSwitchId, x => x.Value);
        }
    }
}