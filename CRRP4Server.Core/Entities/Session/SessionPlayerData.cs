using CRRP4Server.Core.Entities.GameStatic;

namespace CRRP4Server.Core.Entities.Session;

public class SessionPlayerData : BaseEntity
{
    public int AppUserId { get; set; }
    public int GameDataId { get; set; }
    public int PlayerDataId { get; set; }

    // Reletaion //
    public AppUser? AppUser { get; set; }
    public GameData? GameData { get; set; }
    public PlayerData? PlayerData { get; set; }
}
