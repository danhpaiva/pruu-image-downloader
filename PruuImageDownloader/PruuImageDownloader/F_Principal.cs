using PruuImageDownloader.Helper;
using System.Diagnostics;

namespace PruuImageDownloader
{
    public partial class F_Principal : Form
    {
        public F_Principal()
        {
            InitializeComponent();
        }

        private void cb_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_product.Text == "Windows")
            {
                cb_version.Items.Clear();
                cb_version.Enabled = true;
                cb_version.Items.Add("Windows 11 22H2");
            }
            else if (cb_product.Text == "Office")
            {
                cb_version.Items.Clear();
                cb_version.Enabled = true;
                cb_version.Items.Add("Office 2021 LTSC");
            }
            else
                Messages.MessageSelectAnIten("...");
        }

        private void cb_version_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_version.Text == "Windows 11 22H2")
            {
                cb_language.Items.Clear();
                cb_language.Enabled = true;
                cb_language.Items.Add("PT-BR");
            }
            else if (cb_version.Text == "Office 2021 LTSC")
            {
                cb_language.Items.Clear();
                cb_language.Enabled = true;
                cb_language.Items.Add("PT-BR");
            }
            else
                Messages.MessageSelectAnIten("...");
        }

        private void cb_language_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cb_language.Text == "PT-BR") && (cb_version.Text == "Windows 11 22H2"))
            {
                cb_arch.Enabled = true;
                cb_arch.Items.Clear();
                cb_arch.Items.Add("X64");
            }
            else if ((cb_language.Text == "PT-BR") && (cb_version.Text == "Office 2021 LTSC"))
            {
                cb_arch.Enabled = true;
                cb_arch.Items.Clear();
                cb_arch.Items.Add("X86");
                cb_arch.Items.Add("X64");
            }
            else
                Messages.MessageSelectAnIten("...");
        }

        private void cb_arch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_arch.Text == "X86")
            {
                btn_start_download.Enabled = true;
            }
            else if (cb_arch.Text == "X64")
            {
                btn_start_download.Enabled = true;
            }
            else
                Messages.MessageSelectAnIten("...");
        }

        private void btn_start_download_Click(object sender, EventArgs e)
        {
            ValidateExecuteDownload.Windows1122h2PtBr(cb_product, cb_version, cb_language, cb_arch);
            ValidateExecuteDownload.Office2021ProPlusPtBr(cb_product, cb_version, cb_language, cb_arch);
        }

        private void lbl_contact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", "https://github.com/danhpaiva");
        }
    }
}