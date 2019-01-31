using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using static OSMEnums;
using System;
using System.IO;

public class Interpreter : MonoBehaviour 
{ 
	public string OSMFilePath = @"E:\Downloads\map (4).osm";
	public XmlDocument reader;

	// Use this for initialization
	void Awake()
	{
		OSMNodeList<ulong, OSMNode> nodeList = new OSMNodeList<ulong, OSMNode>();
		OSMWayList<ulong, OSMWay> wayList = new OSMWayList<ulong, OSMWay>();
		reader = new XmlDocument();
		reader.Load(OSMFilePath);
		
		XmlElement root = reader.DocumentElement;
		XmlNodeList elems = root.ChildNodes;

		for(int i = 0; i < elems.Count; i++)
		{
			//Debug.Log(elems[i].Name);

			if(elems[i].Name == "node")
			{
				//OSMNode x = new OSMNode(uint.Parse(i.ToString()), 12.34, 56.78);
				//nodeList.Add(uint.Parse(i.ToString()), x);
				//OSMNode newNode = new OSMNode(ulong.Parse(elems[i].Attributes["id"].Value), double.Parse(elems[i].Attributes["lat"].Value), double.Parse(elems[i].Attributes["lon"].Value));

				nodeList.Add(ulong.Parse(elems[i].Attributes["id"].Value), new OSMNode(ulong.Parse(elems[i].Attributes["id"].Value), double.Parse(elems[i].Attributes["lat"].Value), double.Parse(elems[i].Attributes["lon"].Value)));
			}

			if(elems[i].Name == "way")
			{	
				OSMNodeList<ulong, OSMNode> nodesInWay = new OSMNodeList<ulong, OSMNode>();
				OSMWay currentWay = new OSMWay();
				currentWay.setId(ulong.Parse(elems[i].Attributes["id"].Value));

				Debug.Log(">WAY " +  currentWay.getId());

				XmlNodeList currentWayChildren = elems[i].ChildNodes;

				bool plot = false;

				for(int j = 0; j < currentWayChildren.Count; j++)
				{
					if(currentWayChildren[j].Name == "nd")
					{
						//Debug.Log(currentWayChildren[j].Attributes["ref"].Value);

						if((nodesInWay.ContainsKey(ulong.Parse(currentWayChildren[j].Attributes["ref"].Value))))
						{
							currentWay.setClosedShape();
						}
						else
						{
							nodesInWay.Add(ulong.Parse(currentWayChildren[j].Attributes["ref"].Value), nodeList[ulong.Parse(currentWayChildren[j].Attributes["ref"].Value)]);
						}

						Debug.Log("|---NODE " +  currentWayChildren[j].Attributes["ref"].Value + " OF " + currentWay.getId() + ", " + j);
					}

					if(currentWayChildren[j].Name == "tag")
					{
						string tagType = currentWayChildren[j].Attributes["k"].Value;
						
						switch(tagType)
						{
							case "highway":
								currentWay.setHighway(OSMEnums.parseHighway(currentWayChildren[j].Attributes["v"].Value));
								plot = true;
							break;

							case "name":
								currentWay.setStreetName(currentWayChildren[j].Attributes["v"].Value);
							break;

							case "tiger:cfcc":
								currentWay.setTigerCfcc(currentWayChildren[j].Attributes["v"].Value);
							break;

							case "tiger:county":
								currentWay.setTigerCounty(currentWayChildren[j].Attributes["v"].Value);
							break;

							case "tiger:name_base":
								currentWay.setTigerNameBase(currentWayChildren[j].Attributes["v"].Value);
							break;

							case "tiger:name_direction_suffix":
								currentWay.setTigerNameDirectioNSuffix(currentWayChildren[j].Attributes["v"].Value);
							break;
						}
					}
				}

				if(plot && (currentWay.getHighwayType() == OSMEnums.HIGHWAY.PRIMARY || currentWay.getHighwayType() == OSMEnums.HIGHWAY.SECONDARY || currentWay.getHighwayType() == OSMEnums.HIGHWAY.RESIDENTIAL))
				{
					currentWay.overwriteNodeList(nodesInWay);
					wayList.addWay(currentWay);
				}
			}
		}

		Debug.Log("*WAYS*: " + wayList.Count);

		foreach(ulong way in wayList.Keys)
		{
			GameObject newLine = (GameObject)Instantiate(Resources.Load("WayLine"));
			newLine.GetComponent<Line>().way = new OSMWay(wayList[way]);
			newLine.name = wayList[way].getStreetName();

			OSMNodeList<ulong, OSMNode> nodeListOfCurrentWay = wayList[way].getNodeList();
			Color wayColor = UnityEngine.Random.ColorHSV();

			foreach(ulong node in nodeListOfCurrentWay.Keys)
			{
				GameObject newPoint = (GameObject)Instantiate(Resources.Load("NodePoint"));
				newPoint.GetComponent<Point>().node = new OSMNode(nodeListOfCurrentWay[node].getId(), nodeListOfCurrentWay[node].getLatitude(), nodeListOfCurrentWay[node].getLongitude());
				newPoint.GetComponent<Renderer>().material.color = wayColor;
				newPoint.transform.parent = newLine.transform;
				//Instantiate(newPoint);
			}
		}
		
	}

	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
