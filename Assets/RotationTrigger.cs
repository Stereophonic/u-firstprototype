using UnityEngine;
using System.Collections;

public class RotationTrigger : MonoBehaviour {
	
	private Transform testTransform ;
	private RotateView myRotation;
	public GameObject viewObject;
		
	void Awaken(){
		
	}
	void Start(){
		testTransform = this.gameObject.transform;
	}
	

void OnTriggerEnter(Collider other) {
		print(other.name);
		if(other.name == "PlayerBoundingBox"){
        //Destroy(other.gameObject);
		viewObject = GameObject.Find("Viewport");
		myRotation = viewObject.GetComponent<RotateView>();
			myRotation.endMarker = testTransform;
            myRotation.enabled = true;
		
		}
    }
	    void OnTriggerExit(Collider other) {
        //Destroy(other.gameObject);
		//print("exited");
    }
	    void OnTriggerStay(Collider other) {
      //  if (other.attachedRigidbody)
         //   other.attachedRigidbody.AddForce(Vector3.up * 10);
		//print("stay");
        
    }
}
