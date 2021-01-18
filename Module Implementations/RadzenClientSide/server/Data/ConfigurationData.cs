using System.Collections.Generic;
using RadzenClientSide.Models.PersonInformation;

namespace RadzenClientSide.Data
{
    public class ConfigurationData
    {
        internal string PersonQueryString { get; set; }
        internal string MeetingQueryString { get; set; }
        internal bool IsRead { get; set; }
        internal List<Filter> Filters { get; set; }

        private ConfigurationData()
        {
            IsRead = false;
            Filters = new List<Filter>();
        }

        public static readonly ConfigurationData Instance = new ConfigurationData();
    }
}