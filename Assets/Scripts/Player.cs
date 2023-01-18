using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Photon.Pun;

public class Player : MonoBehaviour
{
    public LayerMask Ground;
    private NavMeshAgent myAgent;
   


    PhotonView view;

     void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
        view = GetComponent<PhotonView>();
        

    }

    private void Update()
    {
        if (view.IsMine)
        {
            
            
                if (Input.GetMouseButtonDown(0))
                {
                    Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
                    RaycastHit hitInfo;

                    if (Physics.Raycast(myRay, out hitInfo, 100, Ground))
                    {
                        myAgent.SetDestination(hitInfo.point);
                    }

                

            }
            
        }
    }

}
