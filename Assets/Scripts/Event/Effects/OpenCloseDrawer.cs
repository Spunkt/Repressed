﻿using UnityEngine;
using System.Collections;

/* Discription: Trigger component for opening and closing doors to fixed angles
 * 
 * Created by: Robert 23/04-14
 * Modified by: 
 * 
 */

public class OpenCloseDrawer :  TriggerComponent
{
	public void CloseDoor(Id obj)
	{
		float angle = obj.GetComponent<RotationLimit>().m_Rotation.y;
		
		if(obj.gameObject.GetComponent<RotationLimit>())
		{
			angle = obj.gameObject.GetComponent<RotationLimit>().CheckRotation(-angle, "y");
		}
		
		obj.transform.Rotate (new Vector3 (0, 1, 0), angle,Space.Self);
	}
	
	public void OpenDoor(Id obj, float angle)
	{
		CloseDoor (obj);
		
		if(obj.gameObject.GetComponent<RotationLimit>())
		{
			angle = obj.gameObject.GetComponent<RotationLimit>().CheckRotation(angle, "y");
		}
		
		obj.transform.Rotate(new Vector3 (0, 1, 0),angle,Space.Self);
	}
	
	override public string Name
	{ get{return"OpenCloseDoor";}}

}
