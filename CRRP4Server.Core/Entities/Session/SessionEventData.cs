using CRRP4Server.Core.Entities.Event;
using CRRP4Server.Core.Entities.GameStatic;

namespace CRRP4Server.Core.Entities.Session;

public class SessionEventData : BaseEntity
{
    public int GameDataId { get; set; }
    public int EventDataId { get; set; }

    // Reletaion //
    public GameData? GameData { get; set; }
    public EventData? EventData { get; set; }
}
