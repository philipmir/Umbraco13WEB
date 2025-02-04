using System.Collections.Generic;

namespace UM13WEBSITE.Models.ContentModels
{
    public interface ITaggingProperties
    {
        IEnumerable<PageTag> PageTags { get; }
    }
}
