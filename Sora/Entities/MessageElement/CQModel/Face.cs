using Newtonsoft.Json;
using Sora.Converter;

namespace Sora.Entities.MessageElement.CQModel
{
    /// <summary>
    /// QQ 表情
    /// </summary>
    public struct Face
    {
        #region 属性

        /// <summary>
        /// 纯文本内容
        /// </summary>
        [JsonConverter(typeof(StringConverter))]
        [JsonProperty(PropertyName = "id")]
        public int Id { get; internal set; }

        #endregion
    }
}