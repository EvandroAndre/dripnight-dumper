using System;
using System.Collections.Generic;

[Serializable]
public class RepalceSceneLightMapConfig
{
	public int allLightmapsNum;

	public List<ReplaceSceneMapping> mapping;

	public List<LightmapAreaInfoNoRef> areaLightmapsFromFile;

	public List<ReplaceSceneTextureList> allLightmaps;
}
