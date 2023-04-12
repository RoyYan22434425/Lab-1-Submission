using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ScoreManager : MonoBehaviour, IDataPersistence
{
    public static ScoreManager scoremanager;
    public TextMeshProUGUI scoreUI;
    int totalscore = 0;

    private void Awake()
    {
        if (scoremanager == null)
        {
            scoremanager = this;
        }
    }

    private void Start()
    {
        scoreUI.text = "Score: " + totalscore.ToString();
    }

    public void UpdateScore(int score)
    {
        totalscore += score;
        Debug.Log(totalscore);
        scoreUI.text = "Score: " + totalscore.ToString();
    }

    public void SaveData(ref Data data)
    {
        data.score = this.totalscore;
    }

    public void LoadData(Data data)
    {
        this.totalscore = data.score;
    }
}
