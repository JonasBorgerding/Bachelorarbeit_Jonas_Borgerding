using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using RadzenClientSide.Client.Pages;

namespace RadzenClientSide.Pages
{
    public partial class PersonInformationComponent : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }

        public void Reload()
        {
            InvokeAsync(StateHasChanged);
        }

        public void OnPropertyChanged(PropertyChangedEventArgs args)
        {
        }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected TooltipService TooltipService { get; set; }

        [Inject]
        protected ContextMenuService ContextMenuService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        protected RadzenGrid<RadzenClientSide.Models.PersonInformation.Person> grid0;
        protected RadzenGrid<RadzenClientSide.Models.PersonInformation.Meeting> grid1;

        List<RadzenClientSide.Models.PersonInformation.Person> _PersonData;
        protected List<RadzenClientSide.Models.PersonInformation.Person> PersonData
        {
            get
            {
                return _PersonData;
            }
            set
            {
                if (!object.Equals(_PersonData, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "PersonData", NewValue = value, OldValue = _PersonData };
                    _PersonData = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        List<RadzenClientSide.Models.PersonInformation.Meeting> _MeetingData;
        protected List<RadzenClientSide.Models.PersonInformation.Meeting> MeetingData
        {
            get
            {
                return _MeetingData;
            }
            set
            {
                if (!object.Equals(_MeetingData, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "MeetingData", NewValue = value, OldValue = _MeetingData };
                    _MeetingData = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        List<RadzenClientSide.Models.PersonInformation.Filter> _Filters;
        protected List<RadzenClientSide.Models.PersonInformation.Filter> Filters
        {
            get
            {
                return _Filters;
            }
            set
            {
                if (!object.Equals(_Filters, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "Filters", NewValue = value, OldValue = _Filters };
                    _Filters = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        Dictionary<string, string> _FilterValues;
        protected Dictionary<string, string> FilterValues
        {
            get
            {
                return _FilterValues;
            }
            set
            {
                if (!object.Equals(_FilterValues, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "FilterValues", NewValue = value, OldValue = _FilterValues };
                    _FilterValues = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        RadzenClientSide.Models.PersonInformation.Person _SelectedPerson;
        protected RadzenClientSide.Models.PersonInformation.Person SelectedPerson
        {
            get
            {
                return _SelectedPerson;
            }
            set
            {
                if (!object.Equals(_SelectedPerson, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "SelectedPerson", NewValue = value, OldValue = _SelectedPerson };
                    _SelectedPerson = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Load();
        }
        protected async System.Threading.Tasks.Task Load()
        {
            PersonData = new List<RadzenClientSide.Models.PersonInformation.Person>();

            MeetingData = new List<RadzenClientSide.Models.PersonInformation.Meeting>();

            Filters = new List<RadzenClientSide.Models.PersonInformation.Filter>();

            FilterValues = new Dictionary<string, string>();

            FetchFilters();
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(RadzenClientSide.Models.PersonInformation.Person args)
        {
            SelectedPerson = args;

            FetchMeetings();
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            FetchPeople();
        }
    }
}
