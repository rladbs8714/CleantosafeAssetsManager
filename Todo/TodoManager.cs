using Generalibrary;
using System.Reflection;
using System.Xml;

namespace CleantosafeAssetsManager
{
    /*
     *  ===========================================================================
     *  작성자     : @yoon
     *  최초 작성일: 2025.06.22
     *  
     *  < 목적 >
     *  - CleantosafeAssetsManager의 TodoListManager를 구현한다.
     *  
     *  <양식>
     *  <TItle 
     *  
     *  < TODO >
     *  
     *  < History >
     *  2025.06.22 @yoon
     *  - 최초 작성
     *  ===========================================================================
     */

    public partial class TodoManager : IAddTodoWithOption
    {

        // ====================================================================
        // CONSTANTS
        // ====================================================================

        /// <summary>
        /// 로그 타입
        /// </summary>
        private const string LOG_TYPE = "TodoManager";
        /// <summary>
        /// Save 파일 저장 폴더
        /// </summary>
        private const string SAVE_FOLDER           = "todo";
        private const string FILE_NAME_PRE_FLAG    = "<PRE>";
        private const string FILE_NAME_DATE_FLAG   = "<DATE>";
        private const string FILE_NAME_DATE_FORMAT = "yyyyMMdd";
        private const string FILE_NAME_FORMAT      = $"{FILE_NAME_PRE_FLAG}_{FILE_NAME_DATE_FLAG}.xml";


        // ====================================================================
        // FIELDS
        // ====================================================================

        /// <summary>
        /// log
        /// </summary>
        private readonly ILog Log = LogManager.Instance;
        /// <summary>
        /// xml helper
        /// </summary>
        private readonly XmlHelper XmlHelper;
        /// <summary>
        /// 현재 todo
        /// </summary>
        private Todo? _currentTodo;


        // ====================================================================
        // PROPERTIES
        // ====================================================================

        /// <summary>
        /// <seealso cref="CurrentDate"/> 날짜의 TodoList
        /// </summary>
        public List<Todo> TodoList { get; private set; }
        /// <summary>
        /// 현재 선택된 Todo
        /// </summary>
        public Todo? CurrentTodo
            => _currentTodo;
        /// <summary>
        /// <seealso cref="MainForm.mcMain"/>에서 선택한 날짜
        /// </summary>
        private DateTime CurrentDate { get; set; }


        // ====================================================================
        // CONSTRUCTORS
        // ====================================================================

        public TodoManager(IChangeDate changeDate)
        {
            XmlHelper = new XmlHelper();
            TodoList  = new List<Todo>();

            changeDate.AddChangeDateEvent(ChangeDate);
        }


        // ====================================================================
        // METHODS
        // ====================================================================

        /// <summary>
        /// <paramref name="index"/>번호의 todo를 선택한다.
        /// </summary>
        /// <param name="index">선택할 todo의 인덱스</param>
        public void SetCurrentTodo(int index)
        {
            if (0 > index || TodoList.Count <= index)
                return;
            _currentTodo = TodoList[index];
        }

        /// <summary>
        /// 현재 Todo에 옵션을 삽입한다.
        /// </summary>
        /// <param name="title">제목</param>
        /// <param name="start">시작 날짜</param>
        /// <param name="end">완료 날짜</param>
        /// <param name="detailContent">상세 설명</param>
        /// <param name="doubleCkeck">더블 체크 여부</param>
        /// <exception cref="ArgumentException">같은 제목의 Todo가 이미 존재하다면 발생</exception>
        public void AddTodoWithOption(string title, DateTime start, DateTime end, string detailContent, bool doubleCkeck)
        {
            if (TodoList.Any(t => t.Title == title))
            {
#if DEBUG
                throw new ArgumentException($"같은 제목을 가진 Todo가 이미 존재합니다.");
#elif RELEASE
                return;
#endif
            }

            Todo.TodoOption todoOption = new Todo.TodoOption()
            {
                Description = detailContent,
                DoubleCheck = doubleCkeck,
                Start = start,
                End = end
            };

            AddTodo(title, todoOption);
        }

