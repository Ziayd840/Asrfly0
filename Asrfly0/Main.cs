using Asrfly0.Code;

namespace Asrfly0
{
    public partial class Main : Form
    {
        private readonly PageManager pageManager;
        public Main()
        {
            InitializeComponent();
            pageManager = new PageManager(this);
            pageManager.LoadPage(Gui.GuiHome.HomeUserControl.Instance());
        }
        #region Events
        private void buttonHome_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(Gui.GuiHome.HomeUserControl.Instance());

        }
        #endregion
    }
}