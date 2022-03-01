using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;
using TWBlazor.Enums;

namespace TWBlazor
{
    public partial class TWDropDown
    {
        [Parameter]
        public string? Name { get; set; }

        [Parameter]
        public string? Text { get; set; }

        [Parameter]
        public List<(string ItemText, string ItemAction)>? Items { get; set; }

        private string DropDownList { get => $"{Name}ddl"; }

        [Parameter]        
        public TWDropDownPosition? Position { get; set; }

        [Parameter]
        public bool OpenOnHover { get; set; }

        [Parameter]
        public bool ForceOpen { get; set; }

        /// <summary>
        /// CSS class for additional configurations
        /// </summary>
        private string _cssClass = string.Empty;

        public TWDropDown()
        {
            if (Position != null)
            {
                _cssClass = $"dropdown-{Position}";
            }
        }
        protected override void OnParametersSet()
        {
            if (Position != null)
            {
                _cssClass += $" dropdown-{Position.Value.ToString().ToLower()} ";
            }
            if (ForceOpen)
            {
                _cssClass += " dropdown-open ";
                OpenOnHover = false; //open on over doesn´t work with forceopen
            }
            if (OpenOnHover)
            {
                _cssClass += " dropdown-hover ";
            }
            
        }

    }
}
