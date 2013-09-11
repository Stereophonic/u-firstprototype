using UnityEngine;
using System.Collections;

public class RotateView : MonoBehaviour {
	public Transform startMarker;
    public Transform endMarker;
    public float speed = 6.0F;
    public float startTime;
    public float journeyLength;
    public Transform target;
    public float smooth = 5.0F;
	private bool doUpdate = false;
    
	//void Start() {
     //   startTime = Time.time;
   //     journeyLength = Vector3.Distance(startMarker.eulerAngles, endMarker.eulerAngles);
 //   }
  //  void Update() {
//		transform.Rotate(new Vector3(0, 4, 0) * Time.deltaTime);
		//transform.Rotate( * Time.deltaTime);
	//	if (doUpdate==true){	
		//float distCovered = (Time.time - startTime) * speed;
      	//	float fracJourney = distCovered / journeyLength;
		//	if(fracJourney<=1){
		//		transform.eulerAngles = Vector3.Lerp(startMarker.eulerAngles, endMarker.eulerAngles, fracJourney);
		//	}
		//	else{
		//		this.enabled = false;
		//	}
		//}

   // }
	private Vector3 newPosition;

	void Awake() {
		newPosition = transform.position;		
	}
	void Update(){
		rotationChanging();
	}
	
	void rotationChanging(){
		Vector3 rotationA = new Vector3(-5, 3, 0);
        Vector3 rotationB = new Vector3(5, 3, 0);
        
        if(Input.GetKeyDown(KeyCode.Q))
            newRotation = rotationA;
        if(Input.GetKeyDown(KeyCode.E))
            newRotation = rotationB;
        
        //transform.position = Vector3.Lerp(transform.position, newRotation, smooth * Time.deltaTime);
		transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, Time.time * speed * smooth);
		
	}
	
	/*
	public void doRotate(bool begin){
		if (begin==true)
			doUpdate = true;
		else
			doUpdate = false;
	}
	*/
}
