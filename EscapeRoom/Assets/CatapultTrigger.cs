using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatapultTrigger : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject Object;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.isKinematic = false;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            HingeJoint HTD;
                HTD = Object.GetComponent<HingeJoint>();
                Destroy(HTD);
         
        }
    }
}
