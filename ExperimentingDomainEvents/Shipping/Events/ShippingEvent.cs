using ExperimentingDomainEvents.DomainEvents;
using System;

namespace ExperimentingDomainEvents.Shipping.Events
{
    // The ShippingEvent enherits from the base DomainEvent
    // And adds logic to keep track of the Ship, Port and Trackingtype (Arrival,Departure)
    public abstract class ShippingEvent : DomainEvent
    {

        #region Private Storage


        #endregion Private Storage

        #region Public Properties

        public Port Port { get; set; }

        public Ship Ship { get; set; }

        public TrackingType TrackingType { get; set; }

        #endregion Public Properties

        #region Internal Interface

        protected ShippingEvent(DateTime occured, Port port, Ship ship, TrackingType trackingType) : base(occured)
        {
            this.Port = port;
            this.Ship = ship;
            this.TrackingType = trackingType;
        }

        #endregion Internal Interface

        #region Public Interface

        public override string ToString()
        {
            return $"TrackingType: {this.TrackingType} => Ship: {this.Ship.Name} || Port: {this.Port.Name}";
        }

        #endregion Public Interface

    }
}
