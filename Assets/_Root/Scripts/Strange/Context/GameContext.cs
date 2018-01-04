using Assets._Root.Scripts.Core;
using Assets._Root.Scripts.Strange.Commands;
using strange.extensions.context.api;
using strange.extensions.context.impl;
using strange.extensions.signal.impl;
using UnityEngine;

namespace Assets._Root.Scripts.Strange.Context
{
    public class GameContext : MVCSContext
    {
        private readonly GameRoot root;

        public GameContext(GameRoot view) : base(view, ContextStartupFlags.MANUAL_MAPPING)
        {
            root = view; //
        }

        public override void Launch()
        {
            base.Launch();
            Debug.Log("I'm still trying");
            //This part works but why command not?
            //var game = injectionBinder.GetInstance<Game>();
            //game.Start();
            var startSignal = injectionBinder.GetInstance<GameLoaded>();
            startSignal.Dispatch();
        }

        protected override void mapBindings()
        {
            string[] namespaces = { "" };
            implicitBinder.ScanForAnnotatedClasses(namespaces);

            commandBinder.Bind<GameLoaded>().To<StartGameCommand>();
        }
    }

    [Implements]
    public class GameLoaded : Signal { }

}
