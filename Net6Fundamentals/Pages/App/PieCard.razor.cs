using Net6Fundamentals.Models;
using Microsoft.AspNetCore.Components;

namespace Net6Fundamentals.Pages.App
{
    public partial class PieCard
    {
        [Parameter]
        public Pie? Pie { get; set; }
    }
}
