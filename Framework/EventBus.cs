using System;
using System.Collections.Generic;
using System.Text;

namespace Framework
{
   
    public class EventBus
    {
        public static EventBus Instance = new EventBus();
        private EventBus()
        {
        }
        public void OnReceiveRfidCardID(string cardid)
        {
            if (this.ReceiveRfidCardID != null)
                this.ReceiveRfidCardID(this, new IDEventArgs(cardid));
        }

        public void OnCheckIsNeedSynchronization()
        {
            if (this.CheckIsNeedSynchronization != null)
                this.CheckIsNeedSynchronization(this, new EventArgs());
        }

        
        public event EventHandler<IDEventArgs> ReceiveRfidCardID;

        
        public event EventHandler CheckIsNeedSynchronization;
    }

    public class IDEventArgs:EventArgs
    {
        
        public string CardID
        {
            get;
            set;
        }
        public IDEventArgs(string cardid)
        {
            this.CardID = cardid;
        }
    }
 
}
