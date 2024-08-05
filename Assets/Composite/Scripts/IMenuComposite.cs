namespace Composite
{
    public interface IMenuComposite
    {
        public void ShowSubMenu<T>();
        public void Add(IMenu menu);
        public void Remove(IMenu menu);
    }
}