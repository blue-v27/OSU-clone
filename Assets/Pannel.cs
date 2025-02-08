using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pannel : MonoBehaviour
{
    public static bool PannelhasBeenDestroyed;
    void Start()
    {
        PannelhasBeenDestroyed = false;
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = 1f;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 1f;
            gameObject.SetActive(false);
            PannelhasBeenDestroyed = true;
        }
    }
}
