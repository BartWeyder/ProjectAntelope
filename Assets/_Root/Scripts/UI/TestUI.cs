using Assets._Root.Scripts.Strange.Signals;
using strange.extensions.mediation.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets._Root.Scripts.UI
{
    class TestUI : View 
    {
        [Inject]
        private TestSignal TestSignal { set; get; }
        private void Start()
        {
            base.Start();
            TestSignal.AddListener(OnTestSignal);
        }
        private void OnTestSignal(string msg)
        {
            Debug.Log(msg);
        }
    }
}
