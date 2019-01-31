using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour 
{
	public OSMNode node;

	// Use this for initialization
	void Start () 
	{
		//Debug.Log((float)node.getLongitude() + " - " + (float)node.getLatitude());
		//transform.position = Quaternion.AngleAxis((float)node.getLongitude(), -Vector3.up) * Quaternion.AngleAxis((float)node.getLatitude(), -Vector3.right) * new Vector3(25, 25, 25);
		transform.position = new Vector3((float)WebMercator.ConvertLongitudeToX(node.getLongitude()) / 750, 0, (float)WebMercator.ConvertLatitudeToY(node.getLatitude()) / 750);
		//transform.position = new Vector3(0, 2, 54);

		// Rework this to account for curvature of Earth //	
	}
	
	// Update is called once per frame
	void Update () {

	}
}
