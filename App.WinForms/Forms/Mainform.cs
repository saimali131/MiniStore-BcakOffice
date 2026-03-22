using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.WinForms.Forms;
using App.WinForms.Views;

namespace App.WinForms.Forms
{
    public partial class Mainform : Form
    {

        private readonly Dictionary<Type, UserControl> _views = new Dictionary<Type, UserControl>();

        public Mainform()
        {
            InitializeComponent();
        }
        private void WireNavigation()
        {
            btnDashboard.Click +=(s,e)=>
            {

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //this.pnlContent.Controls.Clear();
            //this.pnlContent.Controls.Add(new DashboardView());
            ShowView(() => new DashboardView());
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            //this.pnlContent.Controls.Clear();
            //this.pnlContent.Controls.Add(new ProductView());
            ShowView(() => new ProductView());
        }

        private void Btnorders_Click(object sender, EventArgs e)
        {

        }

        private void BtnReport_Click(object sender, EventArgs e)
        {

        }

        private void BtnSync_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogs_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pnlcontent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShowView<T>(Func<T> factory ) where T  :UserControl 
        {
            var key = typeof(T);
            if (!_views.TryGetValue(key , out var view))
            {
                view = factory();
                view.Dock = DockStyle.Fill;
                
                _views[key] = view;
            }
            if (!pnlContent.Controls.Contains(view))
            {
                pnlContent.Controls.Clear();
                pnlContent.Controls.Add(view);
            }
            view.BringToFront();
        }
    }
}
