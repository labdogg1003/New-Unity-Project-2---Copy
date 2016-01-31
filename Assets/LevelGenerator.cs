using UnityEngine;
using System.Collections;

public class LevelGenerator : MonoBehaviour
{
	bool generated;

	/*
	 * Store all the rooms we can use to build our world
	 * these will be initialized as children later.
 	 */
    public ArrayList rooms = new ArrayList();

	/*
	 * A list of the rooms that we have instantiated in our level.
	 * These are the children of our generator.
	 */
	public ArrayList instantiatedRooms = new ArrayList();

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
		/* TODO : search our directory for a save file for the level
         * This will set generated to true if we have already generated
         * the level. for now, no check
		 */

		//Check if we have already generated the level
		if(generated == false)
		{
			//First Grab a list of all our rooms : THIS WILL CAUSE ERRORS rooms != children instantitated
    		//foreach(Room room in rooms)   
       		//{
        		//foreach (Door door in rooms) 
	  			//{
	   				//get all doors of all rooms
					//doors.Add(door);
   				//}
    	    //}
		}
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}


}
