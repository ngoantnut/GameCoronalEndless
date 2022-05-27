using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    

    public float backgroundSpeed;
    public Renderer bgrenderer; 
    // Update is called once per frame
    void Update()
    {
        bgrenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);
      
    }
}
