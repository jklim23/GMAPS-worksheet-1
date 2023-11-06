using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HMatrix2D
{
    public float [,] entries { get; set; } = new float[3, 3];


    public HMatrix2D()
    {
        entries = new float[3, 3];
    }

    public HMatrix2D(float[,] multiArray)
    {

        for (int row = 0; row < 3; row++)
        {
             
            for(int col = 0; col < 3; col++)
            {
                entries[row,col] = multiArray[row,col];
            }
        }
    }

    public HMatrix2D(float m00, float m01, float m02,
             float m10, float m11, float m12,
             float m20, float m21, float m22)
    {
        //row 1 
        entries[0, 0] = m00;
        entries[0, 1] = m01;
        entries[0, 2] = m02;
        //row 2
        entries[1, 0] = m10;
        entries[1, 1] = m11;
        entries[1, 2] = m12;
        //row 3
        entries[2, 0] = m20;
        entries[2, 1] = m21;
        entries[2, 2] = m22;

    }
    public void setIdentity()
    {
        
        for (int y = 0; y < 3; y++)
        {
            for(int x = 0; x < 3; x++)
            {
                //if (x == y)
                //{   
                //    entries[x, y] = 1;
                //}
                //else
                //{
                //    entries[x, y] = 0;
                //}

                //ternary code
                entries[x,y] = (x==y) ? 1 : 0;
            }
            
        }
    }

    public static HMatrix2D operator +(HMatrix2D left, HMatrix2D right)
    {

        return new HMatrix2D
        (
            left.entries[0, 0] + right.entries[0,0],
            left.entries[0, 1] + right.entries[0,1],
            left.entries[0, 2] + right.entries[0,2],
            left.entries[1, 0] + right.entries[1,0],
            left.entries[1, 1] + right.entries[1,1],
            left.entries[1, 2] + right.entries[1,2],
            left.entries[2, 0] + right.entries[2,0],
            left.entries[2, 1] + right.entries[2,1],
            left.entries[2, 2] + right.entries[2,2]
        ) ;
    }

    public static HMatrix2D operator -(HMatrix2D left, HMatrix2D right)
    {
        return new HMatrix2D
        (
            left.entries[0, 0] - right.entries[0, 0],
            left.entries[0, 1] - right.entries[0, 1],
            left.entries[0, 2] - right.entries[0, 2],
            left.entries[1, 0] - right.entries[1, 0],
            left.entries[1, 1] - right.entries[1, 1],
            left.entries[1, 2] - right.entries[1, 2],
            left.entries[2, 0] - right.entries[2, 0],
            left.entries[2, 1] - right.entries[2, 1],
            left.entries[2, 2] - right.entries[2, 2]
        );
    }

    public static HMatrix2D operator *(HMatrix2D left, float scalar)
    {
        return new HMatrix2D
        (

            left.entries[0, 0] * scalar,
            left.entries[0, 1] * scalar,
            left.entries[0, 2] * scalar,
            left.entries[1, 0] * scalar,
            left.entries[1, 1] * scalar,
            left.entries[1, 2] * scalar,
            left.entries[2, 0] * scalar,
            left.entries[2, 1] * scalar,
            left.entries[2, 2] * scalar

        );
    }

    // Note that the second argument is a HVector2D object
    //
    public static HVector2D operator *(HMatrix2D left, HVector2D right)
    {
        return new HVector2D
        (
            left.entries[0,0] * right.x + left.entries[0, 1] * right.y + left.entries[0, 2] * right.h,
            left.entries[1,0] * right.x + left.entries[1, 1] * right.y + left.entries[1, 2] * right.h
        );
    }

    // Note that the second argument is a HMatrix2D object
    //
    public static HMatrix2D operator *(HMatrix2D left, HMatrix2D right)
    {
        return new HMatrix2D
        (
            //first row 
            /* 
                00 01 02    00 xx xx
                xx xx xx    10 xx xx
                xx xx xx    20 xx xx
                */
            left.entries[0, 0] * right.entries[0, 0] + left.entries[0, 1] * right.entries[1, 0] + left.entries[0, 2] * right.entries[2, 0],

            /* 
                00 01 02    xx 01 xx
                xx xx xx    xx 11 xx
                xx xx xx    xx 21 xx
                */
            left.entries[0, 0] * right.entries[0, 1] + left.entries[0, 1] * right.entries[1, 1] + left.entries[0, 2] * right.entries[2, 1],

            /* 
                00 01 02    xx xx 02
                xx xx xx    xx xx 12
                xx xx xx    xx xx 22
                */
            left.entries[0, 0] * right.entries[0, 2] + left.entries[0, 1] * right.entries[1, 2] + left.entries[0, 2] * right.entries[2, 2],

            //second row
            /* 
                xx xx xx    00 xx xx
                10 11 12    10 xx xx
                xx xx xx    20 xx xx
                */
           
            left.entries[1, 0] * right.entries[0,0] + left.entries[1, 1] * right.entries[1, 0] + left.entries[1, 2] * right.entries[2, 0],
            /* 
                xx xx xx    xx 01 xx
                10 11 12    xx 11 xx
                xx xx xx    xx 21 xx
                */
            left.entries[1, 0] * right.entries[0, 1] + left.entries[1, 1] * right.entries[1, 1] + left.entries[1, 2] * right.entries[2, 1],
            /* 
                xx xx xx    xx xx 02
                10 11 12    xx xx 12
                xx xx xx    xx xx 22
                */
            left.entries[1, 0] * right.entries[0, 2] + left.entries[1, 1] * right.entries[1, 2] + left.entries[1, 2] * right.entries[2, 2],

            //third row
            /* 
                xx xx xx    00 xx xx
                xx xx xx    10 xx xx
                20 21 22    20 xx xx
                */

            left.entries[2, 0] * right.entries[0,0] + left.entries[2, 1] * right.entries[1, 0] + left.entries[2, 2] * right.entries[2, 0],
            /* 
                xx xx xx    xx 01 xx
                xx xx xx    xx 11 xx
                20 21 22    xx 21 xx
                */
            left.entries[2, 0] * right.entries[0, 1] + left.entries[2, 1] * right.entries[1, 1] + left.entries[2, 2] * right.entries[2, 1],
            /* 
                xx xx xx    xx xx 02
                xx xx xx    xx xx 12
                20 21 22    xx xx 22
                */
            left.entries[2, 0] * right.entries[0, 2] + left.entries[2, 1] * right.entries[1, 2] + left.entries[2, 2] * right.entries[2, 2]



        );
    }

    public static bool operator ==(HMatrix2D left, HMatrix2D right)
    {
        for (int row = 0; row < 3; row++)
        {

            for (int col = 0; col < 3; col++)
            {
                if (left.entries[row, col] != right.entries[row, col]) 
                {
                    return false;
                }

            }
        }
        return true;

    }

    public static bool operator !=(HMatrix2D left, HMatrix2D right)
    {
        for (int row = 0; row < 3; row++)
        {

            for (int col = 0; col < 3; col++)
            {
                if (left.entries[row, col] != right.entries[row, col])
                {
                    return true;
                }
                
            }
        }
        return false;
    }

    public override bool Equals(object obj)
    {
        return (obj is HMatrix2D);
    }

    public override int GetHashCode()
    {
        return entries.GetHashCode();
    }

    //public HMatrix2D transpose()
    //{
    //    return // your code here
    //}

    //public float getDeterminant()
    //{
    //    return // your code here
    //}



    //public void setTranslationMat(float transX, float transY)
    //{
    //    // your code here
    //}

    //public void setRotationMat(float rotDeg)
    //{
    //    // your code here
    //}

    //public void setScalingMat(float scaleX, float scaleY)
    //{
    //    // your code here
    //}

    public void Print()
    {
        string result = "";
        for (int r = 0; r < 3; r++)
        {
            for (int c = 0; c < 3; c++)
            {
                result += entries[r, c] + "  ";
            }
            result += "\n";
        }
        Debug.Log(result);
    }
}
