using System.Numerics;


namespace Vald.NoobRoguelike.Player.Controls
{
    public struct PlayerControlActions
    {
        public System.Action actionJump;
        public System.Action actionHit; // удар
        public Vector2 movementAxis;
        public bool croaching;
    }
}