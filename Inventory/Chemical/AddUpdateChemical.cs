using CleantosafeAssetsManager.DTO;

namespace CleantosafeAssetsManager
{
    /*
     *  ===========================================================================
     *  작성자     : @yoon
     *  최초 작성일: 2025.07.23
     *  
     *  < 목적 >
     *  - CleantosafeAssetsManager의 Inventory-Chemical 의 추가&수정 화면을 구현한다.
     *  
     *  < TODO >
     *  -
     *  
     *  < History >
     *  2025.07.23 @yoon
     *  - 최초 작성
     *  ===========================================================================
     */

    public partial class AddUpdateChemical : UserControl
    {

        // ====================================================================
        // PROPERTIES
        // ====================================================================

        /// <summary>
        /// 컨트롤에서 정의된 결과값
        /// </summary>
        public InventoryChemical_DTO Result { get; private set; }


        // ====================================================================
        // CONSTRUCTORS
        // ====================================================================

        public AddUpdateChemical(EFormOpenReason reason, InventoryChemical_DTO? org = null)
        {
            InitializeComponent();

            switch (reason)
            {
                case EFormOpenReason.Add:
                    btnOk.Text = "추가";
                    break;
                case EFormOpenReason.Update:
                    btnOk.Text = "수정";
                    if (org == null) break;
                    Result = org;
                    Init(org);
                    break;
                default:
                    throw new ArgumentException();
            }

            // chain event to control
            btnOk.Click += ClickOK;
            btnCancel.Click += ClickCancel;
        }


        // ====================================================================
        // METHODS
        // ====================================================================

        private void Init(InventoryChemical_DTO org)
        {
            tbName.Text        = org.Name;
            tbBrandName.Text   = org.BrandName;
            tbPurpose.Text     = org.Purpose;
            tbQty.Text         = org.Qty.ToString();
            tbDescription.Text = org.Description;

            if (org.pH == null) return;
            tbpHMin.Text = org.pH.Min.ToString();
            tbpHMax.Text = org.pH.Max.ToString();
        }


        // ====================================================================
        // METHODS - EVENTS
        // ====================================================================

        /// <summary>
        /// OK 버튼을 클릭했을 때 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickOK(object? sender, EventArgs e)
        {
            Result = new InventoryChemical_DTO()
            {
                Guid      = Result == null ? Guid.NewGuid() : Result.Guid,
                Name      = tbName.Text,
                BrandName = tbBrandName.Text,
                Purpose   = tbPurpose.Text,
                pH = new InventoryChemical_DTO.MinMax()
                {
                    Min = float.Parse(tbpHMin.Text),
                    Max = float.Parse(tbpHMax.Text)
                },
                Qty         = double.Parse(tbQty.Text),
                Description = tbDescription.Text,
            };

            if (ParentForm == null || ParentForm is not AddUpdateForm auf)
                return;

            auf.SetResult(true);
        }

        /// <summary>
        /// Cancel 버튼을 클릭했을 때 발생하는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickCancel(object? sender, EventArgs e)
        {
            if (ParentForm == null || ParentForm is not AddUpdateForm auf)
                return;

            auf.SetResult(false);
        }
    }
}
