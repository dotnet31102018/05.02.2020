using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class TextCareTaker
    {
        TextMemento memento = null;

        public void AddMemento(TextMemento memento)
        {
            this.memento = memento;
        }

        public TextMemento GetLast()
        {
            return this.memento;
        }
    }
}
