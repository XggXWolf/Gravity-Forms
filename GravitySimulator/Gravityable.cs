using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GravitySimulator
{
    public partial class Gravityable : Form
    {
        public Vector2 gForce;
        public float velocityX;
        public float velocityY;

        public Gravityable()
        {
            gForce = new Vector2(0, 0);
            InitializeComponent();
        }

        private void Gravityable_Load(object sender, EventArgs e)
        {

        }

        public void calculateGForce(Point maxDistance, float multiplier)
        {
            float deltaX = -((this.Location.X - Cursor.Position.X) / (float)maxDistance.X);
            float deltaY = -((this.Location.Y - Cursor.Position.Y) / (float)maxDistance.Y);

            this.gForce = new Vector2(deltaX, deltaY) * multiplier;
        }

        public void calculateGForce(List<Gravityable> formList, Point maxDistance, float multiplier)
        {
            Vector2 totalForce = new Vector2(0, 0);
            foreach (Gravityable gForm in formList)
            {
                float deltaX = -((this.Location.X - gForm.Location.X) / (float)maxDistance.X);
                float deltaY = -((this.Location.Y - gForm.Location.Y) / (float)maxDistance.Y);



                Vector2 localForce = new Vector2(deltaX, deltaY) * multiplier;
                totalForce += localForce;
            }
            this.gForce = totalForce;
        }
    }
}
