using RtmpSharp.IO;
using System;
namespace LegendaryReplays.Riot
{
    [Serializable]
    [SerializedName("com.riotgames.team.TeamId")]
    public class TeamId
    {
        [SerializedName("fullId")]
        public String FullId { get; set; }
    }
}