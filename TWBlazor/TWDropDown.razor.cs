using Microsoft.AspNetCore.Components;

namespace TWBlazor
{
    public partial class TWDropDown
    {
        [Parameter]
        public string Name { get; set; }

        [Parameter]
        public string Text { get; set; }

        [Parameter]
        public List<(string ItemText, string ItemAction)> Items { get; set; }

        public string DropDownList { get => $"{Name}ddl"; }
    }
}
