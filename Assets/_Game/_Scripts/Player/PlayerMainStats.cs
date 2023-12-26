namespace Vald.NoobRoguelike.Player
{
    public struct PlayerMainStats
    {
        public short health;
        public float runSpeed;
        public int money;

        public static PlayerMainStats defautValues => new PlayerMainStats()
        {
            health = 50,
            money = 0,
            runSpeed = 100
        };
    }
}
