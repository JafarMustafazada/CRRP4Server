namespace CRRP4Server.Core.Entities.Action;

public class ActionValueData : BaseEntity
{
    public int ActionDataId { get; set; }

    // Structure //
    public string Value { get; set; }
    public string Name { get; set; }

    // Reletaion //
    public ActionData? ActionData { get; set; }
}
