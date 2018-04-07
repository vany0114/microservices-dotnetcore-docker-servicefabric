﻿using System;
using Duber.Infrastructure.EventBus.Events;
using Duber.Trip.API.Application.Model;

namespace Duber.Trip.API.Application.IntegrationEvents
{
    public class TripCancelledIntegrationEvent : IntegrationEvent
    {
        public TripCancelledIntegrationEvent(Guid tripId, TimeSpan duration, PaymentMethod paymentMethod)
        {
            Duration = duration;
            PaymentMethod = paymentMethod;
            TripId = tripId;
        }

        public Guid TripId { get; }

        public TimeSpan Duration { get; }

        public PaymentMethod PaymentMethod { get; }
    }
}
