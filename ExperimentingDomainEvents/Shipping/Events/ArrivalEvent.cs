using System;

namespace ExperimentingDomainEvents.Shipping.Events
{
    // The arrival Event simply captures the data and has a process method that simply
    // forwards the event to an appropriate domain object (ship in this case)
    public class ArrivalEvent : ShippingEvent
    {

        #region Internal Interface

        public ArrivalEvent(DateTime arrivalTime, Port port, Ship ship, TrackingType trackingType)
            : base(arrivalTime, port, ship, trackingType)
        {
        }

        internal override void Process()
        {
            Ship.HandleArrival(this);
        }

        #endregion Internal Interface
    }
}
