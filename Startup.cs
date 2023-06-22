using Owin;

namespace BattleRobot
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var signalRConnection = "Endpoint=https://signalr-jackgold.service.signalr.net;AccessKey=DcZaHo9RjLLm6+3HLnPedcCPI7A9I6idaPfhIaXCRHM=;Version=1.0;";
            app.MapAzureSignalR("RobotWar", options =>
            {
                options.ConnectionString = signalRConnection;
            });

        }
    }
}