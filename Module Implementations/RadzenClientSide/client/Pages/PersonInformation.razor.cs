using System;
using System.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;
using IniParser;
using Microsoft.AspNetCore.Components;
using Radzen;
using Radzen.Blazor;
using RadzenClientSide.Models.PersonInformation;

namespace RadzenClientSide.Pages
{
    public partial class PersonInformationComponent
    {
        [Inject]
        private HttpClient Http { get; set; }

        private async void FetchFilters()
        {
            Filters = await Http.GetFromJsonAsync<List<Filter>>("api/Configuration/person-information");
            foreach (var filter in Filters)
            {
                FilterValues[filter.QueryLabel] = "";
            }
        }

        private async void FetchPeople()
        {
            var city = HttpUtility.UrlEncode(FilterValues[":city"]);
            var state = HttpUtility.UrlEncode(FilterValues[":state"]);
            var plz = HttpUtility.UrlEncode(FilterValues[":plz"]);
            PersonData = await Http.GetFromJsonAsync<List<Person>>($"api/Database/person/{(city == "" ? "æ€æ" : city)}/{(state == "" ? "æ€æ" : state)}/{(plz == "" ? "æ€æ" : plz)}");
            grid0.GoToPage(0);
        }

        private async void FetchMeetings()
        {
            MeetingData = await Http.GetFromJsonAsync<List<Meeting>>($"api/Database/meeting/{SelectedPerson.Id}");
            grid1.GoToPage(0);
        }
    }
}
