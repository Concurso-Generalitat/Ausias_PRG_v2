using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {


	private float mousePosX;
	private float mousePosY;

	private float verticalRotationMax;
	private float verticalRotationMin;
	private bool camMoveStarted;

	private Vector4 cameraRotationDefault;
	private Vector4 cameraCurrentRotation;
	// Use this for initialization
	void Start () 
	{
		cameraGetInitialRotation ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		handleCameraRotation();
		handleMovementCamera ();

		mousePosX = Input.mousePosition.x;
		mousePosY = Input.mousePosition.y;
	}
	public void cameraSetInitialRotation()
	{
		cameraRotationDefault = new Vector4 (Camera.main.transform.rotation.x,Camera.main.transform.rotation.y,Camera.main.transform.rotation.z,
		                                     Camera.main.transform.rotation.w);
	}
	public Vector4 cameraGetInitialRotation()
	{
		cameraCurrentRotation = new Vector4 (Camera.main.transform.rotation.x,Camera.main.transform.rotation.y,
		                                     Camera.main.transform.rotation.z,Camera.main.transform.rotation.w);
		Vector4 tmpV4 = new Vector4 (cameraRotationDefault.x - cameraCurrentRotation.x, cameraRotationDefault.y - cameraCurrentRotation.y,
		                             cameraRotationDefault.z - cameraCurrentRotation.z, cameraRotationDefault.w);

		return tmpV4;

	}
	public void handleMovementCamera()
	{
		if(Input.GetKeyDown(KeyCode.W))
		{
			Debug.Log ( " press W ");
			camMoveStarted = false;
			Camera.main.transform.Rotate(cameraGetInitialRotation().x,cameraGetInitialRotation().y,cameraGetInitialRotation().z);
		}
	}

	public void handleCameraRotation()
	{
	
		var easeFactor = 10f;

		if (Input.GetMouseButton (1)) 
		{
			if(!camMoveStarted ) 
			{
				cameraSetInitialRotation();

				camMoveStarted = true;
			}

			// horizontal
			Debug.Log ( " Right button pressed");
			if(Input.mousePosition.x != mousePosX)
			{

				var cameraRotationY = ( Input.mousePosition.x - mousePosX) * easeFactor * Time.deltaTime;
				var cameraRotationX = ( Input.mousePosition.y + mousePosY) * Time.deltaTime;

				Camera.main.transform.Rotate(0,cameraRotationY,0);
			}

		}
	}
}
