using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmRotation : MonoBehaviour
{
    public GameObject gameObject;

    // Update is called once per frame
    void Update()
    {
        Quaternion NewRot = gameObject.transform.rotation;
        NewRot *= Quaternion.Euler(43, 90, -90);
        transform.rotation = NewRot;
    }
}
