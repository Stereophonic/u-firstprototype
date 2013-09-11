using UnityEngine;
using System.Collections;

public class MoveCharacter : MonoBehaviour {


	void Start() {

	}
	
    void Update() 
	{
        int fingerCount = 0;
        foreach (Touch touch in Input.touches) 
		{
            if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled){
                fingerCount++;
		//		print ("Finger touched");
			
			Vector3 tp = touch.position;
			//print ("tp:" + tp);
				tp.z = 6;
				Vector3 p = Camera.main.ScreenToWorldPoint(tp);
			//	print ("p" + p);
			//transform.Translate(-2,0,1);
			//	transform.Translate(p, Camera.main.transform);
			//	transform.position = new Vector3(0, 0, 0);
				transform.position = p;
			}
			if (touch.phase == TouchPhase.Ended && touch.phase != TouchPhase.Canceled){
                fingerCount++;
				print ("Finger lifted");
			}
		}
		
//        if (fingerCount > 0)
//            print("User has " + fingerCount + " finger(s) touching the screen");
//     	if (fingerCount = 1)
//			print ("Finger is at: ");
	}


}
	
