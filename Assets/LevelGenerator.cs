using UnityEngine;
using System.Collections;

public class LevelGenerator : MonoBehaviour
{
    public ArrayList rooms = new ArrayList();
 	
 	/*
 	 * 
 	 * 
 	 * /
    public ArrayList doors = new ArrayList();

	// Use this for initialization
	void Start ()
    {
    	foreach(Room room in rooms)   
        {
        	foreach (Door door in room) 
	  		{
	   			//get all doors of all rooms
				doors.Add(door);
   			}
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
