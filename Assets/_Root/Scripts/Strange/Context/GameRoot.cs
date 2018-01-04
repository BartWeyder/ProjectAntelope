using JetBrains.Annotations;
using strange.extensions.context.impl;


namespace Assets._Root.Scripts.Strange.Context
{
    public class GameRoot : ContextView
    {
        [UsedImplicitly]
        public void Awake()
        {
            context = new GameContext(this);
            context.Start();
        }
    }
}
