using Newtonsoft.Json;

namespace Data.Controllers
{
    public class IResponse<T>
    {
        [JsonProperty("code")] // Tên thuộc tính trong JSON là "code"
        public int code; // Tên thuộc tính C# là "code"

        [JsonProperty("msg")] // Tên thuộc tính trong JSON là "msg"
        public string msg; // Tên thuộc tính C# là "msg"

        [JsonProperty("data")] // Tên thuộc tính trong JSON là "data"
        public T data; // Tên thuộc tính C# là "data"


    }
}
