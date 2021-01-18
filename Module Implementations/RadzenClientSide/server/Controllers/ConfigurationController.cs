using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IniParser;
using Microsoft.AspNetCore.Mvc;
using RadzenClientSide.Data;
using RadzenClientSide.Models.PersonInformation;

namespace RadzenClientSide.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConfigurationController: ControllerBase
    {
        private readonly ConfigurationData _configurationData = ConfigurationData.Instance;
        
        private void ReadConfigFile()
        {
            if (_configurationData.IsRead)
                return;
            var configFile = new FileIniDataParser().ReadFile("config.ini", Encoding.UTF8);
            foreach (var section in configFile.Sections)
            {
                if (section.SectionName == "SQLStrings")
                {
                    _configurationData.PersonQueryString = section.Keys["FetchPersons"];
                    _configurationData.MeetingQueryString = section.Keys["FetchMeetings"];
                }
                else if (section.SectionName.StartsWith("Filter"))
                {
                    _configurationData.Filters.Add(new Filter
                    {
                        Title = section.Keys["Title"],
                        DefaultValues = section.Keys["DefaultValues"].Split(",").ToList(),
                        QueryLabel = section.Keys["QueryStatementLabel"]
                    });
                }
            }

            _configurationData.IsRead = true;
        }

        [HttpGet("person-information")]
        public List<Filter> GetFilters()
        {
            ReadConfigFile();
            return _configurationData.Filters;
        }
    }
}