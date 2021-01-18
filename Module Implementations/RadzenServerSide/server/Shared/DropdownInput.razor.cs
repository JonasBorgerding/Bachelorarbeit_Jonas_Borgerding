using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Radzen;
using Radzen.Blazor;

namespace RadzenServerSide.Shared
{
    public partial class DropdownInputComponent: ComponentBase
    {
        [Required]
        [Parameter]
        public string Text { get; set; }
    
        [Parameter]
        public List<string> DropdownValues { get; set; }
    
        [Parameter]
        public EventCallback<string> ValueChanged { get; set; }

        protected bool MouseEnter { get; set; }

        private string _dropdownValue;
        protected string DropdownValue
        {
            get => _dropdownValue;
            set
            {
                if (MouseEnter || value == "") return;
                ValueChanged.InvokeAsync(value);
                Value = value;
                _dropdownValue = "";
            }
        }

        private string _value;
        protected string Value
        {
            get => _value;
            set
            {
                ValueChanged.InvokeAsync(value);
                _value = value;
            }
        }
    }
}
