using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memento
{
    public class Context
    {

        TextCareTaker careTake = new TextCareTaker();

        public void Save(RichTextBox richTex)
        {
            careTake.AddMemento(new TextMemento(richTex.Text));
        }

        public void Load(RichTextBox richText)
        {
            if (careTake.GetLast() != null && careTake.GetLast().savedText != null)
                richText.Text = careTake.GetLast().savedText;
        }
    }
}
