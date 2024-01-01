namespace CRRP4Server.Core.Entities.GameStatic;

public class CardData : BaseEntity
{
    public int GameDataId { get; set; }

    // Structure //
    public int CardIndex { get; set; }
    public int Frequency { get; set; }

    // Reletaion //
    public GameData? GameData { get; set; }
    public IEnumerable<PlayerCardData>? PlayerCardDatas { get; set; }
}
