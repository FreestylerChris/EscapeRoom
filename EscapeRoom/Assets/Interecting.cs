using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interecting : MonoBehaviour
{
    public GameObject Clone;
    public GameObject Object;
    public Rigidbody Rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Rigidbody.constraints = RigidbodyConstraints.None;
        }
    }
}
