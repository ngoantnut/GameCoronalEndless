using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject coin;
    //Giới hạn tọa độ quái xuất hiện
    public float maxX1;
    public float maxY1;
    public float minX1;
    public float minY1;
    public float timeEnemySpam1;
    public float timeSpam1;
   

    // Update is called once per frame
    void Update()
    {

        if (Time.time > timeSpam1)
        {
            SpamCoin();
            timeSpam1 = Time.time + timeEnemySpam1;

        }
    
    }
    void SpamCoin()
    {
        float randomX = Random.Range(minX1, maxX1);
        float randomY = Random.Range(minY1, maxY1);

        Instantiate(coin, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
