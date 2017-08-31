﻿using Jambo.Domain.ServiceBus;
using System;

namespace Jambo.Domain.Aggregates.Posts.Events
{
    public class PostEnabledDomainEvent : DomainEvent
    {
        public PostEnabledDomainEvent()
        {

        }

        public PostEnabledDomainEvent(AggregateRoot aggregateRoot)
            : base(aggregateRoot)
        {

        }
    }
}
