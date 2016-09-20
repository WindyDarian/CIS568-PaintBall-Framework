﻿using UnityEngine;
using System.Collections;

// LOOK-1.b: the parent class is not a basic MonoBehavior!
public class PCNetwork_Cube : Photon.PunBehaviour
{
    // LOOK-1.b: creating a room on PC
    void Start()
    {
        // Make sure "Auto-Join Lobby" was checked at 
        //   Assets-> Photon Unity Networking-> PhotonServerSettings
        //   so the application will automatically connect to Lobby
        //   and call OnJoinedLobby()
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

    // Look-1.b: We are not doing anything in the functions below
    // , but you may want to do something at the corresponding mobile function
    // On mobile client, use OnJoinedRoom() instead of OnCreatedRoom()
    public override void OnPhotonJoinRoomFailed(object[] codeAndMsg)
    {
        base.OnPhotonJoinRoomFailed(codeAndMsg);
    }
    public override void OnCreatedRoom()
    {
        base.OnCreatedRoom();
    }
}