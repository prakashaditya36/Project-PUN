using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerRed;
    public GameObject playerBlue;

    public GameObject panel;

    public GameObject blueButton;
    public GameObject redButton;


    private void Start()
    {
       
    }

    [PunRPC]
    public void OnClickRed()
    {
        Vector3 randomPostion = new Vector3(Random.Range(4,0), 1f, Random.Range(4,0));
        PhotonNetwork.Instantiate(playerRed.name, randomPostion, Quaternion.identity);
        redButton.SetActive(false);
        panel.SetActive(false);
        
        
    }

    [PunRPC]
    public void OnClickBlue()
    {
        Vector3 randomPostion = new Vector3(Random.Range(-4,0), 1f, Random.Range(-4,0));
        PhotonNetwork.Instantiate(playerBlue.name, randomPostion, Quaternion.identity);
        blueButton.SetActive(false);
        panel.SetActive(false);

    }

    public void Update()
    {
        
    }

    
}
