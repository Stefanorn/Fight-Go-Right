using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

[CustomEditor(typeof(MeshRenderer))]
public class MeshRendererSortingLayersEditor : Editor
{
	private List <string> sortingLayerNames = new List<string>();

	public override void OnInspectorGUI()
	{
		base.OnInspectorGUI();
	
		MeshRenderer renderer = target as MeshRenderer;
	
		int previsolayer = renderer.sortingLayerID;

		renderer.sortingLayerID = 1;

		sortingLayerNames.Clear();
		sortingLayerNames.Add ("Default");

		while (renderer.sortingLayerID != 0) 
		{
			sortingLayerNames.Add (renderer.sortingLayerName);
			renderer.sortingLayerID++;
		}

		renderer.sortingLayerID = previsolayer;

//		EditorGUILayout.BeginHorizontal();
//		EditorGUI.BeginChangeCheck();
//		string name = EditorGUILayout.TextField("Sorting Layer Name", renderer.sortingLayerName);
//		if(EditorGUI.EndChangeCheck()) {
//			renderer.sortingLayerName = name;
//		}
//		EditorGUILayout.EndHorizontal();

		EditorGUILayout.BeginHorizontal();
		EditorGUI.BeginChangeCheck();
		int id = EditorGUILayout.Popup("Sorting Layer", renderer.sortingLayerID, sortingLayerNames.ToArray());
		if(EditorGUI.EndChangeCheck()) {
			renderer.sortingLayerID = id;
		}
		EditorGUILayout.EndHorizontal();
		
		EditorGUILayout.BeginHorizontal();
		EditorGUI.BeginChangeCheck();
		int order = EditorGUILayout.IntField("Sorting Order", renderer.sortingOrder);
		if(EditorGUI.EndChangeCheck()) {
			renderer.sortingOrder = order;
		}
		EditorGUILayout.EndHorizontal();
		
	}
}
