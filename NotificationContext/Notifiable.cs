namespace Balta.NotificationContext
{
    public abstract class Notifiable
    {

        public Notifiable()
        {
            Notifications = new List<Notification>();
        }
        public List<Notification> Notifications { get; set; }
        public void AddNotifications(IEnumerable<Notification> notification)
        {
            this.Notifications.AddRange(notification);
        }

        public void AddNotification(Notification notification)
        {
            this.Notifications.Add(notification);
        }

        public bool IsInvalid => Notifications.Any();
        
    }
}