using Balta.SharedContext;

namespace Balta.ContextContent
{
    public class Module : Base
    {
        public Module()
        {
            this.Lectures = new List<Lecture>();
        }
        public int Order { get; set; }
        public string Title { get; set; }
        public IList<Lecture> Lectures { get; set; }

    }
}