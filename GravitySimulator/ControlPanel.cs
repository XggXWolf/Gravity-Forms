using System.Diagnostics;

namespace GravitySimulator
{
    public partial class ControlPanel : Form
    {
        List<Gravityable> gForms = new();
        private static bool CenterMouse = false;

        public ControlPanel()
        {
            InitializeComponent();
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {

        }

        private void simulateGravity_CheckedChanged(object sender, EventArgs e)
        {
            switch(simulateGravity.CheckState)
            {
                case CheckState.Checked:
                    timer1.Start();
                    break;
                case CheckState.Unchecked:
                    timer1.Stop();
                    foreach (var gForm in gForms)
                    {

                        gForm.velocityX = 0;
                        gForm.velocityY = 0;

                    }
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var gForm in gForms)
            {
                if (CenterMouse)
                {
                    gForm.calculateGForce(new Point(3840, 2160), 2);
                } else
                {
                    gForm.calculateGForce(gForms, new Point(3840, 2160), 2);
                }

                gForm.velocityX += gForm.gForce.X;
                gForm.velocityY += gForm.gForce.Y;

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

        private void centerMouse_CheckedChanged(object sender, EventArgs e)
        {
            switch (centerMouse.CheckState)
            {
                case CheckState.Checked:
                    CenterMouse = true;
                    break;
                case CheckState.Unchecked:
                    CenterMouse = false;
                    break;
            }
        }
    }
}
