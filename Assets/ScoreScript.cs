using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    Text text;
    public static float score, combo, acc;
    void Start()
    {
        text = GetComponent<Text>();
        score = 0;
        combo = 1;
        acc = 0;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Score: " + score + " x " + combo + " Acc: " +  acc;
    }
}
