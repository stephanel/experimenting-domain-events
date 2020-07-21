using ExperimentingDomainEvents.Shipping.Events;

namespace ExperimentingDomainEvents.Shipping
{
    public class Ship
    {
        #region Properties

        public int ShipId { get; set; }
        public string Name { get; set; }
        public Port Location { get; set; }

        #endregion Properties


        #region Public Interface

        public void HandleArrival(ArrivalEvent ev)
        {
            // Here we set the Port to the Port Set by the ArrivalEvent
            Location = ev.Port;
        }

        public void HandleDeparture(DepartureEvent ev)
        {
            // Here we set the Port to the Port Set by the DepartureEvent
            Location = ev.Port;
        }

        #endregion Public Interface
    }
}
