using Vald.NoobRoguelike.Player.Controls;


namespace Vald.NoobRoguelike.Core
{
    public class GameContext
    {
        private PlayerControlSchema _controlSchema;
        private Player.PlayerEntity _player;


        public void SetControlSchema(PlayerControlSchema schema)
        {
            if (schema != null)
                throw new System.ArgumentException("Control schema is already defined");

            _controlSchema = schema;
        }

        public void SetPlayer(Player.PlayerEntity player) {
            if (player != null)
                throw new System.AccessViolationException("Player is already defined");

            _player = player;
        }

        public PlayerControlSchema GetControlSchema() {
            return _controlSchema;
        }

        public Player.PlayerEntity GetPlayer()
        {
            return _player;
        }


    }
}
