using CleantosafeAssetsManager.DTO;

namespace CleantosafeAssetsManager
{
    /*
     *  ===========================================================================
     *  작성자     : @yoon
     *  최초 작성일: 2025.07.03
     *  
     *  < 목적 >
     *  - CleantosafeAssetsManager의 HRM 화면에서 인원 수정 화면을 구현한다.
     *  
     *  < TODO >
     *  -
     *  
     *  < History >
     *  2025.07.03 @yoon
     *  - 최초 작성
     *  ===========================================================================
     */

    public partial class UpdateHuman : SubForm
    {

        // ====================================================================
        // FIELDS
        // ====================================================================

        private readonly Guid Guid;


        // ====================================================================
        // PROPERTIES
        // ====================================================================

        public HRMHuman_DTO Result { get; private set; }


        // ====================================================================
        // CONSTRUCTORS
        // ====================================================================

        public UpdateHuman(HRMHuman_DTO human)
        {
            InitializeComponent();

            Guid = human.Guid;

            tbName.Text = human.Name;
            tbPhoneNumber.Text = human.PhoneNumber;
            dtpBirthDate.Value = human.BirthDate;
            cbGender.Text = human.Gender;
            tbAddress.Text = human.Address;
            if (human.SamsungSDI != null)
            {
                tbVpassID.Text = human.SamsungSDI.VPass.ID;
                tbVpassPW.Text = human.SamsungSDI.VPass.Passward;
                tbMEHSID.Text = human.SamsungSDI.MEHS.ID;
                tbMEHSPW.Text = human.SamsungSDI.MEHS.Passward;
            }
            if (human.SKHynix != null)
            {
                tbWelcomeID.Text = human.SKHynix.Welcome.ID;
                tbWelcomePW.Text = human.SKHynix.Welcome.Passward;
                dtpSTED.Value = human.SKHynix.SafetyTrainingExpiryDate;
            }

            btnUpdate.Click += Update;
            btnCancel.Click += CancelUpdate;
        }


        // ====================================================================
        // METHODS - EVENT
        // ====================================================================

        private void Update(object? sender, EventArgs e)
        {
            Result = new HRMHuman_DTO()
            {
                Guid = Guid,
                Name = tbName.Text,
                PhoneNumber = tbPhoneNumber.Text,
                BirthDate = dtpBirthDate.Value,
                Gender = cbGender.Text,
                Address = tbAddress.Text,
                SamsungSDI = new HRMSamsungSDI_DTO()
                {
                    VPass = new HRMIdPasswardPair()
                    {
                        ID = tbVpassID.Text,
                        Passward = tbVpassPW.Text
                    },
                    MEHS = new HRMIdPasswardPair()
                    {
                        ID = tbMEHSID.Text,
                        Passward = tbMEHSID.Text
                    }
                },
                SKHynix = new HRMSKHynix_DTO()
                {
                    Welcome = new HRMIdPasswardPair()
                    {
                        ID = tbWelcomeID.Text,
                        Passward = tbWelcomeID.Text
                    },
                    SafetyTrainingExpiryDate = dtpSTED.Value
                }
            };

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelUpdate(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
