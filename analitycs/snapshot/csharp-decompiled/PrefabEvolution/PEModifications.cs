using System;
using System.Collections.Generic;
using UnityEngine;

namespace PrefabEvolution;

[Serializable]
public class PEModifications
{
	[Serializable]
	public class PropertyData
	{
		public enum PropertyMode
		{
			Default,
			Keep,
			Ignore
		}

		public UnityEngine.Object Object;

		public int ObjeckLink;

		public string PropertyPath;

		public PropertyMode Mode;

		public object UserData;
	}

	[Serializable]
	public class HierarchyData
	{
		public Transform child;

		public Transform parent;
	}

	[Serializable]
	public class ComponentsData
	{
		public Component child;

		public GameObject parent;
	}

	public List<PropertyData> Modificated;

	public List<HierarchyData> NonPrefabObjects;

	public List<ComponentsData> NonPrefabComponents;

	public List<int> RemovedObjects;

	public List<HierarchyData> TransformParentChanges;
}
