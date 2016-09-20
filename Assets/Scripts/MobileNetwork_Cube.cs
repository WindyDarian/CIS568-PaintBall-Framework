using UnityEngine;

public class MobileNetwork_Cube : Photon.PunBehaviour
{
    // TODO-1.b: write any functions needed to establish connection
    //   and join a room 


    void OnGUI()
    {
        GUILayout.Label(PhotonNetwork.connectionStateDetailed.ToString());
    }

    //public override void OnJoinedRoom()
    //{
    //    //TODO-1.c: use PhotonNetwork.Instantiate to create a "PhoneCube" across the network
    //    var cube =
    //    GetComponent<GyroController>().ControlledObject = cube;
    //}


}
