using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        private void Reserve_Click(object sender, EventArgs e)
        {
            ReservePage r = new ReservePage();
            r.Show();
            
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            CancelPage c = new CancelPage();
            c.Show();
        }

        private void Roomprice_Click(object sender, EventArgs e)
        {
            PricePage p = new PricePage();
            p.Show();
        }

        private void ShowRooms_Click(object sender, EventArgs e)
        {
            ShowRoomPage sr = new ShowRoomPage();
            sr.Show();
        }
    }
}
