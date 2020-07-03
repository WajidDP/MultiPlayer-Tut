using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connect : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        print("Connecting to Server");
        PhotonNetwork.NickName = MasterManager.GameSettings.NickName;
        PhotonNetwork.GameVersion = MasterManager.GameSettings.GameVersion; ;
        PhotonNetwork.ConnectUsingSettings();
        
    }

    // Update is called once per frame

    public override void OnConnectedToMaster() 
    {
        print("Connected to Server");
        print("Your connect as NickName : "+PhotonNetwork.LocalPlayer.NickName);
    }
    public override void OnDisconnected(DisconnectCause cause)
    {
        print("Connecting to failed caused by : "+cause);
    }
}
