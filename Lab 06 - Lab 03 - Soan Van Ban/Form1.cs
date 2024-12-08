using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_06___Lab_03___Soan_Van_Ban
{
    public partial class Form1 : Form
    {

        private string currentFilePath = null;
        public Form1()
        {
            InitializeComponent();
            LoadFonts();
            LoadSizes();
            SetDefaultFontAndSize();
        }
        private void LoadFonts()
        {
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                cmbFont.Items.Add(font.Name);
            }
        }

        private void LoadSizes()
        {
            // Tạo các giá trị Size
            for (int i = 8; i <= 72; i++)
            {
                cmbSize.Items.Add(i);
            }
        }

        private void SetDefaultFontAndSize()
        {
            // Thiết lập giá trị mặc định
            cmbFont.SelectedItem = "Tahoma";
            cmbSize.SelectedItem = 14;
            richTextBox1.Font = new Font("Tahoma", 14);
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            SetDefaultFontAndSize();
            currentFilePath = null;
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.LoadFile(openFileDialog.FileName, openFileDialog.FilterIndex == 1 ? RichTextBoxStreamType.PlainText : RichTextBoxStreamType.RichText);
                    currentFilePath = openFileDialog.FileName; // Cập nhật đường dẫn tệp hiện tại
                }
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (currentFilePath == null) // Nếu là văn bản mới
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf|Text Files (*.txt)|*.txt";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                        currentFilePath = saveFileDialog.FileName;
                        MessageBox.Show("Lưu văn bản thành công!", "Thông báo");
                    }
                }
            }
            else
            {
                richTextBox1.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                MessageBox.Show("Lưu văn bản thành công!", "Thông báo");
            }
        }

        private void cmbFont_SelectedIndexChange (object sender, EventArgs e)
        {
            if (cmbFont.SelectedItem != null)
            {
                richTextBox1.Font = new Font(cmbFont.SelectedItem.ToString(), richTextBox1.Font.Size);
            }
        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSize.SelectedItem != null)
            {
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, Convert.ToSingle(cmbSize.SelectedItem));
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Bold);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Italic);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Underline);
        }

        private void ToggleFontStyle(FontStyle style)
        {
            Font currentFont = richTextBox1.SelectionFont;
            if (currentFont != null)
            {
                FontStyle newStyle = currentFont.Style ^ style; // Thay đổi trạng thái của font
                richTextBox1.SelectionFont = new Font(currentFont, newStyle);
            }
        }
    }
}
