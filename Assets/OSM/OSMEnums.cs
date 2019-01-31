using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OSMEnums 
{
	public enum HIGHWAY
	{
		MOTORWAY,
		TRUNK,
		PRIMARY,
		SECONDARY,
		TERTIARY,
		UNCLASSIFIED,
		RESIDENTIAL,
		SERVICE,
		MOTORWAY_LINK,
		TRUNK_LINK,
		PRIMARY_LINK,
		SECONDARY_LINK,
		TERTIARY_LINK,
		LIVING_STREET,
		PEDESTRIAN,
		TRACK,
		BUS_GUIDEWAY,
		ESCAPE,
		RACEWAY,
		ROAD,
		FOOTWAY,
		BRIDLEWAY,
		STEPS,
		PATH,
		CYCLEWAY,
		CONSTRUCTION,
		BUS_STOP,
		CROSSING,
		ELEVATOR,
		EMERGENCY_ACCESS_POINT,
		GIVE_WAY,
		MINI_ROUNDABOUT,
		MOTORWAY_JUNCTION,
		PASSING_PLACE,
		REST_AREA,
		SPEED_CAMERA,
		STREET_LAMP,
		SERVICES,
		STOP,
		TRAFFIC_SIGNALS,
		TURNING_SIGNAL,
		TURNING_CIRCLE,
		TOLL_GANTRY,
		NULL
	}
	
	private static Dictionary<string, HIGHWAY> parseListHighway = new Dictionary<string, HIGHWAY>()
	{
		{"motorway", HIGHWAY.MOTORWAY},
		{"trunk", HIGHWAY.TRUNK},
		{"primary", HIGHWAY.PRIMARY},
		{"secondary", HIGHWAY.SECONDARY},
		{"tertiary", HIGHWAY.TERTIARY},
		{"unclassified", HIGHWAY.UNCLASSIFIED},
		{"residential", HIGHWAY.RESIDENTIAL},
		{"service", HIGHWAY.SERVICE},
		{"motorway_link", HIGHWAY.MOTORWAY_LINK},
		{"trunk_link", HIGHWAY.TRUNK_LINK},	
		{"primary_link", HIGHWAY.PRIMARY_LINK},
		{"secondary_link", HIGHWAY.SECONDARY_LINK},
		{"tertiary_link", HIGHWAY.TERTIARY_LINK},
		{"living_street", HIGHWAY.LIVING_STREET},
		{"pedestrian", HIGHWAY.PEDESTRIAN},
		{"track", HIGHWAY.TRACK},
		{"bus_guideway", HIGHWAY.BUS_GUIDEWAY},
		{"escape", HIGHWAY.ESCAPE},
		{"raceway", HIGHWAY.RACEWAY},
		{"road", HIGHWAY.ROAD},
		{"footway", HIGHWAY.FOOTWAY},
		{"bridleway", HIGHWAY.BRIDLEWAY},
		{"steps", HIGHWAY.STEPS},
		{"path", HIGHWAY.STEPS},
		{"cycleway", HIGHWAY.CYCLEWAY},
		{"construction", HIGHWAY.CONSTRUCTION},
		{"bus_stop", HIGHWAY.BUS_STOP},
		{"crossing", HIGHWAY.CROSSING},
		{"elevator", HIGHWAY.ELEVATOR},
		{"emergency_access_point", HIGHWAY.EMERGENCY_ACCESS_POINT},
		{"give_way", HIGHWAY.GIVE_WAY},
		{"mini_roundabout", HIGHWAY.MINI_ROUNDABOUT},
		{"motorway_junction", HIGHWAY.MOTORWAY_JUNCTION},
		{"passing_place", HIGHWAY.PASSING_PLACE},
		{"rest_area", HIGHWAY.REST_AREA},
		{"speed_camera", HIGHWAY.SPEED_CAMERA},
		{"street_lamp", HIGHWAY.STREET_LAMP},
		{"services", HIGHWAY.SERVICES},
		{"stop", HIGHWAY.STOP},
		{"traffic_signals", HIGHWAY.TRAFFIC_SIGNALS},
		{"turning_signal", HIGHWAY.TURNING_SIGNAL},
		{"turning_circle", HIGHWAY.TURNING_CIRCLE},
		{"toll_gantry", HIGHWAY.TOLL_GANTRY},
		{"null", HIGHWAY.NULL}
	};

	public static HIGHWAY parseHighway(string value)
	{
		return parseListHighway[value];
	}
}
