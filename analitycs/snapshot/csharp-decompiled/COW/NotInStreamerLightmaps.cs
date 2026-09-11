using System;
using System.Collections.Generic;

namespace COW;

[Serializable]
public class NotInStreamerLightmaps
{
	public List<int> LightmapIDs;

	public List<string> Lightmaps;

	public List<string> ShadowMasks;

	public NotInStreamerLightmaps()
	{
	}

	public NotInStreamerLightmaps(int cap)
	{
	}
}
