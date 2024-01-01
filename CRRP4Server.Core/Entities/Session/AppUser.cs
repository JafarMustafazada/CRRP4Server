using CRRP4Server.Core.Entities.Action;
using CRRP4Server.Core.Entities.Event;
using Microsoft.AspNetCore.Identity;

namespace CRRP4Server.Core.Entities.Session;

public class AppUser : IdentityUser
{
    // Structure //
    public string NickName { get; set; } = "Newbie";
    public string TemporaryToken { get; set; }

    // Reletaion //
    public IEnumerable<SessionPlayerData>? SessionPlayerDatas { get; set; }
    public IEnumerable<ActionData> ActionDatas { get; set; }
    public IEnumerable<EventData>? EventDatas { get; set; }
}
