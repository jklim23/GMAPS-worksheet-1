using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Unity.Mathematics;
using System;

public class SoccerPlayer : MonoBehaviour
{
    public bool IsCaptain = false;
    public SoccerPlayer[] OtherPlayers;
    public float rotationSpeed = 1f;

    float angle = 0f;

    private void Start()
    {
        OtherPlayers = FindObjectsOfType<SoccerPlayer>().Where(t => t != this).ToArray();
        //ForEachLoopToFindPlayers();
    }
    private void Update()
    {
        DebugExtension.DebugArrow(transform.position, transform.forward, Color.red);

        if (IsCaptain)
        {
            angle += Input.GetAxis("Horizontal") * rotationSpeed;
            transform.localRotation = Quaternion.AngleAxis(angle,Vector3.up);
            Debug.DrawRay(transform.position,transform.forward * 10f,Color.red);
            DrawVectors();
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

    //SoccerPlayer FindClosestPlayerDot()
    //{
    //    SoccerPlayer closest = null;

    //    return closest;
    //}

    void DrawVectors()
    {
        int i = 0;
        foreach (SoccerPlayer other in OtherPlayers)
        {
            //ray to point to captain
            Debug.DrawRay(transform.position, other.transform.position, Color.black);

            foreach (SoccerPlayer player in OtherPlayers)
            {
                Debug.DrawRay(player.transform.position, other.transform.position, Color.black);
            }

        i++;
        }
    }



    //qns 6b part 2
    private void ForEachLoopToFindPlayers()
    {
        OtherPlayers = FindObjectsOfType<SoccerPlayer>();
        SoccerPlayer[] temp = new SoccerPlayer[OtherPlayers.Length - 1];
        int i = 0;
        foreach (SoccerPlayer player in OtherPlayers)
        {
            if (player != this)
            {
                temp[i] = player;
                i++;
            }
        }

        OtherPlayers = temp;
    }
}


