using System.Diagnostics;

namespace PruuImageDownloader.Helper
{
    public static class ValidateExecuteDownload
    {
        public static void Windows_11_22h2_PtBr(ComboBox cb_product, ComboBox cb_version, ComboBox cb_language, ComboBox cb_arch)
        {
            if (cb_product.Text == "Windows")
            {
                if (cb_version.Text == "Windows 11 22H2")
                {
                    if (cb_language.Text == "PT-BR")
                    {
                        if (cb_arch.Text == "X64")
                            Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", "http://dl.delivery.mp.microsoft.com/filestreamingservice/files/3eb153b9-dec7-4b38-bc69-189fef6e55ef/22621.525.220925-0207.ni_release_svc_refresh_CLIENTCONSUMER_RET_x64FRE_pt-br.esd");
                        else
                            MessageBox.Show("Sorry, image not available");
                    }
                }
            }
        }
        public static void Office_2021_Pro_Plus_PtBr(ComboBox cb_product, ComboBox cb_version, ComboBox cb_language, ComboBox cb_arch)
        {
            if (cb_product.Text == "Office")
            {
                if (cb_version.Text == "Office 2021 LTSC")
                {
                    if (cb_language.Text == "PT-BR")
                    {
                        if (cb_arch.Text == "X64")
                            Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", "https://officecdn.microsoft.com/db/492350f6-3a01-4f97-b9c0-c7c6ddf67d60/media/pt-br/ProPlus2021Retail.img");
                        else
                            Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", "https://officecdn.microsoft.com/db/492350f6-3a01-4f97-b9c0-c7c6ddf67d60/media/pt-br/ProPlus2021Retail.img");
                    }
                }
            }
        }
    }
}
