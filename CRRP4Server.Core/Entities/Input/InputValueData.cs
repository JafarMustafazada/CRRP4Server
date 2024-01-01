namespace CRRP4Server.Core.Entities.Input;

public class InputValueData : BaseEntity
{
    public int InputDataId { get; set; }

    // Structure //
    public string Value { get; set; }
    public string Name { get; set; }

    // Reletaion //
    public InputData? InputData { get; set; }
}
