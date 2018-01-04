namespace Assets._Root.Scripts.Strange.Commands
{
    using Assets._Root.Scripts.Core;
    using strange.extensions.command.impl;
    using UnityEngine;

    public class StartGameCommand : Command
    {
        [Inject]
        public Game Game { get; set; }

        public override void Execute()
        {
            Debug.Log("I am alive");
            
            Game.Start();
            
        }
    }
}
