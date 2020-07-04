using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace MoveShape.Hubs
{
    public class ShapeHub : Hub
    {
        public async Task MoveShape(string id, int x , int y,string color, string userchar)
        {
            await Clients.Others.SendAsync("shapeMoved", id, x, y,color, userchar);
        }

        public async Task FireShape(string id, int x, int y)
        {
            await Clients.Others.SendAsync("shapeFired", id, x, y);
        }
    }
}
