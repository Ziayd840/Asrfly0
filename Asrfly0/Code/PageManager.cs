using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace Asrfly0.Code
{
    public class PageManager
    {
        private readonly Main main;

        public PageManager(Main main)
        {
            this.main = main;
        }
        public void LoadPage(UserControl PageUserControl)
        {
            var oldPage = main.panelContainer.Controls.OfType<UserControl>().FirstOrDefault();
            if (oldPage != null)
            {
                main.panelContainer.Controls.Remove(oldPage);
                oldPage.Dispose();

            }
            PageUserControl.Dock = DockStyle.Fill;
            main.panelContainer.Controls.Add(PageUserControl);


        }
    }
}
