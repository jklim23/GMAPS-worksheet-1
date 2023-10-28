using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool IsCaptain = true;
    public Player OtherPlayer;

    private void Start()
    {
        


    }
    private void Update()
    {
        //if (IsCaptain)
        //{
        //    Debug.Log(AngleToPlayer());
        //}

    }
    void FixedUpdate()
    {
        if (IsCaptain)
        {
            //6b arrow
            //DebugExtension.DebugArrow(transform.position, OtherPlayer.transform.position - transform.position, Color.black);
            //DebugExtension.DebugArrow(transform.position, transform.forward, Color.blue);

            //float angle = // Your code here
            //Debug.Log(angle);

            Debug.Log(AngleToPlayer());


        }
    }

    float Magnitude(Vector3 vector)
    {
         return (float)Math.Sqrt(vector.x * vector.x + vector.y * vector.y);
    }

    Vector3 Normalise(Vector3 vector)
    {
        return Vector3.Normalize(vector);
    }

    float Dot(Vector3 vectorA, Vector3 vectorB)
    {
        return (vectorA.x * vectorB.x + vectorA.y * vectorB.y);
    }

    float AngleToPlayer()
    {


        

        float angle = math.acos(Dot(transform.position , OtherPlayer.transform.position)/
        (Magnitude(transform.position) * Magnitude(OtherPlayer.transform.position))) * Mathf.Rad2Deg;

        DebugExtension.DebugArrow(transform.position, OtherPlayer.transform.position - transform.position, Color.black);
        DebugExtension.DebugArrow(transform.position, transform.forward, Color.blue);
        return angle;
    }


}
