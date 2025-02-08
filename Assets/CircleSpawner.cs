using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawner : MonoBehaviour
{
    public GameObject[] circle;
    int iniSPawn, circleId = 1;
    void Start()
    {
        
    }

    private void FixedUpdate() 
    {
        if(CircleScrippt.spawn)
        {
            Spawn(); 
        }

        Debug.DrawLine(circle[circleId].transform.position, circle[circleId].transform.position);
    }
    void Update()
    {
        GameObject myLine = new GameObject();
        myLine.AddComponent<LineRenderer>();
        float duration = 0.25f;
        LineRenderer lr = myLine.GetComponent<LineRenderer>();
        lr.SetWidth(0.1f, 0.1f);
        lr.SetPosition(0, circle[circleId].transform.position);
        lr.SetPosition(1, circle[circleId -1 ].transform.position);
        GameObject.Destroy(myLine, duration);
    }

    void Spawn()
    {   
        Instantiate(circle[circleId], circle[circleId].transform.position, Quaternion.identity);
        circleId ++;
        CircleScrippt.spawn = false;
    }
}
