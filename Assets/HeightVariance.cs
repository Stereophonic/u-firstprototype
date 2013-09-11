using UnityEngine;
using System.Collections;

public class HeightVariance : MonoBehaviour {
	public float varienceFactor = 0.2f;
	private float originalHeight;
	// Use this for initialization
	void Start () {
		originalHeight = transform.localScale.y;
		float heightDif = ((Random.value-0.5f)*2) * varienceFactor;
		float newHeight = originalHeight + heightDif;
		Vector3 newScale = new Vector3(1,newHeight,1);
		transform.localScale = newScale;
		transform.Translate(0,heightDif,0);
	}
	
	
	// Update is called once per frame
	void Update () {

	}
}
