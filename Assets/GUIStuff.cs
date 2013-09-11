using UnityEngine;
using System.Collections;

public class GUIStuff : MonoBehaviour {
	public Transform testTransform;
//	public GameObject gameVariablesObject;
	
	public float hSliderValue = 0.0F;
    
	public int selGridInt;
    public string[] selStrings = new string[] {"10'", "3'"};
	private RotateView myRotation;
	
	void OnGUI() {
        hSliderValue = GUI.HorizontalSlider(new Rect(25, 25, 100, 30), hSliderValue, -0.5F, 0.5F);
		//gameVariablesObject.GetComponent(GameVariables);
		GameVariables.cameraSpeed = hSliderValue;
		
		/*
		selGridInt = -1;
		
		selGridInt = GUI.SelectionGrid(new Rect(25, 50, 100, 30), selGridInt, selStrings, 2);
		
		if(selGridInt == 0){
			print("0");
//			MoveView.rotateView(Quaternion.Euler(0, 45, 0));
			myRotation = GetComponent<RotateView>();
			myRotation.endMarker = testTransform;
            myRotation.enabled = !myRotation.enabled;
        
			selGridInt=-1;
		}
		else if(selGridInt ==1){
			print("1");
//			MoveView.rotateView(Quaternion.Euler(0, -45, 0));
			selGridInt=-1;
		}
		*/
	}
	
		 
}
