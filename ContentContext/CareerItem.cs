
using Balta.NotificationContext;
using Balta.SharedContext;

namespace Balta.ContextContent
{
    public class CareerItem : Base
    {
        public CareerItem(int order, string title, string description, Course course)
        {
            if (course == null)
                // throw new System.Exception("O curso não pode ser null");
                this.AddNotification(new Notification("Course", "Curso inválido"));
            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }
        public int Order;
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
}