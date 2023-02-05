using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class photonnet : MonoBehaviour
{
    public GameObject player;
    [SerializeField] private GameObject lobicamera;
   
    void Start()
    {
         PhotonNetwork.ConnectUsingSettings("1.0");
    }

 void OnJoinedLobby() {

    PhotonNetwork.JoinOrCreateRoom("room", new RoomOptions() { MaxPlayers = 10 }, TypedLobby.Default);
 }
void OnJoinedRoom() {

PhotonNetwork.Instantiate("Player", player.transform.position, Quaternion.identity, 0);
lobicamera.setActive(false);

}
}
