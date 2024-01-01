namespace CRRP4Server.Core.Entities.GameStatic;

public class PlayerCardData : BaseEntity
{
    public int PlayerDataId { get; set; }
    public int CardDataId { get; set; }

    // Reletaion //
    public PlayerData? PlayerData { get; set; }
    public CardData? CardData { get; set; }
}
