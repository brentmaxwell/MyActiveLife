using MyActiveLife.Apis.Weather.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Apis.Weather.Entities
{
    public class SkyCondition
    {
        /// <summary>
        /// up to four levels of sky cover and base can be reported under the sky_conditions field; OVX present when vert_vis_ft is reported. 
        /// </summary>
        [JsonProperty("sky_cover")]
        public SkyCoverEnum? SkyCover { get; set; }

        /// <summary>
        /// cloud_base_ft_agl - height of cloud base in feet AGL. Up to four levels can be reported under the sky_conditions field. A value exists when the corresponding sky_cover='FEW','SCT','BKN', 'OVC'
        /// </summary>
        [JsonProperty("cloud_base_ft_agl")]
        public int? CloudBase { get; set; }
    }
}
