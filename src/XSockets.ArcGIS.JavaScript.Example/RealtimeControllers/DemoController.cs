using XSockets.Core.XSocket;
using XSockets.Core.XSocket.Helpers;

namespace XSockets.ArcGIS.JavaScript.Example.RealtimeControllers
{
    public class DemoController : XSocketController
    {

        public void OnMyDemoClassMessage(Coordinate entity)
        {
            this.SendToAllExceptMe(entity, "onmydemoclassmessage");
        }
        public class Coordinate
        {
            public string XMax { get; set; }
            public string YMax { get; set; }
            public string XMin { get; set; }
            public string YMin { get; set; }
        }
    }
}