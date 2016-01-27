using UnityEngine;
using System.Collections;
using System.Collections;

public class Room : MonoBehaviour 
{
	public ArrayList doors = new ArrayList();
	int doorCount { get; set;}


	// Use this for initialization
	void Start () 
	{
		this.doorCount = this.doors.Count;
	}
}
