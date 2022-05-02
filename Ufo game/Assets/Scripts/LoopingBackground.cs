using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    public float backgrondSpeed;
    public Renderer backgroundRenderer;
  
   
    // Update is called once per frame
    void Update()
    {
        backgroundRenderer.material.mainTextureOffset += new Vector2(backgrondSpeed * Time.deltaTime, 0f);
    }
}
