using Aron.OpenLoopMiner.Models;
using Aron.OpenLoopMiner.Services;
using Microsoft.AspNetCore.Authorization;

namespace Aron.OpenLoopMiner.Minimal
{
    public static class MinerAPI
    {
        public static WebApplication UseMinerAPI(this WebApplication app)
        {

            app.MapGet("/api/Miner/GetMinerRecord", [Authorize] (MinerRecord minerRecord) =>
            {
                var options = MyJsonContext.Default.MinerRecord.Options;
                return Results.Json(minerRecord, options);
            });


            return app;
        }
    }
}
