using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator animRight;
 
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animRight.Play("Punch L");
        }
    }
}