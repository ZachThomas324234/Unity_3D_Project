using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform targetObj;
    public Vector3 movement;
    public Rigidbody rb;
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = (targetObj.transform.position - transform.position).normalized;
        transform.LookAt(targetObj);
        rb.AddForce(movement * Speed);
    }
}
