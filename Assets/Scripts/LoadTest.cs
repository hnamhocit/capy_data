using UnityEngine;
using Data.Socket;
using System.Threading.Tasks;
using Data.Controllers;
using Newtonsoft.Json;

public class LoadTest : MonoBehaviour
{
    private SocketManager socketManager;
    private PlayerController playerController;

    void Awake()
    {
        var _socketManager = new SocketManager();
        socketManager = _socketManager;
        playerController = new PlayerController(_socketManager);
    }

    // Start is called before the first frame update
    async Task Start()
    {
        try
        {
            await socketManager.Init("DEBUG1");

            var response = await playerController.GetProfile();

            Debug.Log($"Full Battle Maps Response JSON: {Newtonsoft.Json.JsonConvert.SerializeObject(response, Formatting.Indented)}");
        }
        catch (System.Exception ex)
        {
            Debug.Log(ex.ToString());
            throw;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
