namespace CRRP4Server.Core.Entities.GameStatic;

public class PlayerData : BaseEntity
{
    public int GameDataId { get; set; }

    // Structure //
    public int PlayerIndex { get; set; }
    public int HitPoints { get; set; }
    public int Coins { get; set; }
    public int Status { get; set; }

    // Reletaion //
    public GameData? GameData { get; set; }
    public IEnumerable<PlayerCardData>? PlayerCardDatas { get; set; }
}
