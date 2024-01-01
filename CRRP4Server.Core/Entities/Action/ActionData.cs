using CRRP4Server.Core.Entities.Event;
using CRRP4Server.Core.Entities.Session;

namespace CRRP4Server.Core.Entities.Action;

public class ActionData : BaseEntity
{
    public int AppUserId { get; set; }
    public int ActionTypeDataId { get; set; }

    // Reletaion //
    public AppUser? AppUser { get; set; }
    public ActionTypeData? ActionTypeData { get; set; }
    public IEnumerable<ActionValueData>? ActionValueDatas { get; set; }
    public IEnumerable<EventActionData>? EventActionDatas { get; set; }
}
