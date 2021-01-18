using System.Collections.Generic;

namespace RadzenClientSide.Models.PersonInformation
{
    public class Filter
    {
        public string Title { get; set; }
        public List<string> DefaultValues { get; set; }
        public string QueryLabel { get; set; }
    }
}