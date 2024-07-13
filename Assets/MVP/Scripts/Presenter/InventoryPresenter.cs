using MVP.Scripts.View;

namespace MVP.Scripts.Presenter
{
    public class InventoryPresenter : IPresenter<InventoryNotifyType>
    {
        private IView<InventoryNotifyType> _view;

        public InventoryPresenter(IView<InventoryNotifyType> view)
        {
            _view = view;
        }

        public void HandleRequest(InventoryNotifyType type, params object[] args)
        {
            
        }
    }
}