using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayer : MonoBehaviour
{

    public float playerSpeed1;
    private Rigidbody2D rb;
    private Vector2 playerDirection;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        float directionX = Input.GetAxisRaw("Horizontal");

        playerDirection = new Vector2(directionX,0).normalized;
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(playerSpeed1 * playerDirection.x,0 );

    }
}

