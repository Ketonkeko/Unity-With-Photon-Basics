using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{

public InputField createInput;
public InputField joinInput;

public void CreateRooms()
{
    PhotonNetwork.CreateRoom(createInput.text);
}

public void JoinRoom()
{
 PhotonNetwork.JoinRoom(joinInput.text);
 //PhotonNetwork.LoadLevel("Game");
}
public void OnPlayerEnteredRoom()
{
    PhotonNetwork.LoadLevel("Game");
}

}
