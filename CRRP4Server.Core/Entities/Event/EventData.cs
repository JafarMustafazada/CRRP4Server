using CRRP4Server.Core.Entities.Session;

namespace CRRP4Server.Core.Entities.Event;

public class EventData : BaseEntity
{
    public int AppUserId { get; set; }
    public int EventTypeDataId { get; set; }

    // Reletaion //
    public AppUser? AppUser { get; set; }
    public EventTypeData? EventTypeData { get; set; }
    public IEnumerable<EventActionData>? EventActionDatas { get; set; }
    public IEnumerable<SessionEventData>? SessionEventDatas { get; set; }
}
