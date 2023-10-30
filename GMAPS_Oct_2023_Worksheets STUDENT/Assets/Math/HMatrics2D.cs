using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HMatrix2D
{
    public float [,] entries { get; set; } = new float[3, 3];
    

    //public HMatrix2D()
    //{
    //    entries = new float[3, 3];
    //}

    //public HMatrix2D(float[,] multiArray)
    //{
    //    entries = multiArray;
    //}

    //public HMatrix2D(float m00, float m01, float m02,
    //         float m10, float m11, float m12,
    //         float m20, float m21, float m22)
    //{
    //    m00 = 0;
    //    m01 = 0;
    //    m02 = 0;
    //    m10 = 0;
    //    m11 = 0;
    //    m12 = 0;
    //    m20 = 0;
    //    m21 = 0;
    //    m22 = 0;

    //}

    //public static HMatrix2D operator +(HMatrix2D left, HMatrix2D right)
    //{
    //    return new HMatrix2D
    //    (

    //    );
    //}

    //public static HMatrix2D operator -(HMatrix2D left, HMatrix2D right)
    //{
    //    return new HMatrix2D
    //    (

    //    );
    //}

    //public static HMatrix2D operator *(HMatrix2D left, float scalar)
    //{
    //    return new HMatrix2D
    //    (

    //    );
    //}

    //// Note that the second argument is a HVector2D object
    ////
    //public static HVector2D operator *(HMatrix2D left, HVector2D right)
    //{
    //    return new HVector2D
    //    (

    //    );
    //}

    //// Note that the second argument is a HMatrix2D object
    ////
    //public static HMatrix2D operator *(HMatrix2D left, HMatrix2D right)
    //{
    //    return new HMatrix2D
    //    (
    //        /* 
    //            00 01 02    00 xx xx
    //            xx xx xx    10 xx xx
    //            xx xx xx    20 xx xx
    //            */
    //        left.Entries[0, 0] * right.Entries[0, 0] + left.Entries[0, 1] * right.Entries[1, 0] + left.Entries[0, 2] * right.Entries[2, 0],

    //        /* 
    //            00 01 02    xx 01 xx
    //            xx xx xx    xx 11 xx
    //            xx xx xx    xx 21 xx
    //            */
    //        left.Entries[0, 0] * right.Entries[0, 1] + left.Entries[0, 1] * right.Entries[1, 1] + left.Entries[0, 2] * right.Entries[2, 1],


    //    // and so on for another 7 entries
    //    );
    //}

    //public static bool operator ==(HMatrix2D left, HMatrix2D right)
    //{
    //    // your code here
    //}

    //public static bool operator !=(HMatrix2D left, HMatrix2D right)
    //{
    //    // your code here
    //}

    //public override bool Equals(object obj)
    //{
    //    // your code here
    //}

    //public override int GetHashCode()
    //{
    //    // your code here
    //}

    //public HMatrix2D transpose()
    //{
    //    return // your code here
    //}

    //public float getDeterminant()
    //{
    //    return // your code here
    //}

    public void setIdentity()
    {
        int x;
        for (int y = 0; y < x; y++)
        {
            if(x == 0)
            {
                entries[y][0] = 1;
            }
        }
    }

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

    //public void Print()
    //{
    //    string result = "";
    //    for (int r = 0; r < 3; r++)
    //    {
    //        for (int c = 0; c < 3; c++)
    //        {
    //            result += entries[r, c] + "  ";
    //        }
    //        result += "\n";
    //    }
    //    Debug.Log(result);
    //}
}
