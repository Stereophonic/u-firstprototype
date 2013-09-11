using UnityEngine;
using System.Collections;

public class MoveView : MonoBehaviour {
	
	
	
	// Use this for initialization
	void Start () {
		
	 //GameObject gameVars = GameObject.Find("Variables");
			//print (gameVars.cameraSpeed);	
	}
	
	// Update is called once per frame
	void Update () {
	//print(GameVariables.cameraSpeed);
	transform.Translate(0,0,GameVariables.cameraSpeed);
		//transform.Rotate(0,45,0);
		
	}

}
