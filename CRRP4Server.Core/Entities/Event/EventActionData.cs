using CRRP4Server.Core.Entities.Action;

namespace CRRP4Server.Core.Entities.Event;

public class EventActionData : BaseEntity
{
    public int EventDataId { get; set; }
    public int ActionDataId { get; set; }

    // Reletaion //
    public EventData? EventData { get; set; }
    public ActionData? ActionData { get; set; }
}
