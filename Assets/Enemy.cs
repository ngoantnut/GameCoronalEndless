using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Enemy : MonoBehaviour
{
    public GameObject enemy;
    //Giới hạn tọa độ quái xuất hiện
    public float maxX;
    public float maxY;
    public float minX;
    public float minY;
    public float timeEnemySpam;
    public float timeSpam;
   // public ScoreManager sc;

    // Update is called once per frame
    void Update()
    {

        if (Time.time > timeSpam)
        {
            Spam();
            timeSpam = Time.time + timeEnemySpam;
        }
    }
    void Spam()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(enemy, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
