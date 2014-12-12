using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MVCArchitecturePractice.Core.Entities
{
    public class NotificationObject : INotifyPropertyChanged
    {
        private event PropertyChangedEventHandler propertyChangedEvent;

        protected List<PropertyChangedEventHandler> propertyChangedSubscribers =
            new List<PropertyChangedEventHandler>();

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
