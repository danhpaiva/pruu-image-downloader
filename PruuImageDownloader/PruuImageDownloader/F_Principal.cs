using PruuImageDownloader.Helper;
using System.Diagnostics;

namespace PruuImageDownloader
{
    public partial class F_Principal : Form
    {
        const string edgeFolder = "C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedge.exe";
        public F_Principal()
        {
            InitializeComponent();
        }

        private void cb_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_product.Text == "Windows")
            {
                CleanProduct();
                cb_version.Items.Add("Windows 11 22H2");
            }
            else if (cb_product.Text == "Office")
            {
                CleanProduct();
                cb_version.Items.Add("Office 2021 LTSC");
            }
            else
                Messages.MessageSelectAnIten("...");
        }

        private void cb_version_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_version.Text == "Windows 11 22H2")
            {
                CleanVersion();
                cb_language.Items.Add("PT-BR");
            }
            else if (cb_version.Text == "Office 2021 LTSC")
            {
                CleanVersion();
                cb_language.Items.Add("PT-BR");
            }
            else
                Messages.MessageSelectAnIten("...");
        }

        private void cb_language_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cb_language.Text == "PT-BR") && (cb_version.Text == "Windows 11 22H2"))
            {
                CleanArch();
                cb_arch.Items.Add("X64");
            }
            else if ((cb_language.Text == "PT-BR") && (cb_version.Text == "Office 2021 LTSC"))
            {
                CleanArch();
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
            if(cb_product.Text == "Windows")
                ValidateExecuteDownload.Windows_11_22h2_PtBr(cb_product, cb_version, cb_language, cb_arch, edgeFolder);
            else
                ValidateExecuteDownload.Office_2021_Pro_Plus_PtBr(cb_product, cb_version, cb_language, cb_arch, edgeFolder);
        }

        private void lbl_contact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", "https://github.com/danhpaiva");
        }

        private void CleanProduct()
        {
            cb_version.Enabled = true;
            cb_arch.Text = "";
            cb_language.Text = "";
            cb_version.Text = "";
            cb_version.Items.Clear();
        }

        private void CleanVersion()
        {
            cb_language.Enabled = true;
            cb_language.Text = "";
            cb_version.Text = "";
            cb_language.Items.Clear();
        }

        private void CleanArch()
        {
            cb_arch.Enabled = true;
            cb_arch.Text = "";
            cb_arch.Items.Clear();
        }
    }
}