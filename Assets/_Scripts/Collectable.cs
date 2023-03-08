using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public string nameCollectable;
    public int restoreHP;

    public Collectable(string name, int scorevalue, int restoreHPvalue)
    {
        this.nameCollectable = name;
        this.restoreHP = restoreHPvalue;
    }

    

    public void UpdateHealth()
    {
        PlayerManager.playermanager.player.GetComponent<playerHealth>().RestoreHealth(this.restoreHP);
    }
}
