using System.Diagnostics;
using System.Runtime.Serialization;

namespace PrimalEditor.Components
{
    [DataContract]
    public class Component : ViewModelBase
    {
        [DataMember]
        public GameEntity Owner { get; set; }

        public Component(GameEntity owner)
        {
            Debug.Assert(owner != null);
            Owner = owner;
        }
    }
}
