namespace CRRP4Server.Core.Entities.Event;

public class EventTypeData : BaseEntity
{
    // Structure //
    public string Name { get; set; }

    // Reletaion //
    public IEnumerable<EventData>? EventDatas { get; set; }
}
