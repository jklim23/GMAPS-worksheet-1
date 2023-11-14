using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpToHeight : MonoBehaviour
{
    public float Height = 1f;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Jump()
    {
        
        //float a = Physics.gravity.y;
        //float vSq = 0;
        //float uSq = vSq - 2 * a * Height;

        //float u = Mathf.Sqrt(uSq);
        //rb.velocity = new Vector3(0, u, 0);

        float jumpForce = Mathf.Sqrt(-2 * Physics2D.gravity.y * Height);    
        rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();


        }
    }
}

