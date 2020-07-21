using System;

namespace ExperimentingDomainEvents.DomainEvents
{
    // Domain event is the base event class
    // it simply registers when the according 
    // event occured and is recorded
    public abstract class DomainEvent
    {
        #region Private Storage

        private readonly DateTime _recorded, _occured;

        #endregion Private Storage

        #region Internal Interface

        protected DomainEvent(DateTime occured)
        {
            this._occured = occured;
            this._recorded = DateTime.Now;
        }

        abstract internal void Process();

        #endregion Internal Interface
    }
}
