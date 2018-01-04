using Assets._Root.Scripts.Strange.Signals;
using UnityEngine;

namespace Assets._Root.Scripts.Core
{
    [Implements]
    public class Game
    {
        [Inject]
        public TestSignal TestSignal { set; get; }
        public void Start()
        {
            Debug.Log("Game started, so I dispatch TestSignal:");
            TestSignal.Dispatch("TestSignalDispatched");
        }
    }
}
