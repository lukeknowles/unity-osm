using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour 
{
	public OSMWay way;
	public string type;
	public string id;

	// Use this for initialization
	void Start () 
	{
		this.type = way.getHighwayType().ToString();
		this.id = way.getId().ToString();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
