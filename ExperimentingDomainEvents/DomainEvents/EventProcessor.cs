using System.Collections.Generic;

namespace ExperimentingDomainEvents.DomainEvents
{
    // The Event Processor Processes the Events 
    // as received from the TrackingService
    public class EventProcessor<T> where T : DomainEvent
    {
        #region Private Storage

        private readonly IList<T> EventLogger = new List<T>();

        #endregion Private Storage


        #region Public Interface

        public void ProcessEvent(T e)
        {
            e.Process();
            EventLogger.Add(e);
        }

        public int CountEventLogEntries()
        {
            return EventLogger.Count;
        }

        public List<T> GetEvents()
        {
            return EventLogger as List<T>;
        }

        #endregion Public Interface
    }
}
