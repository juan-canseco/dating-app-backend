using EventBus.Messages.Common;

namespace EventBus.Messages.Events
{
    public class AccountRegistrationEvent : BaseEvent
    {
        private AccountRegistrationEvent() : base(Guid.Empty, default)
        {
            UserId = default!;
        }
        public string UserId { get; private set; }
    }
}
