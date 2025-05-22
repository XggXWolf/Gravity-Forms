using System.Diagnostics;

namespace GravitySimulator
{
    public partial class ControlPanel : Form
    {
        List<Gravityable> gForms = new();

        public ControlPanel()
        {
            InitializeComponent();
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {

        }

        private void simulateGravity_CheckedChanged(object sender, EventArgs e)
        {
            if (simulateGravity.CheckState == CheckState.Checked)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
                foreach (var gForm in gForms)
                {

                    gForm.velocityX = 0;
                    gForm.velocityY = 0;

                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach(var gForm in gForms)
            {

                gForm.calculateGForce(gForms , new Point(1920, 1080), 1);

                gForm.velocityX -= gForm.gForce.X;
                gForm.velocityY -= gForm.gForce.Y;

                gForm.Location = new Point(gForm.Location.X + (int)gForm.velocityX, gForm.Location.Y + (int)gForm.velocityY);
            }
        }

        private void addForm_Click(object sender, EventArgs e)
        {
            Gravityable g = new Gravityable();
            g.Show();
            gForms.Add(g);
        }

        private void removeForm_Click(object sender, EventArgs e)
        {
            Gravityable g = gForms[gForms.Count - 1];
            g.Close();
            gForms.Remove(g);
        }
    }
}
