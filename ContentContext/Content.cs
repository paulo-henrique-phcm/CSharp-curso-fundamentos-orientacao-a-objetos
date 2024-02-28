using Balta.SharedContext;

namespace Balta.ContextContent
{
    public abstract class Content : Base
    {
        public Content(string title, string url)
        {
            // this.Id = Guid.NewGuid();
            this.Title = title;
            this.Url = url;
        }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}