using Vald.NoobRoguelike.Interfaces;


namespace Vald.NoobRoguelike.Patterns
{
    public abstract class Builder<T> : IBuilder<T>
    {
        private T _product;

        public Builder() {
            _product = default;
        }

        public T Build() {
            return _product;
        }

        protected T product => _product;
    }
}
