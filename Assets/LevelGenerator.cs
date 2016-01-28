using UnityEngine;
using System.Collections;

public class LevelGenerator : MonoBehaviour
{
	/*
	 *Store all the rooms we can use to build our world
 	 */
    public ArrayList rooms = new ArrayList();
 	
 	/*
 	 * We are storing all the doors of every room in an array
 	 * to reduce duplication of the array for later since our
 	 * connection script will want to see all other doors within
 	 * the range of the door it is working on.
 	 */
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
