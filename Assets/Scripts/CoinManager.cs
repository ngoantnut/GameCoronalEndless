using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public static CoinManager instance;
    public Text textc;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        if(instance== null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    public void changeSroce(int coinValue)
    {
        score += coinValue;
        textc.text = "X" + score.ToString();
    }
}
