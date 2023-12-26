using Vald.NoobRoguelike.Patterns;
using Vald.NoobRoguelike.Player;
using Vald.NoobRoguelike.Player.Controls;


namespace Vald.NoobRoguelike.Core.Boostrap
{
    public class GameContextBuilder : Builder<GameContext>
    {

        public GameContextBuilder AddPlayerControlSchema(PlayerControlSchema schema)
        {
            product.SetControlSchema(schema);
            return this;
        }
    }
}
