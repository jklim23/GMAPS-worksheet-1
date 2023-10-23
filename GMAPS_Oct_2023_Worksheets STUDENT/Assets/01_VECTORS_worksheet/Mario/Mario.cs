using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mario : MonoBehaviour
{
    public Transform planet;
    public float force = 5f;
    public float gravityStrength = 5f;

    private Vector3 gravityDir, gravityNorm;
    private Vector3 moveDir;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        gravityDir = (planet.position - transform.position);
        moveDir = new Vector3( transform.position.y,-transform.position.x);
        moveDir = moveDir.normalized * -1.0f;

        rb.AddForce(new Vector2(force,0f));
        gravityNorm = gravityDir.normalized;
        rb.AddForce(gravityNorm * gravityStrength);

        float angle = Vector3.SignedAngle(planet.position,gravityDir,Vector3.forward);

        rb.MoveRotation(Quaternion.Euler(moveDir));


        DebugExtension.DebugArrow(new Vector3(0f,0f,0f), new Vector3(10f,10f,0f), Color.red);
    }
}


