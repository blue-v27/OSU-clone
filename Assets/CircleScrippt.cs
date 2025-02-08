using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CircleScrippt : MonoBehaviour
{
    float time = 0.26f, cX, cY, bX, bY, maxAccValure = 100, maxScoreValue = 1701300, maxCurenetScoreValue;
    int scoreValue, spriteColor;
    SpriteRenderer spriteRenderer;
    bool hasSpawned;
    public static bool spawn;
    public GameObject Border, scoreText;
    void Start()
    {
        Invoke("removeCircle", time);
        spriteRenderer = GetComponent<SpriteRenderer>();

        spriteColor = Random.Range(0 , 3);

        if(spriteColor == 0)
            spriteRenderer.color = Color.cyan;
                else if (spriteColor == 1)
                    spriteRenderer.color = Color.blue;
                        else if (spriteColor == 2)
                            spriteRenderer.color = Color.magenta;
                                else if (spriteColor == 3)
                                    spriteRenderer.color = Color.green;

    }

    // Update is called once per frame
    void Update()
    {
        cX = gameObject.transform.localScale.x;
        cY = gameObject.transform.localScale.y;
        bX = Border.transform.localScale.x;
        bY = Border.transform.localScale.y;

        if(bX <= cX * 1.3 && bX >= cX * 0.7)
            scoreValue = 300;
                else if(bX > cX * 1.3)
                    scoreValue = 50;
                        else if(bX < cX * .7)
                            scoreValue = 100;

        maxCurenetScoreValue = maxScoreValue - ((300 * ScoreScript.combo) - ScoreScript.score);

        ScoreScript.acc = (maxCurenetScoreValue/maxScoreValue) * 100;

        if(Input.GetKeyDown(KeyCode.Space) && Pannel.PannelhasBeenDestroyed)
            SceneManager.LoadScene("SampleScene");
    }

    private void OnMouseDown() 
    {
        AddPoint();
    }

    private void OnMouseOver() 
    {
        if(Input.anyKey)
            AddPoint();
    }
    void AddPoint()
    {
        gameObject.SetActive(false);
        ScoreScript.combo++;
        ScoreScript.score += scoreValue * ScoreScript.combo;
        spawn = true;
        hasSpawned = true;
        SoundScript.PlaySound("hitSound");
    }
    void removeCircle()
    {
        gameObject.SetActive(false);
        if(!hasSpawned)
        {
            spawn = true;
            ScoreScript.combo = 1;
            //SoundScript.PlaySound("breakCombo");
        }   
    }
}
