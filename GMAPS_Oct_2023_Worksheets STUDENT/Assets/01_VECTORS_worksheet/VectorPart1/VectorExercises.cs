using UnityEngine;

public class VectorExercises : MonoBehaviour
{
    [SerializeField] LineFactory lineFactory;
    [SerializeField] bool Q2a, Q2b, Q2d, Q2e;
    [SerializeField] bool Q3a, Q3b, Q3c, projection;

    private Line drawnLine;

    private Vector2 startPt;
    private Vector2 endPt;
    private Vector3 endPtV3;
    private Vector3 startPtV3;
    public float GameWidth, GameHeight;
    private float minX, minY, maxX, maxY;

    private void Start()
    {
        //call the method qns2a to draw a diagonal line
        //Question2a();

        //call the method qns2b to draw a lines
        //CalculateGameDimensions();
        //Question2b(20);

        //call the method qns2D to draw a lines
        //Question2d();

        //call the method qns2e to draw a lines
        //set max X and Y to 5 and zByUser to 10, zByUser is the z coordinates that the developer can set 
        //maxX = 5; 
        //maxY = 5;
        //minY = 10;
        //Question2e(20);
        
        Question3a();

        /*if (Q2a)
            Question2a();
        if (Q2b)
            Question2b(20);
        if (Q2d)
            Question2d();
        if (Q2e)
            Question2e(20);
        if (Q3a)
            Question3a();
        if (Q3b)
            Question3b();
        if (Q3c)
            Question3c();
        if (projection)
            Projection();*/
    }

    public void CalculateGameDimensions()
    {
        GameHeight = Camera.main.orthographicSize * 2f;
        GameWidth = Camera.main.aspect * GameHeight;

        maxX = GameWidth / 2;
        maxY = GameHeight / 2;
        minX = -maxX;
        minY = -maxY;
    }

    void Question2a()
    {
        /*startPt is starting point of the line which is vector 0,0 and endPt is the end point of the line which is vector 2,3
        so the line should be drawn from 0,0 and diagonally reach 2,3 */
        startPt = new Vector2(0,0);
        endPt = new Vector2(2, 3);

        /*draw the line using the GetLine method which takes in 4 inputs, the start point of the line, the end point of the line, the width of the line 
          and the colour of the line.  */
        drawnLine = lineFactory.GetLine(startPt,endPt,0.02f,Color.green);

        //EnableDrawing(true) initialises the line, if the bool is false then no line will show up 
        drawnLine.EnableDrawing(true);

        //find the magnitude of the line and print debug log statement
        Vector2 vec2 = endPt - startPt;
        Debug.Log("Magnitude = " + vec2.magnitude);
        Debug.Log("qns 2a is running");

    }

    void Question2b(int n)
    {
        //for loop to last for however many lines there is to be drawn in the int n parameter   
        for (int i = 0; i < n; i++)
        {
            //randomise the starting and ending points of the lines 
            startPt = new Vector2(Random.Range(-maxX,maxX),Random.Range(-maxY,maxY));
            endPt = new Vector2(Random.Range(-maxX, maxX), Random.Range(-maxY, maxY));
            //draw the line using the values of startPt,endPt with the width of the line being 0.02f and the color of the line be blue 
            drawnLine = lineFactory.GetLine(startPt, endPt,0.02f,Color.blue);
        }
        Debug.Log("qns 2b is running");
    }

    void Question2d()
    {
        DebugExtension.DebugArrow(
            new Vector3(0,0,0),
            new Vector3(5,5,0),Color.magenta,60f);
        Debug.Log("qns 2d is running");
    }

    void Question2e(int n)
    {
        for (int i = 0; i < n; i++)
        {
                endPtV3 = new Vector3(
                Random.Range(-maxX, maxX),
                Random.Range(-maxY, maxY),
                Random.Range(-minY, minY));

                DebugExtension.DebugArrow(
                Vector3.zero,
                endPtV3,
                Color.blue,
                60f);
                
        }  
    }

    public void Question3a()
    {
        HVector2D a = new HVector2D(3f, 5f);
        HVector2D b = new HVector2D(-4f, 2f);
        HVector2D c = a + b;

        DebugExtension.DebugArrow(Vector3.zero, a.ToUnityVector3(), Color.red, 60f);
        DebugExtension.DebugArrow(Vector3.zero, b.ToUnityVector3(), Color.green, 60f);
        DebugExtension.DebugArrow(Vector3.zero, c.ToUnityVector3(), Color.white, 60f);

        DebugExtension.DebugArrow(a.ToUnityVector3(), b.ToUnityVector3(), Color.green, 60f);
        

        //Debug.Log("Magnitude of a = " + // Your code here.ToString("F2"));
        // Your code here
        // ...
    }

    public void Question3b()
    {
        // Your code here
        // ...

        //DebugExtension.DebugArrow(Vector3.zero, a.ToUnityVector3(), Color.red, 60f);
        // Your code here
    }

    public void Question3c()
    {

    }

    public void Projection()
    {
        HVector2D a = new HVector2D(0, 0);
        HVector2D b = new HVector2D(6, 0);
        HVector2D c = new HVector2D(2, 2);

        //HVector2D v1 = b - a;
        // Your code here

        //HVector2D proj = // Your code here

        //DebugExtension.DebugArrow(a.ToUnityVector3(), b.ToUnityVector3(), Color.red, 60f);
        //DebugExtension.DebugArrow(a.ToUnityVector3(), c.ToUnityVector3(), Color.yellow, 60f);
        //DebugExtension.DebugArrow(a.ToUnityVector3(), proj.ToUnityVector3(), Color.white, 60f);
    }
}
