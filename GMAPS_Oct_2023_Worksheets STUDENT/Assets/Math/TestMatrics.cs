using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMatrics : MonoBehaviour
{
    private HMatrix2D m_Matrix = new HMatrix2D();
    // Start is called before the first frame update
    void Start()
    {
       m_Matrix.setIdentity();
       m_Matrix.Print();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
