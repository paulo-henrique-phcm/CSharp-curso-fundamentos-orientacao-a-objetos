using Balta.NotificationContext;
using Balta.ContextContent;

namespace Balta.SharedContext{
    public abstract class Base : Notifiable{
        public Base()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

    }
}