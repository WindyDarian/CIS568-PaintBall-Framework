using UnityEngine;
using System.Collections;

public class PCNetwork : Photon.PunBehaviour
{
    // This is for Paint Ball networking at PC
    //     if you are looking for LOOK-1.b, please refer to PCNetwork_Cube.cs 
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings("0.1");
    }
    void OnGUI()
    {
        GUILayout.Label(PhotonNetwork.connectionStateDetailed.ToString());
    }
    public override void OnJoinedLobby()
    {
        PhotonNetwork.CreateRoom(null);
    }

    public override void OnPhotonJoinRoomFailed(object[] codeAndMsg)
    {
        base.OnPhotonJoinRoomFailed(codeAndMsg);
    }
    public override void OnCreatedRoom()
    {
        base.OnCreatedRoom();
    }
}