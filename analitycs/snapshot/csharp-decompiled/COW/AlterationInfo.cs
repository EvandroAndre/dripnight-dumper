using System;
using System.Collections.Generic;

namespace COW;

[Serializable]
public class AlterationInfo
{
	public AlterationTarget Target;

	public string RelativeHierarchyPath;

	public string PrefabPath;

	public List<string> ExtraPaths;
}
