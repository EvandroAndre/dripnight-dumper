using System;
using System.Collections.Generic;
using UnityEngine;

namespace PrefabEvolution;

[Serializable]
public class PELinkage
{
	[Serializable]
	public class Link
	{
		public int LIIF;

		public UnityEngine.Object InstanceTarget;

		public override string ToString()
		{
			return null;
		}
	}

	public List<Link> Links;

	// C# has no syntax for parameterized property 'Item'.
	public Link get_Item(int liif)
	{
		return null;
	}

	// C# has no syntax for parameterized property 'Item'.
	public Link get_Item(Link link)
	{
		return null;
	}

	// C# has no syntax for parameterized property 'Item'.
	public Link get_Item(UnityEngine.Object obj)
	{
		return null;
	}

	public UnityEngine.Object GetPrefabObject(GameObject prefab, UnityEngine.Object instanceObject)
	{
		return null;
	}
}
