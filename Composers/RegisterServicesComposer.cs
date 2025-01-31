using UM13WEBSITE.Services;

using Umbraco.Cms.Core.Composing;

namespace UM13WEBSITE.Composers;

public class RegisterServicesComposer : IComposer
{
    public void Compose(IUmbracoBuilder builder)
    {
        builder.Services.AddTransient<ISearchService, SearchService>();
    }
}