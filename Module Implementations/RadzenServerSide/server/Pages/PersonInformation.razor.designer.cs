using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;

namespace RadzenServerSide.Pages
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
        protected RadzenGrid<RadzenServerSide.Pages.Person> grid0;
        protected RadzenGrid<RadzenServerSide.Pages.Meeting> grid1;

        List<RadzenServerSide.Pages.Person> _PersonData;
        protected List<RadzenServerSide.Pages.Person> PersonData
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

        List<RadzenServerSide.Pages.Meeting> _MeetingData;
        protected List<RadzenServerSide.Pages.Meeting> MeetingData
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

        List<RadzenServerSide.Pages.Filter> _Filters;
        protected List<RadzenServerSide.Pages.Filter> Filters
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

        string _PersonQueryString;
        protected string PersonQueryString
        {
            get
            {
                return _PersonQueryString;
            }
            set
            {
                if (!object.Equals(_PersonQueryString, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "PersonQueryString", NewValue = value, OldValue = _PersonQueryString };
                    _PersonQueryString = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        string _MeetingQueryString;
        protected string MeetingQueryString
        {
            get
            {
                return _MeetingQueryString;
            }
            set
            {
                if (!object.Equals(_MeetingQueryString, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "MeetingQueryString", NewValue = value, OldValue = _MeetingQueryString };
                    _MeetingQueryString = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        int _SelectedPerson;
        protected int SelectedPerson
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
            PersonData = new List<Person>();

            MeetingData = new List<Meeting>();

            FilterValues = new Dictionary<string, string>();

            Filters = new List<Filter>();

            PersonQueryString = "";

            MeetingQueryString = "";

            ReadConfigFile();

            SelectedPerson = 0;
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(RadzenServerSide.Pages.Person args)
        {
            SelectedPerson = args.Id;

            FetchMeetings();
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            FetchPeople();
        }
    }
}
