using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {


	void Start () {
		
	}
	

	void Update () {

        //server
		if(Input.GetKeyDown(KeyCode.S))
        {
            StartServer();
        }

        //client
        if (Input.GetKeyDown(KeyCode.C))
        {
            StartClient();
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            StartHost();
        }

        

    }

    public override void OnStartServer()
    {
        base.OnStartServer();
        Debug.Log("start server");
    }


    public override void OnStartHost()
    {
        base.OnStartHost();
        Debug.Log("start host");

    }

    public override void OnStartClient(NetworkClient client)
    {
        base.OnStartClient(client);
        Debug.Log("start client");
    }

    public override void OnServerDisconnect(NetworkConnection conn)
    {
        base.OnServerDisconnect(conn);
        Debug.Log("quelqu'un s'est déconnecté");
    }

    public override void OnClientDisconnect(NetworkConnection conn)
    {
        base.OnClientDisconnect(conn);
        Debug.Log("client disconnect");

    }


}
