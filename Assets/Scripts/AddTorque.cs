using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTorque : MonoBehaviour
{
    Rigidbody body;
    [SerializeField] private float spinSpeed = 5f;


    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.left,spinSpeed*Time.deltaTime);
       // body.AddTorque(spinSpeed, 0, 0);
    }
}
