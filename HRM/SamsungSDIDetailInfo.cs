using CleantosafeAssetsManager.DTO;

namespace CleantosafeAssetsManager
{
    public partial class SamsungSDIDetailInfo : UserControl
    {
        public SamsungSDIDetailInfo(HRMSamsungSDI_DTO sdi)
        {
            InitializeComponent();

            tbVpassID.Text = sdi.VPass.ID;
            tbVpassPW.Text = sdi.VPass.Passward;
            tbMEHSID.Text = sdi.MEHS.ID;
            tbMEHSPW.Text = sdi.MEHS.Passward;
        }
    }
}
