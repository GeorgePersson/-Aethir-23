using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectOnClick : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Effect;


    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Effect.SetActive(false);
            
        }
        else
        {
            Effect.SetActive(true);
        }


    }

}