namespace CRRP4Server.Core.Entities.Input;

public class InputTypeData : BaseEntity
{
    // Structure //
    public string Name { get; set; }

    // Reletaion //
    public IEnumerable<InputData>? InputDatas { get; set; }
}
