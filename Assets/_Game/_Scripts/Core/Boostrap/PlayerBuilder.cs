using Vald.NoobRoguelike.Patterns;
using Vald.NoobRoguelike.Player;


namespace Vald.NoobRoguelike.Core.Boostrap
{
    public sealed class PlayerBuilder : Builder<PlayerEntity>
    {

        public PlayerBuilder AddController(PlayerController controller){
            product.SetController(controller);
            return this;
        }

        public PlayerBuilder AddMainStatsByDefault() {
            product.SetMainStats(PlayerMainStats.defautValues);
            return this;
        }

        public PlayerBuilder AddPMainStats(PlayerMainStats stats) {
            product.SetMainStats(stats);
            return this;
        }

    }
}
