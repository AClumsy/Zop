﻿using System;

namespace Zop.Domain.Events
{
    public abstract class EventData : IEventData
    {
        public DateTime EventTime { get; } = DateTime.Now;

        public abstract string EventName { get; }
    }
}
