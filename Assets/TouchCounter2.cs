using UnityEngine;
using System.Collections;

public class TouchCounter2 : MonoBehaviour {
private float score = 0f;
private string scoreText = "Cost: 0";
public float movementCost = 0.5f;

	void Start() {

	}
	
    void Update() 
{
        int fingerCount = 0;
        foreach (Touch touch in Input.touches) {
            if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
                fingerCount++;           
}
        if (fingerCount > 0)
            print("User has " + fingerCount + " finger(s) touching the screen");
		addScore (fingerCount);       
}
private void addScore (float pointsToAdd)
	{	
		score += pointsToAdd;
		scoreText = "Score: " + score;
	}
private void OnGUI ()
	{
		GUI.Label (new Rect (10, 10, 100, 20), scoreText);
	}
}
	