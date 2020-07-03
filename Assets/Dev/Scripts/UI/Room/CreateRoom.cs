using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateRoom : MonoBehaviourPunCallbacks
{

    [SerializeField]
    private Text _roomName;


    public void OnClick_CreateRoom() 
    {
        if (!PhotonNetwork.IsConnected)
            return;
        RoomOptions option = new RoomOptions();
        option.MaxPlayers = 4;
        PhotonNetwork.JoinOrCreateRoom(_roomName.text, option, typedLobby: default);


    }



    public override void OnCreatedRoom()
    {
        Debug.Log("Room Created");
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.Log("Room Creatation failed due to : " + message.ToString());
    }

}
