using System.Globalization;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace BlazorServer.Components;

public partial class LanguageSelection : ComponentBase
{
    [Inject] private IStringLocalizer<BlazorServer.Locals.Resources> localizer { get; set; } = default!;
    [Inject] private NavigationManager Navigation { get; set; } = default!;

    private CultureInfo Culture
    {
        get { return CultureInfo.CurrentCulture; }
        set
        {
            if (!CultureInfo.CurrentCulture.Equals(value))
            {
                var uri = new Uri(Navigation.Uri)
                    .GetComponents(UriComponents.PathAndQuery, UriFormat.Unescaped);
                var cultureEscaped = Uri.EscapeDataString(value.Name);
                var uriEscaped = Uri.EscapeDataString(uri);

                var fullUri = $"Culture/Set?culture={cultureEscaped}&redirectUri={uriEscaped}";
                Navigation.NavigateTo(fullUri, forceLoad: true);
            }
        }
    }

    protected override void OnInitialized()
    {
        Culture = CultureInfo.CurrentCulture;
        base.OnInitialized();
    }
}