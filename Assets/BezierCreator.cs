using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BezierCreator : MonoBehaviour
{
	public GameObject[] Rooms;
	public List<Vector3> points;
	private BezierCurve curve;


	// Use this for initialization
	void Start () 
	{
		foreach (GameObject o in Rooms) 
		{
			points.Add( o.transform.Find ("Node").transform.position);

		}	

		getDistance (points [0], points [1]);
		//points.add(points[0].x)

		//Line line;
		//line.p0 = points [0];
		//line.p1 = points [1];

		Debug.DrawLine (points [0], points [1]);
		this.GetComponent<LineRenderer> ().SetPosition (0, points [0]);
		this.GetComponent<LineRenderer> ().SetPosition (1, points [1]);
	}
	
	// Update is called once per frame
	void Update () 
	{
	}

	public float[] getDistance(Vector3 p1, Vector3 p2)
	{
		float[] distance = new float[3];
		distance[0] = Mathf.Abs(p1.x - p2.x);
		distance[1] = Mathf.Abs(p1.y - p2.y);
		distance[2] = Mathf.Abs(p1.z - p2.z);

		Debug.Log ("X : " + distance[0] );
		Debug.Log ("Y : " + distance[1] );
		Debug.Log ("Z : " + distance[2] );

		return distance;
	}
}
