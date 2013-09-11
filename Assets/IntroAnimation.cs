using UnityEngine;
using System.Collections;

public class IntroAnimation : MonoBehaviour {
	public Transform startMarker;
    public Transform endMarker;
    public float speed = 6.0F;
    private float startTime;
    private float journeyLength;
    public Transform target;
    public float smooth = 5.0F;
    void Start() {
        startTime = Time.time;
        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
    }
    void Update() {
		
			float distCovered = (Time.time - startTime) * speed;
      		float fracJourney = distCovered / journeyLength;
			if(!(fracJourney>1)){
        	transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fracJourney);
			}
			
		
		
		
		//transform.eulerAngles = Vector3.Lerp(startMarker.eulerAngles, endMarker.eulerAngles, fracJourney);
    }
}