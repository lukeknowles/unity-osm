using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebMercator 
{
	private static readonly double EQUATORIAL_RADIUS =  6378137.0; // Radius of Equator in Meters //
	private static readonly double PI = System.Math.PI;
	private static readonly double DEGREE_TO_RADIANS = ((System.Math.PI * 2) / 360);


	public static double ConvertLatitudeToY(double lat)
	{
		return(System.Math.Log(System.Math.Tan(PI / 4 + (DEGREE_TO_RADIANS * lat) / 2)) * EQUATORIAL_RADIUS);
	}

	public static double ConvertLongitudeToX(double lon)
	{
		return((DEGREE_TO_RADIANS * lon) * EQUATORIAL_RADIUS);
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
