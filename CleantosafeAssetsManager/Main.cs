namespace CleantosafeAssetsManager
{
    /*
     *  ===========================================================================
     *  작성자     : @yoon
     *  최초 작성일: 2025.06.19
     *  
     *  < 목적 >
     *  - CleantosafeAssetsManager의 메인 화면을 구현한다.
     *  
     *  < TODO >
     *  
     *  < History >
     *  2025.06.19 @yoon
     *  - 최초 작성
     *  ===========================================================================
     */

    public enum EFormOpenReason
    {
        Add,
        Update
    }
    public partial class MainForm : Form, IChangeDate
    {

        // ====================================================================
        // PROPERTIES
        // ====================================================================

        /// <summary>
        /// <seealso cref="mcMain"/>에서 선택한 날짜
        /// </summary>
        public DateTime Date => mcMain.SelectionStart;


        // ====================================================================
        // CONSTRUCTORS
        // ====================================================================

        public MainForm()
        {
            InitializeComponent();

            // add todo-list control in the grbTodo Group Box
            TodoListControl todoListControl = new TodoListControl(this);
            todoListControl.Dock = DockStyle.Fill;
            grbTodo.Controls.Clear();
            grbTodo.Controls.Add(todoListControl);

            // add HRM control in the tbcMain new tab
            TabPage HRMTab = new TabPage("인적 자원 관리");
            HRMTab.Controls.Add(new HRMControl()
            {
                Dock = DockStyle.Fill,
            });
            tbcMain.TabPages.Add(HRMTab);

            // add Inventory control in the tbcMain new tab
            TabPage inventoryTab = new TabPage("물품 관리");
            inventoryTab.Controls.Add(new InventoryControl()
            {
                Dock = DockStyle.Fill,
            });
            tbcMain.TabPages.Add(inventoryTab);

            // mcMain.DateChange
            mcMain.SetDate(DateTime.Now);

            tbcMain.MouseDown += RemoveTabPage;
        }




        // ====================================================================
        // METHODS
        // ====================================================================

        /// <summary>
        /// <seealso cref="mcMain"/>의 날짜가 변경되면 발생하는 이벤트를 추가한다.
        /// </summary>
        /// <param name="action">추가할 이벤트</param>
        public void AddChangeDateEvent(Action<object?, DateRangeEventArgs> action)
        {
            mcMain.DateChanged += (s, e) => action(s, e);
        }

        /// <summary>
        /// <seealso cref="mcMain"/>의 날짜가 변경되면 발생하는 이벤트를 추가한다.
        /// </summary>
        /// <param name="action">추가할 이벤트</param>
        public void RemoveChangeDateEvent(Action<object?, DateRangeEventArgs> action)
        {
            mcMain.DateChanged -= (s, e) => action(s, e);
        }

        private void RemoveTabPage(object? sender, MouseEventArgs e)
        {
            if (sender is not TabControl tc)
                return;

            if (e.Button != MouseButtons.Middle)
                return;

            tc.TabPages.RemoveAt(tc.SelectedIndex);
        }
    }
}
