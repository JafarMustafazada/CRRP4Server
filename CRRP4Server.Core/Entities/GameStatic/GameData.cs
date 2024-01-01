using CRRP4Server.Core.Entities.Event;
using CRRP4Server.Core.Entities.Input;
using CRRP4Server.Core.Entities.Session;

namespace CRRP4Server.Core.Entities.GameStatic;

public class GameData : BaseEntity
{
    // Sturucture //
    public int PlayerTurn { get; set; }
    public int Baraban { get; set; }
    public int MinBullets { get; set; }
    public int BulletTurn { get; set; }
    public int GameEvents { get; set; }

    // Params //
    public int PlayerCount { get; set; }
    public int MaxCards { get; set; }
    public int MaxBullets { get; set; }

    // Releation //
    public IEnumerable<PlayerData>? PlayerDatas { get; set; }
    public IEnumerable<CardData>? CardDatas { get; set; }
    public IEnumerable<InputData>? InputDatas { get; set; }
    public IEnumerable<SessionEventData>? SessionEventDatas { get; set; }
    public IEnumerable<SessionPlayerData>? GameSessionDatas { get; set; }
}
