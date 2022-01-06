using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproject
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products product = new Products();
            product.MdiParent = this;
            product.StartPosition = FormStartPosition.CenterScreen;
            product.Show();
        }

        private void goods_Received_Click(object sender, EventArgs e)
        {
            GoodsReceived goods = new GoodsReceived();
            goods.MdiParent = this;
            goods.StartPosition = FormStartPosition.CenterScreen;
            goods.Show();
        }

        private void deliveryNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeliveryNote note = new DeliveryNote();
            note.MdiParent = this;
            note.StartPosition = FormStartPosition.CenterScreen;
            note.Show();
        }

        private void stockReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StockReport stockreport = new StockReport();
            stockreport.MdiParent = this;
            stockreport.StartPosition = FormStartPosition.CenterScreen;
            stockreport.Show();
        }

        private void revenueReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RevenueReport revenuereport = new RevenueReport();
            revenuereport.MdiParent = this;
            revenuereport.StartPosition = FormStartPosition.CenterScreen;
            revenuereport.Show();
        }
    }
}
