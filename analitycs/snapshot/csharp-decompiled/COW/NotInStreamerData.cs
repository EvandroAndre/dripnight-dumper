using System;
using System.Collections.Generic;

namespace COW;

[Serializable]
public class NotInStreamerData
{
	public string HierarchyPath;

	public MapPatchTarget Target;

	public string AssetPath;

	public List<string> AssetPathList;

	public List<ABSceneLightMapInfo> LmInfos;
}
