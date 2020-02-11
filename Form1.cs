using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace JK_Sensitivity_Helper
{

    public partial class MainForm : Form
    {

        MouseSettings _mouse;

        public MainForm()
        {
            InitializeComponent();

            string StartupPath = Application.StartupPath;

            if (Properties.Settings.Default.LastPath != "") StartupPath = Properties.Settings.Default.LastPath;

            openFileDialog1.InitialDirectory = StartupPath;
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Profile files (*.plr)|*.plr";
        }




        // UI

        private void Button_Browse_Click(object sender, EventArgs e)
        {

            var diag = openFileDialog1.ShowDialog();

            if ( diag == DialogResult.OK )
            {

                Properties.Settings.Default.LastPath = Path.GetDirectoryName(openFileDialog1.FileName);
                Properties.Settings.Default.Save();

                textBox_profile.Text = openFileDialog1.FileName;
                textBox_profile.SelectionStart = textBox_profile.Text.Length;
                textBox_profile.SelectionLength = 0;

                ReadProfile(textBox_profile.Text);

            }

        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
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

            if (textBox_mouse_x.Enabled == false &&
                textBox_mouse_y.Enabled == false &&
                textBox_scroll.Enabled == false
            ) groupBox1.Enabled = true;
            else
            {
                MessageBox.Show("No relevant mouse binds found. Are you sure this is a real player profile?", "No binds found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



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


        private void TextBox_FormatInput(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(box.Text)) box.Text = "0";
            box.Text = box.Text.Replace(',', '.');

            decimal dec = -1;

            try
            {
                dec = decimal.Parse(box.Text, System.Globalization.CultureInfo.InvariantCulture);

                if (dec > 4) dec = 4;
                if (dec < 0) dec = 0;

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            box.Text = dec.ToString("0.000000");

        }

        private void TextBox_Input_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBox_FormatInput(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}