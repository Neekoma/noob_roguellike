using UnityEngine;


namespace Vald.NoobRoguelike.Player
{
    public class PlayerEntity
    {
        private PlayerController _controller;
        private PlayerMainStats _mainStats;


        public void SetController(PlayerController controller)
        {
            if (controller != null)
                throw new System.ArgumentException("Player controller is already defined");

            _controller = controller;
        }

        public void SetMainStats(PlayerMainStats mainStats)
        {
            _mainStats = mainStats;
        }

        public PlayerController controller => _controller;
        public PlayerMainStats mainStats => _mainStats;

    }
}