        /// <summary>
        /// 오늘 날짜 Todo List에 새로운 Todo를 추가한다.
        /// </summary>
        /// <param name="title">Todo 제목</param>
        /// <param name="option">Todo option</param>
        /// <exception cref="ArgumentException">같은 제목의 Todo가 이미 존재하다면 발생</exception>
        public void AddTodo(string title, Todo.TodoOption? option = null)
        {
            if (string.IsNullOrEmpty(title))
                return;

            if (TodoList.Any(t => t.Title == title))
            {
#if DEBUG
                throw new ArgumentException($"같은 제목을 가진 Todo가 이미 존재합니다.");
#elif RELEASE
                return;
#endif
            }

            _currentTodo = new Todo() { Title = title };

            if (option != null)
                _currentTodo.Option = option;

            TodoList.Add(_currentTodo);
            _currentTodo = null;
        }

        /// <summary>
        /// 현재 TodoList를 저장한다.
        /// </summary>
        private void SaveTodoList()
        {
            string doc = MethodBase.GetCurrentMethod().Name;

            string fileName = FILE_NAME_FORMAT.Replace(FILE_NAME_PRE_FLAG , "todo")
                                              .Replace(FILE_NAME_DATE_FLAG, CurrentDate.ToString(FILE_NAME_DATE_FORMAT));
            string fileFullName = Path.Combine(SAVE_FOLDER, fileName);

            XmlElement root = XmlHelper.NewRoot();
            foreach (Todo todo in TodoList)
            {
                // Title
                XmlElement title = XmlHelper.CreateElement(nameof(Todo.Title));
                XmlAttribute titleAttribute = XmlHelper.CreateAttribute(nameof(Todo.Title));
                titleAttribute.Value = todo.Title;
                title.Attributes.Append(titleAttribute);

                // IsDone
                XmlNode isDone = XmlHelper.CreateElement(nameof(Todo.IsDone));
                isDone.InnerText = todo.IsDone.ToString();
                title.AppendChild(isDone);

                if (todo.Option != null)
                {
                    // Option
                    XmlElement option = XmlHelper.CreateElement(nameof(Todo.Option));

                    // Description
                    string dst = string.IsNullOrEmpty(todo.Option.Description) ? string.Empty : todo.Option.Description;
                    XmlNode description = XmlHelper.CreateElement(nameof(Todo.TodoOption.Description));
                    description.InnerText = dst;
                    option.AppendChild(description);

                    // DoubleCheck
                    XmlNode doubleCheck = XmlHelper.CreateElement(nameof(Todo.TodoOption.DoubleCheck));
                    doubleCheck.InnerText = todo.Option.DoubleCheck.ToString();
                    option.AppendChild(doubleCheck);

                    // Start
                    string startDate = todo.Option.Start.ToString("yyyy-MM-dd");
                    XmlNode start = XmlHelper.CreateElement(nameof(Todo.TodoOption.Start));
                    start.InnerText = startDate;
                    option.AppendChild(start);

                    // End
                    string endDate = todo.Option.End.ToString("yyyy-MM-dd");
                    XmlNode end = XmlHelper.CreateElement(nameof(Todo.TodoOption.End));
                    end.InnerText = endDate;
                    option.AppendChild(end);

                    // append option
                    title.AppendChild(option);
                }

                root.AppendChild(title);
            }
            
            if (!XmlHelper.TryCreate(fileFullName))
            {
                Log.Error(LOG_TYPE, doc, $"\"{fileFullName}\" 파일을 생성하지 못했습니다. TodoList를 저장하지 못했습니다.");
                return;
            }
        }

