using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace JK_Control_Helper
{

    public partial class MainForm : Form
    {

        MouseSettings _mouse;

        public MainForm()
        {
            InitializeComponent();

            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Profile files (*.plr)|*.plr";
        }




        // UI

        private void Button_Browse_Click(object sender, EventArgs e)
        {

            var diag = openFileDialog1.ShowDialog();

            if ( diag == DialogResult.OK )
            {
                textBox_profile.Text = openFileDialog1.FileName;
                textBox_profile.SelectionStart = textBox_profile.Text.Length;
                textBox_profile.SelectionLength = 0;

                ReadProfile(textBox_profile.Text);

            }

        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            if (
                ValidateInput(textBox_mouse_x) ||
                ValidateInput(textBox_mouse_y) ||
                ValidateInput(textBox_scroll)
            )
            {
                MessageBox.Show("One of your inputs were formatted incorrectly. Make sure its in the format of \"0.123456\". If not that, it went below 0 or over 4", "Formatting error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            textBox_mouse_x.Text = Decimal.Parse(textBox_mouse_x.Text).ToString("0.000000");
            textBox_mouse_y.Text = Decimal.Parse(textBox_mouse_y.Text).ToString("0.000000");
            textBox_scroll.Text = Decimal.Parse(textBox_scroll.Text).ToString("0.000000");

            if (_mouse.mouse_x != null) _mouse.mouse_x[4] = textBox_mouse_x.Text;
            if (_mouse.mouse_y != null) _mouse.mouse_y[4] = textBox_mouse_y.Text;
            if (_mouse.mouse_scroll != null) _mouse.mouse_scroll[4] = textBox_scroll.Text;


            WriteProfile(textBox_profile.Text);
        }




        // IO

        public void ReadProfile(string file)
        {

            string[] lines = File.ReadAllLines(file, Encoding.UTF8);

            _mouse = new MouseSettings();

            foreach (var s in lines)
            {

                var split = s.Split(' ');

                if (split.Length == 5)
                {

                    if (split[2] == "12") _mouse.mouse_x = split;
                    if (split[2] == "13") _mouse.mouse_y = split;
                    if (split[2] == "14") _mouse.mouse_scroll = split;

                }

            }

            SetTextboxIfBound(textBox_mouse_x, _mouse.mouse_x);
            SetTextboxIfBound(textBox_mouse_y, _mouse.mouse_y);
            SetTextboxIfBound(textBox_scroll, _mouse.mouse_scroll);

        }

        public void WriteProfile(string file)
            {
                string[] lines = File.ReadAllLines(file, Encoding.UTF8);
                File.Delete(file);

                using (var sw = new StreamWriter(file))
                {
                    foreach (var s in lines)
                    {
                        var split = s.Split(' ');

                        if (split.Length == 5)
                        {

                            if (split[2] == "12" && _mouse.mouse_x != null) sw.WriteLine(string.Join(" ", _mouse.mouse_x));
                            if (split[2] == "13" && _mouse.mouse_y != null) sw.WriteLine(string.Join(" ", _mouse.mouse_y));
                            if (split[2] == "14" && _mouse.mouse_scroll != null) sw.WriteLine(string.Join(" ", _mouse.mouse_scroll));

                        }
                        else sw.WriteLine(s);

                    }
                }

            }



        // Utility

        private void SetTextboxIfBound(TextBox box, string[] value)
        {
            if (value != null) box.Text = value[4];
            else box.Enabled = false;
        }

        public bool ValidateInput(TextBox box)
        {
            if (box.Text[1] != '.') return true;

            decimal dec;

            Decimal.TryParse(box.Text, out dec);

            if (
                dec == null ||
                dec < 0 ||
                dec > 4
            ) return true;

            return false;

        }

      

        // Not sure why I wanted a class for this but whatever

        private class MouseSettings
        {
            public string[] mouse_x;
            public string[] mouse_y;
            public string[] mouse_scroll;

            /*
             
                Bind function

                Arg 1, Function

                    0 Move Forward/Back
	                1 Turn Left/Right
	                2 Slide Left/Right
	                8 Pitch Up/Down

                Arg 2

                    13 = mouse y
	                12 = mouse x
	                14 = scroll

                Arg 3

                    0x1	Reverse
	                0x5	No setting
	                0xd	Map directly to axis value
	                0x9	Map directly to axis value + Reverse

                Arg 4

                    Sensitivity, 0.000000 - 4.000000 (normally bottoms out at 0.250000 from in-game settings)

            */

        }




    }
}