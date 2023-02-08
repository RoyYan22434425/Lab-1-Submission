using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAttack : MonoBehaviour
{
    protected GameObject player;

    public virtual void Start(){
        player = FindObjectOfType<playerController>().gameObject;
    }
}
