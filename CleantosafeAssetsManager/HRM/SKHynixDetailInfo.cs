using CleantosafeAssetsManager.DTO;

namespace CleantosafeAssetsManager
{
    public partial class SKHynixDetailInfo : UserControl
    {
        public SKHynixDetailInfo(HRMSKHynix_DTO hynix)
        {
            InitializeComponent();

            tbWelcomeID.Text = hynix.Welcome.ID;
            tbWelcomePW.Text = hynix.Welcome.Passward;
            tbSTED.Text = hynix.SafetyTrainingExpiryDate.ToString("yyyy년 MM월 dd일");
        }
    }
}
