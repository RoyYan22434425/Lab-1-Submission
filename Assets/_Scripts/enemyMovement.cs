using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public Transform Player;
    int moveSpeed = 3;
    int maxDist = 15;
    int minDist = 2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player);
 
         if (Vector3.Distance(transform.position, Player.position) >= minDist)
         {
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
         }
    }
}
