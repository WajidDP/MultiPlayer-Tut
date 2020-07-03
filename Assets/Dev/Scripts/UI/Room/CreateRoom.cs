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

    [SerializeField]
    private Transform _contentofRoomList;

    [SerializeField]
    public GameObject _roomListItemPerfab;

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
        GameObject room = Instantiate(_roomListItemPerfab,new Vector3(0,0,0),Quaternion.identity) as GameObject;
      
        room.transform.GetChild(0).GetComponent<Text>().text = _roomName.text.ToString();

        room.transform.parent = _contentofRoomList;
        room.GetComponent<RectTransform>().localScale = new Vector3 (1f, 1f, 1f);
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.Log("Room Creatation failed due to : " + message.ToString());
    }

}
