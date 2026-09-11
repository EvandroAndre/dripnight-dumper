using System;
using System.Collections.Generic;

namespace COW.PotentiallyVisible;

[Serializable]
public class TileData
{
	public List<PortalData> shared64portalList;

	public List<PortalData> shared16portalList;

	public List<PortalData> sharedportalList;

	public List<PortalData> portalList;
}
