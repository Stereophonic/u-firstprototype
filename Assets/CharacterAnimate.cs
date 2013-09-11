using UnityEngine;
using System.Collections;

public class CharacterAnimate : MonoBehaviour {
	public float startScale = 0.6f;
	public float endScale = 1.0f;
	private Vector3 startVec;
	private Vector3 endVec;
    public float speed = 0.8F;
    private float startTime;
	
    void Start() {
		startVec = new Vector3(startScale,startScale,startScale);
		endVec = new Vector3(endScale,endScale,endScale);
        startTime = Time.time;

    }
	    void Update() {

        float distCovered = (Time.time - startTime) * speed;
		float offsetScale = Mathf.Abs(Mathf.Sin(distCovered));
		transform.localScale = Vector3.Lerp(startVec, endVec, offsetScale);
    }
	

}
