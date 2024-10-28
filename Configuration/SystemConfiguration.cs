using System.Text.Json;
using System.Text.Json.Serialization;

namespace Configuration
{
    public class SystemConfiguration
    {
        public static string ThingsboardServer { get; set; } = "http://210.211.96.129:8088/";
        public static string AdminUsername { get; set; } = "khanh@rangdong.com.vn";
        public static string AdminPassword { get; set; } = "123456a@";
        public SystemConfiguration()
        {
        }
        
    }
}
