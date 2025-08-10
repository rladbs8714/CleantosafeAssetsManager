using System.ComponentModel;

namespace Generalibrary.Xml
{
    /*
     *  ===========================================================================
     *  작성자     : @yoon
     *  최초 작성일: 2025.06.11
     *  
     *  < 목적 >
     *  - XML의 역직렬화 된 객체의 요소
     *  
     *  < TODO >
     *  - 
     *  
     *  < History >
     *  2025.06.11 @yoon
     *  - 최초 작성
     *  ===========================================================================
     */

    public partial class XmlCollection
    {
        public class XmlElement
        {

            // ====================================================================
            // FIELDS
            // ====================================================================

            /// <summary>
            /// 태그
            /// </summary>
            private string _tag;
            /// <summary>
            /// 부모 요소 (null이라면 최상위 계층)
            /// </summary>
            private XmlElement? _parent;


            // ====================================================================
            // PROPERTIES
            // ====================================================================

            /// <summary>
            /// 태그
            /// </summary>
            public string Tag => _tag;
            /// <summary>
            /// 값
            /// </summary>
            public string Value { get; set; } = string.Empty;
            /// <summary>
            /// 부모 요소 (null이라면 최상위 계층)
            /// </summary>
            public XmlElement? Parent => _parent;
            /// <summary>
            /// 자식 요소
            /// </summary>
            public XmlCollection Child { get; set; }



            // ====================================================================
            // CONSTRUCTORS
            // ====================================================================

            internal XmlElement(string tag, XmlElement? parent)
            {
                _tag = tag;
                _parent = parent;
                Child = new XmlCollection();
            }

            public XmlElement(string tag, string value, XmlElement? parent) : this(tag, parent)
            {
                Value = value;
            }

            public XmlElement(string tag, string value, XmlElement? parent, XmlCollection child) : this(tag, value, parent)
            {
                Child = child;
            }


            // ====================================================================
            // METHODS
            // ====================================================================

            /// <summary>
            /// <seealso cref="Value"/> 값을 <typeparamref name="T"/> 반환한다 <br />
            /// </summary>
            /// <typeparam name="T">TypeConverterAttribute가 있기를 희망하는 타입</typeparam>
            /// <returns>찾은 값</returns>
            /// <exception cref="IniDataException">IniData를 가져오던 중 오류가 발생했을 때</exception>
            /// <exception cref="NotSupportedException"><seealso cref="TypeConverter.ConvertFromString(string)"/>이 올바르게 작동하지 않았을 경우</exception>
            /// <exception cref="FormatException">찾은 값을 <see cref="T"/>로 변환할 수 없을 때</exception>
            public T GetValue<T>()
            {
                var converter = TypeDescriptor.GetConverter(typeof(T));
                if (converter == null)
                    throw new IniDataException($"{typeof(T)}에서 {nameof(TypeConverterAttribute)}를 찾을 수 없습니다.");

                try
                {
                    object? result = converter.ConvertFromString(Value);
                    if (result == null)
                        throw new FormatException($"{Value}를 {typeof(T)}로 변환할 수 없습니다.");

                    return (T)result;
                }
                catch (NotSupportedException)
                {
                    throw;
                }
            }

            /// <summary>
            /// <paramref name="key"/>로 값 찾기를 시도한다.<br />
            /// </summary>
            /// <typeparam name="T"><seealso cref="TypeConverterAttribute"/>가 있기를 희망하는 타입</typeparam>
            /// <param name="key">key</param>
            /// <param name="result">찾았다면 값, 그렇지 않다면 <see cref="default(T)"/></param>
            /// <returns>찾았다면 true, 그렇지 않다면 false</returns>
            public bool TryGetValue<T>(out T? result)
            {
                try
                {
                    result = GetValue<T>();
                }
                catch
                {
                    result = default(T);
                    return false;
                }

                return true;
            }
        }
    }
}
