using System;
using System.Collections.Generic;

namespace COW.PotentiallyVisible;

[Serializable]
public class PVSItemData
{
	public ushort index;

	public ushort size;

	public List<ushort> cellList;
}
