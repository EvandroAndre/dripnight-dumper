using System;
using System.Collections.Generic;

namespace PrefabEvolution;

[Serializable]
public class ExposedPropertyGroup : BaseExposedData
{
	public static Dictionary<int, bool> expandedDict;

	private bool expandedLoaded;

	private bool expanded;

	public bool Expanded
	{
		get
		{
			return false;
		}
		set
		{
		}
	}
}
