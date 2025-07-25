﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public abstract class NotifierDecorator:INotifier
    {
        protected INotifier _notifier;
        public NotifierDecorator(INotifier notifier)
        {
            _notifier = notifier;
        }
        public virtual void Send(string message)
        {
            _notifier.Send(message);
        }
    }
}
