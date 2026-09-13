using System;
using System.Drawing;
using System.Windows.Forms;

namespace DnG_AdK_Mapedit
{
    public class HexColorDialog : Form
    {
        private TextBox txtHex;
        private Panel panelPreview;
        private Button btnPickColor;
        private Button btnOk;
        private Button btnCancel;

        public Color SelectedColor { get; private set; }

        public HexColorDialog(Color initialColor)
        {
            SelectedColor = initialColor;
            InitializeComponents();
            UpdateUI(initialColor);
        }

        private void InitializeComponents()
        {
            this.Text = "Select Color";
            this.Size = new Size(330, 155);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;

            Label lblHex = new Label { Text = "HEX:", Location = new Point(12, 20), AutoSize = true };
            txtHex = new TextBox { Location = new Point(50, 17), Width = 100 };
            txtHex.TextChanged += TxtHex_TextChanged;

            panelPreview = new Panel { Location = new Point(160, 17), Size = new Size(40, 23), BorderStyle = BorderStyle.FixedSingle };

            btnPickColor = new Button { Text = "Palette...", Location = new Point(210, 16), Width = 90, Height = 25 };
            btnPickColor.Click += BtnPickColor_Click;

            btnOk = new Button { Text = "OK", DialogResult = DialogResult.OK, Location = new Point(135, 70), Width = 75 };
            btnCancel = new Button { Text = "Cancel", DialogResult = DialogResult.Cancel, Location = new Point(220, 70), Width = 75 };

            this.Controls.AddRange(new Control[] { lblHex, txtHex, panelPreview, btnPickColor, btnOk, btnCancel });
            this.AcceptButton = btnOk;
            this.CancelButton = btnCancel;
        }

        private void UpdateUI(Color color)
        {
            SelectedColor = color;
            txtHex.Text = $"#{color.R:X2}{color.G:X2}{color.B:X2}";
            panelPreview.BackColor = color;
        }

        private void TxtHex_TextChanged(object sender, EventArgs e)
        {
            string hex = txtHex.Text.Trim();
            if (!string.IsNullOrEmpty(hex) && !hex.StartsWith("#"))
            {
                hex = "#" + hex;
            }

            try
            {
                Color parsedColor = ColorTranslator.FromHtml(hex);
                SelectedColor = parsedColor;
                panelPreview.BackColor = parsedColor;
            }
            catch
            {
                // Ignore incomplete or invalid HEX input while typing
            }
        }

        private void BtnPickColor_Click(object sender, EventArgs e)
        {
            using ColorDialog cd = new ColorDialog { Color = SelectedColor, AllowFullOpen = true };
            if (cd.ShowDialog(this) == DialogResult.OK)
            {
                UpdateUI(cd.Color);
            }
        }
    }
}