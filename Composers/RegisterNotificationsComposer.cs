using UM13WEBSITE.Notifications;

using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.Notifications;

namespace UM13WEBSITE.Composers;

public class RegisterNotificationsComposer : IComposer
{
    public void Compose(IUmbracoBuilder builder)
    {
        builder.AddNotificationHandler<ContentSavingNotification, ContentSavingNotificationHandler>();
    }
}