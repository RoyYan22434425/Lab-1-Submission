using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Data
{
    public int score;
    public Vector3 playerPosition;

    
    public Data()
    {
        this.score = 0;
        this.playerPosition = new Vector3(0, 3.5f, 0);
    }
}
