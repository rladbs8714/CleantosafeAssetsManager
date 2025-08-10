namespace CleantosafeAssetsManager
{
    /*
     *  ===========================================================================
     *  작성자     : @yoon
     *  최초 작성일: 2025.06.22
     *  
     *  < 목적 >
     *  - CleantosafeAssetsManager의 Todo Option을 구현한다.
     *  
     *  < TODO >
     *  
     *  < History >
     *  2025.06.22 @yoon
     *  - 최초 작성
     *  ===========================================================================
     */

    public partial class TodoOption : Form
    {

        // ====================================================================
        // FIELDS
        // ====================================================================

        /// <summary>
        /// 모체 Form에서 받는 Todo 추가 인터페이스
        /// </summary>
        private readonly IAddTodoWithOption TodoAddOption;


        // ====================================================================
        // CONSTRUCTORS
        // ====================================================================

        public TodoOption(IAddTodoWithOption addOption)
        {
            InitializeComponent();

            TodoAddOption = addOption;

            // chain event
            btnAdd.Click += AddTodo;
        }


        // ====================================================================
        // METHODS
        // ====================================================================

        /// <summary>
        /// Todo를 추가한다.
        /// </summary>
        /// <param name="sender"><seealso cref="Button"/></param>
        /// <param name="e"><seealso cref="Button.OnClick(EventArgs)"/></param>
        private void AddTodo(object? sender, EventArgs e)
        {
            // 파라메터로 받은 ITodoSetOption.SetTodoOption을 호출한다.
            TodoAddOption.AddTodoWithOption(
                tbTitle.Text,           // 제목
                dtpStart.Value,         // 시작 날짜
                dtpEnd.Value,           // 종료 날짜
                tbDetailContent.Text,   // 상세 설명
                cbDoubleCheck.Checked   // 더블 체크 확인
                );

            this.Close();
        }
    }
}
