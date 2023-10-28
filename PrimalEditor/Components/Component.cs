using System.Diagnostics;

namespace PrimalEditor.Components
{
    public class Component : ViewModelBase
    {
        public GameEntity Owner { get; set; }

        public Component(GameEntity owner)
        {
            Debug.Assert(owner != null);
            Owner = owner;
        }
    }
}
