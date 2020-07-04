using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace MoveShape.Hubs
{
    public class ShapeHub : Hub
    {
        public async Task MoveShape(string id, int x , int y,string color)
        {
            await Clients.Others.SendAsync("shapeMoved", id, x, y,color);
        }
    }
}
