using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(Line))]
public class LineInspector : Editor 
{

	private void OnSceneGUI () {

		//Get Target Line
		Line line = target as Line;

		//Get line's transform
		Transform handleTransform = line.transform;

		//Get Rotation in local space
		Quaternion handleRotation = Tools.pivotRotation == PivotRotation.Local ?
			handleTransform.rotation : Quaternion.identity;

		//Set our point vectors
		Vector3 p0 = handleTransform.TransformPoint (line.p0);
		Vector3 p1 = handleTransform.TransformPoint (line.p1);

		//handle GUI stuff
		Handles.color = Color.green;
		Handles.DrawLine(p0, p1);

		EditorGUI.BeginChangeCheck ();
		p0 = Handles.DoPositionHandle (p0, handleRotation);
		if (EditorGUI.EndChangeCheck ()) 
		{
			Undo.RecordObject (line, "Move Point");
			EditorUtility.SetDirty (line);
			line.p0 = handleTransform.InverseTransformPoint (p0);
		}

		EditorGUI.BeginChangeCheck ();
		p1 = Handles.DoPositionHandle (p1, handleRotation);
		if (EditorGUI.EndChangeCheck ()) 
		{
			Undo.RecordObject (line, "Move Point");
			EditorUtility.SetDirty (line);
			line.p1 = handleTransform.InverseTransformPoint (p1);
		}
	}
}