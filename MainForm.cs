/*
    DesktopView - A multi-desktop capturing sotware
    Copyright (C) 2012 Nir Atias

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DesktopViewer {
    public partial class MainForm : Form {
        private Rectangle captureBounds;
        private Graphics graphics;

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            RefreshMonitors();
        }

        private void RefreshMonitors() {
            int i = 0;
            monitorSelection.Items.Clear();
            foreach (Screen s in Screen.AllScreens) {
                monitorSelection.Items.Add(new ScreenWrapper(i++, s));
            }

            monitorSelection.SelectedIndex = 0;
        }

        private void enabled_Click(object sender, EventArgs e) {
            if (enabledButton.Checked) {
                enabledButton.Text = "Stop";
                this.captureBounds = ((ScreenWrapper)monitorSelection.SelectedItem).Screen.Bounds;
                Bitmap p = new Bitmap(this.captureBounds.Size.Width, this.captureBounds.Size.Height);
                this.image.Image = p;

                this.graphics = Graphics.FromImage(this.image.Image);
                timer.Start();
            } else {
                enabledButton.Text = "Start";
                timer.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            this.graphics.CopyFromScreen(captureBounds.Location, new Point(0, 0), captureBounds.Size);
            this.image.Invalidate();
        }

        private void aboutButton_Click(object sender, EventArgs e) {
            AboutBox dlg = new AboutBox();
            dlg.ShowDialog(this);
        }
    }

    class ScreenWrapper {
        public Screen Screen { get; set; }
        public int Index { get; set; }

        public ScreenWrapper(int index, Screen s) {
            this.Screen = s;
            this.Index = index;
        }

        public override string ToString() {
            return "Montior " + Index + " (" + Screen.DeviceName + ")"; ;
        }
    }

}
