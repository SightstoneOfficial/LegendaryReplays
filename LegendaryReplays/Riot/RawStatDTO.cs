using RtmpSharp.IO;
using System;
namespace LegendaryReplays.Riot
{
    [Serializable]
    [SerializedName("com.riotgames.platform.observer.domain.RawStatDTO")]
    public class RawStatDTO
    {
        [SerializedName("value")]
        public Double Value { get; set; }

        [SerializedName("statTypeName")]
        public String StatTypeName { get; set; }
    }
}