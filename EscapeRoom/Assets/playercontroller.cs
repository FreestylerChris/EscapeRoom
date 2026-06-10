using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public Rigidbody rb;
    public float walkspeed = 1f;
    public float jumpforce = 1f;
    public int jumpcount = 0;
    public int jumps = 0;
    bool isgrounded;
    public ForceMode mode;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalinput = Input.GetAxis("Horizontal");
        float verticalinput = Input.GetAxis("Vertical");
        isgrounded = Physics.Raycast(transform.position, Vector3.down, 1.1f);
        if (isgrounded)
        {
            rb.AddForce(horizontalinput * walkspeed, 0, verticalinput * walkspeed);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0, jumpforce, 0, mode);
        }
        
        

    }
}
