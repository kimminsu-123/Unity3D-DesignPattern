using UnityEngine;

namespace Singleton
{
    public class MultiThreadGameManager : GenericSingletonMultiThread<MultiThreadGameManager>
    {
        protected override void Initialize()
        {
            Debug.Log("Initializing safe threads game manager");
        }

        public override void Validate()
        {
            Debug.Log("Validation safe threads game manager");
        }
    }
}