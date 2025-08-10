namespace CleantosafeAssetsManager
{
    /*
     *  ===========================================================================
     *  작성자     : @yoon
     *  최초 작성일: 2025.07.23
     *  
     *  < 목적 >
     *  - CleantosafeAssetsManager의 Inventory의 추가&수정 화면을 구현한다.
     *  
     *  < TODO >
     *  -
     *  
     *  < History >
     *  2025.07.23 @yoon
     *  - 최초 작성
     *  ===========================================================================
     */

    public partial class AddUpdateForm : Form
    {
        // ====================================================================
        // CONSTRUCTORS
        // ====================================================================

        public AddUpdateForm(UserControl control)
        {
            InitializeComponent();

            Controls.Add(control);
        }


        // ====================================================================
        // METHODS
        // ====================================================================

        public void SetResult(bool isOk)
        {
            if (isOk)
                DialogResult = DialogResult.OK;
            else
                DialogResult = DialogResult.Cancel;

            this.Close();
        }
    }
}
