using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool IsCaptain = true;
    public Player OtherPlayer;

   
    void FixedUpdate()
    {
        if (IsCaptain)
        {
            //6b part 1 
            //DebugExtension.DebugArrow(transform.position, OtherPlayer.transform.position - transform.position, Color.black);
            //DebugExtension.DebugArrow(transform.position, transform.forward, Color.blue);

            //float angle = // Your code here
            //Debug.Log(angle);

            //6d part 1
            Debug.Log(AngleToPlayer());


        }
    }

    float Magnitude(Vector3 vector)
    {
         return (float)Math.Sqrt(vector.x * vector.x + vector.y * vector.y + vector.z * vector.z);
    }

    Vector3 Normalise(Vector3 vector)
    {
        float mag = Magnitude(vector);
        vector.x /= mag;
        vector.y /= mag; 
        vector.z /= mag;
        return vector;
    }

    float Dot(Vector3 vectorA, Vector3 vectorB)
    {
        return (vectorA.x * vectorB.x + vectorA.y * vectorB.y + vectorA.z * vectorB.z);
    }

    float AngleToPlayer()
    {
        Vector3 PlayerPOS = transform.position;
        Vector3 OtherPlayerPOS = OtherPlayer.transform.position;

        float angle = math.acos(Dot(Normalise(transform.forward), Normalise(OtherPlayerPOS))/
        (Magnitude(Normalise(transform.forward))) * Magnitude(Normalise(OtherPlayerPOS))) * Mathf.Rad2Deg;

        DebugExtension.DebugArrow(PlayerPOS, OtherPlayerPOS - PlayerPOS, Color.black);
        DebugExtension.DebugArrow(PlayerPOS, transform.forward, Color.blue);

        return angle;
    }   
    

} 
