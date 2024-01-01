namespace CRRP4Server.Core.Entities.Action;

public class ActionTypeData : BaseEntity
{
    // Structure //
    public string Name { get; set; }

    // Reletaion //
    public IEnumerable<ActionData>? ActionDatas { get; set; }
}
