using System;
using MVP.Scripts.View;

namespace MVP.Scripts.Presenter
{
    public interface IPresenter<TNotifyType> where TNotifyType : Enum
    {
        public void HandleRequest(TNotifyType type, params object[] args);
    }
}