using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMatrics : MonoBehaviour
{
    private HMatrix2D m_Matrix = new HMatrix2D();
    private HMatrix2D mat1,mat2, ResultMat;
    private HVector2D vec1,ResultVec;

    // Start is called before the first frame update
    void Start()
    {
        

        //identity matrix
        //m_Matrix.setIdentity();
        //m_Matrix.Print();

        //Question2();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Question2()
    {
        //test matriices 
        mat1 = new HMatrix2D(1, 2, 3, 4, 5, 6, 7, 8, 9);
        mat2 = new HMatrix2D(1, 2, 3, 4, 5, 6, 7, 8, 9);
        vec1 = new HVector2D(1, 2);

        //test + operator
        ResultMat = mat1 + mat2;
        ResultMat.Print();

        //test - operator
        ResultMat = mat1 - mat2;
        ResultMat.Print();

        //test * operator
        ResultMat = mat1 * mat2;
        ResultMat.Print();

        //test HMatrix * Hvector
        ResultVec = mat1 * vec1;
        Debug.Log(ResultVec.x+" "+ResultVec.y+" "+ResultVec.h);

        //rest == operator
        Debug.Log(mat1 == mat2);
        mat2 = new HMatrix2D(9, 8, 7, 6, 5, 4, 3, 2, 1);
        Debug.Log(mat1 == mat2);

        //rest != operator
        mat2 = new HMatrix2D(9, 8, 7, 6, 5, 4, 3, 2, 1);
        Debug.Log(mat1 != mat2);
        mat2 = new HMatrix2D(1, 2, 3, 4, 5, 6, 7, 8, 9);
        Debug.Log(mat1 != mat2);

    }
}
