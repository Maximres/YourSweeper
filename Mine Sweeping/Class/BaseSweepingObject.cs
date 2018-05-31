using System;
using System.Collections.Generic;
using System.Text;

namespace Mine_Sweeping
{
    public abstract class BaseSweepingObject : IOberverable
    {
        private List<IObserver> container = null;

        public BaseSweepingObject()
        {
            this.container = new List<IObserver>();
        }

        public void Register(IObserver ober)
        {
            this.container.Add(ober);
        }

        public void UnRegister(IObserver ober)
        {
            this.container.Remove(ober);
        }

        protected void Notify(EventArgs e)
        {
            foreach (IObserver observer in this.container)
            {
                observer.Update(e);
            }
        }

    }
}
