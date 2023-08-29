using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceDown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(0,-10,0),ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
