
// Use this for initialization
function Start () {
}

// Update is called once per frame
var particle : GameObject;
function Update () {
	for (var touch : Touch in Input.touches) {
		if (touch.phase == TouchPhase.Began) {
			// Construct a ray from the current touch coordinates
			var ray = Camera.main.ScreenPointToRay (touch.position);
			if (Physics.Raycast (ray)) {
				// Create a particle if hit
				Instantiate (particle, transform.position, transform.rotation);
			}
		}
	}
}

