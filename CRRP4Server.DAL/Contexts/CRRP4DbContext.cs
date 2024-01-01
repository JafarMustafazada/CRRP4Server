using CRRP4Server.Core.Entities.Action;
using CRRP4Server.Core.Entities.Event;
using CRRP4Server.Core.Entities.GameStatic;
using CRRP4Server.Core.Entities.Input;
using CRRP4Server.Core.Entities.Session;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace CRRP4Server.DAL.Contexts;

public class CRRP4DbContext : IdentityDbContext
{


    public CRRP4DbContext(DbContextOptions options) : base(options)
    {
    }

    // Game //
    public DbSet<GameData> GameDatas { get; set; }
    public DbSet<CardData> CardDatas { get; set; }
    public DbSet<PlayerData> PlayerDatas { get; set; }
    public DbSet<PlayerCardData> PlayerCardDatas { get; set; }

    // Session //
    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<SessionEventData> SessionEventDatas { get; set; }
    public DbSet<SessionPlayerData> SessionPlayerDatas { get; set; }

    // Action //
    public DbSet<ActionData> ActionDatas { get; set; }
    public DbSet<ActionTypeData> ActionTypeDatas { get; set; }
    public DbSet<ActionValueData> ActionValueDatas { get; set; }

    // Event //
    public DbSet<EventData> EventDatas { get; set; }
    public DbSet<EventActionData> EventActionDatas { get; set; }
    public DbSet<EventTypeData> EventTypeDatas { get; set; }

    // Input //
    public DbSet<InputData> InputDatas { get; set; }
    public DbSet<InputTypeData> InputTypeDatas { get; set; }
    public DbSet<InputValueData> InputValueDatas { get; set; }
}