        /// <summary>
        /// TodoList 불러오기를 시도한다.
        /// </summary>
        /// <param name="date">불러올 날짜</param>
        /// <returns>불러오기에 성공했다면 true, 그렇지 않다면 false</returns>
        private bool TryLoadTodoList(DateTime date)
        {
            string currDir  = Environment.CurrentDirectory;
            string dateStr  = date.ToString("yyyyMMdd");
            string prevName = "todo";

            string fileName = $"{prevName}_{dateStr}.xml";
            string fileFullName = Path.Combine(currDir, "todo", fileName);

            TodoList.Clear();

            try
            {
                XmlHelper.Load(fileFullName);
            }
            catch
            {
                return false;
            }

            // 선택한 날짜의 TodoList를 불러온다
            Stack<string> xPathStack = new Stack<string>(["/root", "/Title"]);
            if (!XmlHelper.TryReadList($"/root/Title", out XmlNodeList? list) || list == null)
                return false;
            
            // 불러온 TodoList를 'Todo' 객체 형식에 맞게 값을 삽입한다.
            // @yoon 2025.06.26
            // 하드코딩 된 코드.. XmlHelper와 더불어 수정 필요.
            foreach (XmlNode node in list)
            {
                string? title = node.Attributes?.GetNamedItem("Title")?.Value;

                if (string.IsNullOrEmpty(title))
                    continue;

                // add Todo
                Todo todo = new Todo() { Title = title };
                TodoList.Add(todo);

                #region set todo
                string header      = $"/root/Title[@Title='{title}']";
                string isDoneXPath = $"{header}/IsDone";
                string optionXPath = $"{header}/Option";

                // set IsDone
                if (XmlHelper.TryRead(isDoneXPath, out XmlNode? isDoneResult) && isDoneResult != null)
                    todo.IsDone = bool.Parse(isDoneResult.InnerText);

                // 만약 option을 찾을 수 없다면 건너뛴다.
                if (!XmlHelper.TryRead(optionXPath, out XmlNode? optionResult) || isDoneResult == null)
                    continue;
                #endregion

                #region set todo option
                string descriptionXPath = $"{optionXPath}/Description";
                string doubleCheckXPath = $"{optionXPath}/DoubleCheck";
                string startXPath       = $"{optionXPath}/Start";
                string endXPath         = $"{optionXPath}/End";
                Todo.TodoOption option = new Todo.TodoOption();

                if (XmlHelper.TryRead(descriptionXPath, out XmlNode? descResult) && descResult != null)
                    option.Description = descResult.InnerText;
                if (XmlHelper.TryRead(doubleCheckXPath, out XmlNode? dcResult) && dcResult != null)
                    option.DoubleCheck = bool.Parse(dcResult.InnerText);
                if (XmlHelper.TryRead(startXPath, out XmlNode? startResult) && startResult != null)
                    option.Start = DateTime.Parse(startResult.InnerText);
                if (XmlHelper.TryRead(endXPath, out XmlNode? endResult) && endResult != null)
                    option.End = DateTime.Parse(endResult.InnerText);

                todo.Option = option;
                #endregion
            }

            return true;
        }

        /// <summary>
        /// <seealso cref="MainForm.mcMain"/>의 <seealso cref="MonthCalendar.DateChanged"/>이벤트와 연결되는 메서드.
        /// </summary>
        /// <param name="sender"><seealso cref="MonthCalendar"/></param>
        /// <param name="e"><seealso cref="MonthCalendar.DateChanged"/></param>
        private void ChangeDate(object? sender, DateRangeEventArgs e)
        {
            if (sender is not MonthCalendar mc)
#if DEBUG
                throw new ArgumentException($"{nameof(sender)}가 {nameof(MonthCalendar)} 형식이 아닙니다.");
#elif RELEASE
                return;
#endif
            SaveTodoList();
            LoadTodoList(sender, e);
            ChangeCurrentDate(sender, e);
        }

        /// <summary>
        /// TodoList를 불러온다.
        /// </summary>
        /// <param name="sender"><seealso cref="MonthCalendar"/></param>
        /// <param name="e"><seealso cref="MonthCalendar.DateChanged"/></param>
        /// <exception cref="ArgumentException">
        /// Debug  : 모드에서 <paramref name="sender"/>가 <seealso cref="MonthCalendar"/>형식이 아닐 시.
        /// Release: 모드에서 무시하고 return.
        /// </exception>
        private void LoadTodoList(object? sender, DateRangeEventArgs e)
        {
            if (sender is not MonthCalendar mc)
#if DEBUG
                throw new ArgumentException($"{nameof(sender)}가 {nameof(MonthCalendar)} 형식이 아닙니다.");
#elif RELEASE
                return;
#endif
            DateTime date = mc.SelectionStart;
            if (!TryLoadTodoList(date))
                return;
        }

        /// <summary>
        /// <seealso cref="CurrentDate"/>를 수정한다.
        /// </summary>
        /// <param name="sender"><seealso cref="MainForm.mcMain"/></param>
        /// <param name="e"><seealso cref="MonthCalendar.DateChanged"/></param>
        /// <exception cref="ArgumentException">
        /// Debug  : 모드에서 <paramref name="sender"/>가 <seealso cref="MonthCalendar"/>형식이 아닐 시.
        /// Release: 모드에서 무시하고 return.
        /// </exception>
        private void ChangeCurrentDate(object? sender, DateRangeEventArgs e)
        {
            if (sender is not MonthCalendar mc)
#if DEBUG
                throw new ArgumentException($"{nameof(sender)}가 {nameof(MonthCalendar)} 형식이 아닙니다.");
#elif RELEASE
                return;
#endif

            CurrentDate = mc.SelectionStart;
        }
    }
}
