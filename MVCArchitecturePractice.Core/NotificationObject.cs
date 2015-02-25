using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.ComponentModel;

namespace MVCArchitecturePractice.Core
{
    public class NotificationObject : INotifyPropertyChanged
    {
        private event PropertyChangedEventHandler propertyChangedEvent;
        protected List<PropertyChangedEventHandler> propertyChangedSubscribers;

        public event PropertyChangedEventHandler PropertyChanged
        {
            add
            {
                if (!propertyChangedSubscribers.Contains(value))
                {
                    propertyChangedEvent += value;
                    propertyChangedSubscribers.Add(value);
                }
            }
            remove
            {
                propertyChangedEvent -= value;
                propertyChangedSubscribers.Remove(value);
            }
        }

        public NotificationObject()
        {
            propertyChangedSubscribers = new List<PropertyChangedEventHandler>();
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (propertyChangedEvent != null)
            {
                propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        protected virtual void OnPropertyChanged<T>(Expression<Func<T>> propertyExpression)
        {
            //string propertyName = PropertySupport.ExtractPropertyName(propertyExpression);
            //OnPropertyChanged(propertyName);
        }
    }
}
