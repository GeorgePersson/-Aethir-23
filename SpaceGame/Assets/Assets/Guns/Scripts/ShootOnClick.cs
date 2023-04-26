using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootOnClick : MonoBehaviour
{
    // Start is called before the first frame update
    Animator shoot;

    void Start()
    {
        shoot = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shoot.SetTrigger("shoot");
        }
    }

}
