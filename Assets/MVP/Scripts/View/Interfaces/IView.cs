using System;

namespace MVP.Scripts.View
{
    public interface IView<in TNotifyType> where TNotifyType : Enum
    {
        public void UpdateView(TNotifyType type, params object[] args);
    }
}