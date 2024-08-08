using UnityEngine;

namespace Singleton
{
    public class SingleThreadGameManager : GenericSingletonSingleThread<SingleThreadGameManager>
    {
        protected override void Initialize()
        {
            Debug.Log("Initializing unsafe threads game manager");
        }

        public override void Validate()
        {
            Debug.Log("Validation unsafe threads game manager");
        }
    }
}