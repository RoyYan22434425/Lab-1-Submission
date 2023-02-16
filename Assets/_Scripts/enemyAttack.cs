using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAttack : MonoBehaviour
{
    public playerHealth playerHealth;
    public int damage = 10;
    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "Player"){
            playerHealth.DamageTaking(damage);
        }
    }
}
