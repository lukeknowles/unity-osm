using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static OSMEnums;

public class OSMWay 
{
	private OSMNodeList<ulong, OSMNode> nodes = new OSMNodeList<ulong, OSMNode>();
	private ulong wayId;
	private HIGHWAY roadType;
	private string streetName;
	private string tigerCfcc;
	private string tigerCounty;
	private string tigerNameBase;
	private string tigerNameDirectionSuffix;
	private bool closedShape;

	public OSMWay(OSMWay copy)
	{
		this.wayId = copy.wayId;
		this.roadType = copy.roadType;
		this.streetName = copy.streetName;
		this.tigerCfcc = copy.tigerCfcc;
		this.tigerCounty = copy.tigerCounty;
		this.tigerNameBase = copy.tigerNameBase;
		this.tigerNameDirectionSuffix = copy.tigerNameDirectionSuffix;
		this.closedShape = copy.closedShape;
	}

	public OSMWay() 
	{

	}

	public OSMNodeList<ulong, OSMNode> getNodeList()
	{
		return this.nodes;
	}

	public void overwriteNodeList(OSMNodeList<ulong, OSMNode> newList)
	{
		this.nodes.Clear();
		this.nodes = newList;
	}

	public ulong getId()
	{
		return this.wayId;
	}

	public void setId(ulong id)
	{
		this.wayId = id;
	}

	public HIGHWAY getHighwayType()
	{
		return this.roadType;
	}

	public void setHighway(HIGHWAY type)
	{
		this.roadType = type;
	}

	public string getStreetName()
	{
		return this.streetName;
	}

	public void setStreetName(string name)
	{	
		this.streetName = name;
	}

	public string getTigerCfcc()
	{
		return this.tigerCfcc;
	}

	public void setTigerCfcc(string cfcc)
	{
		this.tigerCfcc = cfcc;
	}

	public string getTigerCounty()
	{
		return this.tigerCounty;
	}

	public void setTigerCounty(string county)
	{
		this.tigerCounty = county;
	}

	public string getTigerNameBase()
	{
		return this.tigerNameBase;
	}

	public void setTigerNameBase(string nameBase)
	{
		this.tigerNameBase = nameBase;
	}

	public string getTigerNameDirectionSuffix()
	{
		return this.tigerNameDirectionSuffix;
	}

	public void setTigerNameDirectioNSuffix(string suffix)
	{
		this.tigerNameDirectionSuffix = suffix;
	}

	public bool isClosedShape()
	{
		return this.closedShape;
	}

	public void setClosedShape()
	{
		this.closedShape = true;
	}

	public void setOpenShape()
	{
		this.closedShape = false;
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
