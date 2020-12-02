using System;
using System.Net.NetworkInformation;
using System.Text;

namespace DroneMonitor.Visualization.Models {
    public static class Stuff {
        public const string GoogleMapsApiKey = "AIzaSyAmO6pIPTz0Lt8lmYZEIAaixitKjq-4WlB"; //Get Api Key

        public static bool PingNetwork(string hostNameOrAddress) {
            bool pingStatus;

            using (var p = new Ping()) {
                var buffer = Encoding.ASCII.GetBytes("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
                int timeout = 4444; // 4s

                try {
                    var reply = p.Send(hostNameOrAddress, timeout, buffer);
                    pingStatus = reply.Status == IPStatus.Success;
                }
                catch (Exception) {
                    pingStatus = false;
                }
            }

            return pingStatus;
        }
    }
}
