using CRRP4Server.Core.Entities.GameStatic;

namespace CRRP4Server.Core.Entities.Input;

public class InputData : BaseEntity
{
    public int GameDataId { get; set; }
    public int InputTypeDataId { get; set; }
    public int PlayerDataId { get; set; }

    // Structure //
    //public DateTime? InputTime { get; set; }

    // Reletaion //
    public GameData? GameData { get; set; }
    public InputTypeData? InputTypeData { get; set; }
    public PlayerData? PlayerData { get; set; }
    public IEnumerable<InputValueData>? InputValueDatas { get; set; }
}
