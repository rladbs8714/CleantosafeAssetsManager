using CleantosafeAssetsManager.DTO;

namespace CleantosafeAssetsManager
{
    /*
     *  ===========================================================================
     *  작성자     : @yoon
     *  최초 작성일: 2025.07.03
     *  
     *  < 목적 >
     *  - CleantosafeAssetsManager의 HRM 화면에서 인원 추가 화면을 구현한다.
     *  
     *  < TODO >
     *  -
     *  
     *  < History >
     *  2025.07.03 @yoon
     *  - 최초 작성
     *  ===========================================================================
     */

    public partial class AddHuman : SubForm
    {

        // ====================================================================
        // PROPERTIES
        // ====================================================================

        public HRMHuman_DTO Result { get; private set; }


        // ====================================================================
        // CONSTRUCTORS
        // ====================================================================

        public AddHuman()
        {
            InitializeComponent();

            btnAdd.Click += Add;
            btnCancel.Click += CancelAdd;
        }


        // ====================================================================
        // METHODS - EVENT
        // ====================================================================

        private void Add(object? sender, EventArgs e)
        {
            Result = new HRMHuman_DTO()
            {
                Guid = Guid.NewGuid(),
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

        private void CancelAdd(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
