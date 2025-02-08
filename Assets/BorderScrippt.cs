using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderScrippt : MonoBehaviour
{
    public float targetScale = 0.5f;
    float shrinkSpeed = 2f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject. transform. localScale = Vector3. Lerp(gameObject. transform. localScale, new Vector3(targetScale, targetScale, targetScale), Time. deltaTime*shrinkSpeed);
    }
}
