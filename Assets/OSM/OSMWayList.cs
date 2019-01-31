using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OSMWayList<TKey, TValue> : Dictionary<ulong, OSMWay>
{
	public void addWay(ulong id, OSMWay way)
	{
		this.Add(id, way);
	}

	public void addWay(OSMWay way)
	{
		this.Add(way.getId(), way);
	}
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
