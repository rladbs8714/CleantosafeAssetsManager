namespace CleantosafeAssetsManager
{
    /*
     *  ===========================================================================
     *  �ۼ���     : @yoon
     *  ���� �ۼ���: 2025.06.19
     *  
     *  < ���� >
     *  - CleantosafeAssetsManager�� ���� ȭ���� �����Ѵ�.
     *  
     *  < TODO >
     *  
     *  < History >
     *  2025.06.19 @yoon
     *  - ���� �ۼ�
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
        /// <seealso cref="mcMain"/>���� ������ ��¥
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
            TabPage HRMTab = new TabPage("���� �ڿ� ����");
            HRMTab.Controls.Add(new HRMControl()
            {
                Dock = DockStyle.Fill,
            });
            tbcMain.TabPages.Add(HRMTab);

            // add Inventory control in the tbcMain new tab
            TabPage inventoryTab = new TabPage("��ǰ ����");
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
        /// <seealso cref="mcMain"/>�� ��¥�� ����Ǹ� �߻��ϴ� �̺�Ʈ�� �߰��Ѵ�.
        /// </summary>
        /// <param name="action">�߰��� �̺�Ʈ</param>
        public void AddChangeDateEvent(Action<object?, DateRangeEventArgs> action)
        {
            mcMain.DateChanged += (s, e) => action(s, e);
        }

        /// <summary>
        /// <seealso cref="mcMain"/>�� ��¥�� ����Ǹ� �߻��ϴ� �̺�Ʈ�� �߰��Ѵ�.
        /// </summary>
        /// <param name="action">�߰��� �̺�Ʈ</param>
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
