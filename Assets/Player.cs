using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;
    private bool pause;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        float directionX = Input.GetAxisRaw("Horizontal");
        playerDirection = new Vector2(directionX, directionY).normalized;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (pause)
                Time.timeScale = 1;
            else
                Time.timeScale = 0;
            pause =! pause;
        }
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(playerSpeed * playerDirection.x, playerSpeed * playerDirection.y);
       
    }
}
