using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Decorator : Component
    {
        protected Component? component;

        public void SetComponent(Component component)
            { this.component = component; }
        public override void Add()
        {
            if (component != null)
                component.Add();
        }
    }
}
