using System.Xml;
using System.Xml.Serialization;

namespace CleantosafeAssetsManager
{
    /*
     *  ===========================================================================
     *  작성자     : @yoon
     *  최초 작성일: 2025.06.22
     *  
     *  < 목적 >
     *  - CleantosafeAssetsManager의 Todo 자료를 정의한다.
     *  
     *  < TODO >
     *  
     *  < History >
     *  2025.06.22 @yoon
     *  - 최초 작성
     *  ===========================================================================
     */

    public class Todo
    {
        // ====================================================================
        // INNER-CLASS
        // ====================================================================

        public class TodoOption
        {
            /// <summary>
            /// 상세 설명
            /// </summary>
            [XmlAttribute("Description", typeof(string))]
            public string? Description { get; set; }
            /// <summary>
            /// 더블 체크 여부
            /// </summary>
            [XmlAttribute("DoubleCheck", typeof(bool))]
            public bool DoubleCheck { get; set; }
            /// <summary>
            /// 시작 날짜
            /// </summary>
            [XmlAttribute("Start", typeof(DateTime))]
            public DateTime Start { get; set; }
            /// <summary>
            /// 종료 날짜
            /// </summary>
            [XmlAttribute("End", typeof(DateTime))]
            public DateTime End { get; set; }

            public TodoOption() { }

            /// <summary>
            /// TodoOption 설정
            /// </summary>
            /// <param name="xml">Todo option xml</param>
            [Obsolete($"@yoon {nameof(Generalibrary.Xml.XmlCollection.XmlElement)} 형식이 사용되지 않음.")]
            public TodoOption(Generalibrary.Xml.XmlCollection.XmlElement xml)
            {
                if (xml.Child == null || xml.Child.Count == 0)
                    return;

                // set Description
                if (xml.Child.TryGetElement(nameof(Description), out var description))
                    this.Description = description!.Value;
                // set DoubleCheck
                if (xml.Child.TryGetElement(nameof(DoubleCheck), out var doubleCheckRaw) && 
                    doubleCheckRaw!.TryGetValue<bool>(out bool doubleCheck))
                    this.DoubleCheck = doubleCheck;
                // set Start
                if (xml.Child.TryGetElement(nameof(Start), out var startRaw) &&
                    startRaw!.TryGetValue<DateTime>(out DateTime start))
                    this.Start = start;
                // set End
                if (xml.Child.TryGetElement(nameof(End), out var endRaw) &&
                    endRaw!.TryGetValue<DateTime>(out DateTime end))
                    this.End = end;
            }

            /// <summary>
            /// TodoOption 설정
            /// </summary>
            /// <param name="description">상세 설명</param>
            /// <param name="doubleCheck">더블 체크 여부</param>
            /// <param name="start">시작 날짜</param>
            /// <param name="end">종료 날짜</param>
            public TodoOption(string? description, bool doubleCheck, DateTime start, DateTime end)
            {
                Description = description;
                DoubleCheck = doubleCheck;
                Start = start;
                End = end;
            }
        }


        // ====================================================================
        // PROPERTIES
        // ====================================================================

        /// <summary>
        /// 제목
        /// </summary>
        [XmlAttribute("Title", typeof(string))]
        public required string Title { get; set; }
        /// <summary>
        /// 완료 여부
        /// </summary>
        [XmlAttribute("IsDone", typeof(bool))]
        public bool IsDone { get; set; } = false;

        /// <summary>
        /// 옵션
        /// </summary>
        [XmlAttribute("Option", typeof(TodoOption))]
        public TodoOption? Option { get; set; } = null;


        // ====================================================================
        // CONSTRUCTORS
        // ====================================================================

        public Todo() { }

        [Obsolete($"@yoon {nameof(Generalibrary.Xml.XmlCollection.XmlElement)} 형식이 사용되지 않음.")]
        public Todo(Generalibrary.Xml.XmlCollection.XmlElement xml)
        {
            if (string.IsNullOrEmpty(Title))
                throw new ArgumentNullException($"\"{nameof(Title)}\"이 공백 혹은 null 입니다.");

            if (xml.Child == null || xml.Child.Count == 0)
                throw new ArgumentNullException($"\"{Title}\" 제목의 Todo가 존재하지 않습니다.");

            // set IsDone
            if (!xml.Child.TryGetElement(nameof(IsDone), out var isDone))
                throw new ArgumentNullException(($"\"{Title}\" Todo에 \"{nameof(IsDone)}\" 요소가 존재하지 않습니다."));
            // set Option
            if (!xml.Child.TryGetElement(nameof(Option), out var option))
                throw new ArgumentNullException(($"\"{Title}\" Todo에 \"{nameof(Option)}\" 요소가 존재하지 않습니다."));
        }

        /// <summary>
        /// Todo 설정
        /// </summary>
        /// <param name="title">제목</param>
        /// <param name="isDone">완료 여부</param>
        /// <param name="option">옵션</param>
        public Todo(string title, bool isDone, TodoOption? option)
        {
            Title = title;
            IsDone = isDone;
            Option = option;
        }
    }
}
