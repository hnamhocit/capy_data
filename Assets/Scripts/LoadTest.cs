using System.Threading.Tasks;
using Data.Controllers;
using Data.Socket;
using UnityEngine;

public class LoadTest : MonoBehaviour
{
    private PlayerController playerController;

    void Awake()
    {
        playerController = new PlayerController();
    }

    // Start is called before the first frame update
    async Task Start()
    {
        try
        {
            await SocketManager.Instance.Init("DEBUG1");

            var res = await playerController.GetProfile();
            Debug.Log(res.data.username);
        }
        catch (System.Exception ex)
        {
            Debug.Log(ex.ToString());
            throw;
        }
    }

    // Update is called once per frame
    void Update() { }
}
