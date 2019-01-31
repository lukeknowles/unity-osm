using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static OSMEnums;

public class OSMNode 
{
	private double latitude;
	private double longitude;
	private ulong id;
	private HIGHWAY nodeType;
	
	public double getLatitude()
	{
		return this.latitude;
	}

	public double getLongitude()
	{
		return this.longitude;
	}

	public void setLatitude(double lat)
	{
		this.latitude = lat;
	}

	public void setLongitude(double lng)
	{
		this.longitude = lng;
	}

	public ulong getId()
	{
		return this.id;
	}

	public void setId(ulong nodeId)
	{
		this.id = nodeId;
	}

	public HIGHWAY getNodeType()
	{
		return this.nodeType;
	}

	public void setNodeType(HIGHWAY type)
	{
		this.nodeType = type;
	}

	public OSMNode(ulong nodeId, double nodeLat, double nodeLong, HIGHWAY type=HIGHWAY.NULL)
	{
		setId(nodeId);
		setLatitude(nodeLat);
		setLongitude(nodeLong);
		setNodeType(type);
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
