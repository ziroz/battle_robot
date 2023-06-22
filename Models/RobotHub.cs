using Microsoft.AspNet.SignalR;

namespace BattleRobot.Models
{
    public class RobotHub : Hub
    {
        public void SendRobotInformation(string robot)
        {
            // Envía la notificación a todos los clientes excepto al que envió el mensaje
            Clients.Others.ReceiveNotification(robot);
        }
    }
}