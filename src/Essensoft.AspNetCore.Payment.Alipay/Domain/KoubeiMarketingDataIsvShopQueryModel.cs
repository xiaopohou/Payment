using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingDataIsvShopQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataIsvShopQueryModel : AlipayObject
    {
        /// <summary>
        /// 门店ID列表（单次最多查询100个门店）
        /// </summary>
        [JsonProperty("shop_ids")]
        [XmlArray("shop_ids")]
        [XmlArrayItem("string")]
        public List<string> ShopIds { get; set; }
    }
}
