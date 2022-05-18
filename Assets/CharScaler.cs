using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharScaler : MonoBehaviour
{
    public GameObject sphere;
    public Vector3 scaleChange, positionChange;

    void Awake()
    {
      

        scaleChange = new Vector3(0.001f, 0.001f, 0.001f);
        positionChange = new Vector3(0.0f, 0.0f, 0.0f);
    }

    void Update()
    {
        sphere.transform.localScale += scaleChange;
        sphere.transform.position += positionChange;

       
    }
}