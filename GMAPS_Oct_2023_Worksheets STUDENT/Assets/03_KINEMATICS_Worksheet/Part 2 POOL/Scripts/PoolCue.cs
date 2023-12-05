 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
using UnityEngine.UIElements;

public class PoolCue : MonoBehaviour
 {
 	public LineFactory lineFactory;
 	public GameObject ballObject;

 	private Line drawnLine;
 	private Ball2D ball;

 	private void Start()
 	{
 		ball = ballObject.GetComponent<Ball2D>();
            
    }
  
  
    void Update()
 	{
 		if (Input.GetMouseButtonDown(0))
 		{
 			var startLinePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //  line Start position 
            if (ball != null && ball.IsCollidingWith(startLinePos.x,startLinePos.y))
            {
                //draw line start from ball and end at mouse position 
                drawnLine = lineFactory.GetLine(ball.transform.position, startLinePos, 3f,Color.black);
                drawnLine.EnableDrawing(true);// start line drawing
            }


        }
        else if (Input.GetMouseButtonUp(0) && drawnLine != null)
        {
            drawnLine = lineFactory.GetLine(drawnLine.start, drawnLine.end, 3f, Color.black);
            drawnLine.EnableDrawing(false);// End line drawing       

            //update the velocity of the white ball.
            HVector2D v = new HVector2D(-Camera.main.ScreenToWorldPoint(Input.mousePosition)-ball.transform.position);
            ball.Velocity = v;

            drawnLine = null;      
        }

        if (drawnLine != null)
 		{
            drawnLine.end = Camera.main.ScreenToWorldPoint(Input.mousePosition); // Update line end
        }
 	}

 	/// <summary>
 	/// Get a list of active lines and deactivates them.
 	/// </summary>
 	public void Clear()
 	{
 		var activeLines = lineFactory.GetActive();

 		foreach (var line in activeLines)
 		{
 			line.gameObject.SetActive(false);
 		}
 	}
 }
