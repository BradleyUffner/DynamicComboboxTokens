using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace DynamicCombo
{
    class AutoSelectTextboxBehavior:Behavior<TextBox>
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.GotFocus += SelectAll;
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
            AssociatedObject.GotFocus -= SelectAll;
        }

        private void SelectAll(object IChannelSender, EventArgs e)
        {
            AssociatedObject.SelectAll();
        }
    }
}
