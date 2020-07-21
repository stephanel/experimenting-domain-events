using ExperimentingDomainEvents.DomainEvents;
using ExperimentingDomainEvents.Shipping;
using ExperimentingDomainEvents.Shipping.Events;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExperimentingDomainEvents.Services
{
    public class ShipTrackingService
    {
        #region Event Declaration

        public delegate void ShipTrackedEventHandler(object sender, ShipTrackedEventArgs e);
        public event ShipTrackedEventHandler ShipTracked;

        #endregion Event Declaration

        #region Private Storage

        public TrackingType TrackingType = TrackingType.None;
        public Guid TrackingServiceId;
        public DateTime Recorded;
        public List<Port> Ports;
        public List<Ship> Ships;
        public Ship TrackedShip;
        public Port CurrentPort;
        public Port SetPort;

        #endregion Private Storage

        #region C'tor
        public ShipTrackingService()
        {
            // initialize ports
            Ports = new List<Port>()
            {
                new Port() { PortId = 0, Name = "AT Sea" },
                new Port() { PortId = 1, Name = "Port of Shangai" },
                new Port() { PortId = 2, Name = "Port of Antwerp" },
                new Port() { PortId = 3, Name = "Port of Singapore" },
                new Port() { PortId = 4, Name = "Port of Dover" },
                new Port() { PortId = 5, Name = "Port of Dunkerque" },
                new Port() { PortId = 6, Name = "Port of Papeete" },
                new Port() { PortId = 7, Name = "Port of Helsinki" },
            };

            // initialize ships
            Ships = Enumerable.Range(1, 8)
                .Select(i => new Ship() { ShipId = i, Name = $"Ship_{i}", Location = Ports[0] })
                .ToList();
        }
        #endregion C'tor

        #region Public Interface

        public void RecordTracking(EventProcessor<ShippingEvent> eProc)
        {
            // Create event depending on TrackingType
            Port OldLocation = TrackedShip.Location;
            ShippingEvent ev;
            if (TrackingType == TrackingType.Arrival)
            {
                ev = new ArrivalEvent(DateTime.Now, SetPort, TrackedShip, TrackingType);
            }
            else
            {
                ev = new DepartureEvent(DateTime.Now, SetPort, TrackedShip, TrackingType);
            }

            // send the event to the event handler (ship) which will update it's status on the provided event data
            eProc.ProcessEvent(ev);

            // notify the UI Tracking List so it can update itself
            ShipTrackedEventArgs args = new ShipTrackedEventArgs()
            {
                TrackingServiceId = TrackingServiceId,
                Recorded = Recorded,
                TrackingType = TrackingType,
                TrackedShip = TrackedShip,
                OldLocation = OldLocation,
                NewLocation = SetPort,

            };
            // notify subscribers ...
            OnShipTracked(args);
        }

        #endregion Public Interface

        #region Protected Interface

        // Notify the (UI) Subscribders that a Ship has been tracked
        protected virtual void OnShipTracked(ShipTrackedEventArgs args)
        {

            if (ShipTracked != null)
                ShipTracked(this, args);

        }

        #endregion Protected Interface
    }
}
