using EventBus.Messages.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
