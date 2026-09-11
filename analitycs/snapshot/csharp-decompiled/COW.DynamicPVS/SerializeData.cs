using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace COW.DynamicPVS;

public class SerializeData
{
	public Vector3 BakerPosition;

	public int BakerPortalYCount;

	public float PortalYSize;

	public float BakerBoundsSize;

	public float PortalSize;

	public float ReferenceHeight;

	public List<short> RemapHeights;

	public List<List<int>> PortalVisibilities;

	public void Serialize(BinaryWriter writer)
	{
	}

	public void Deserialize(BinaryReader reader)
	{
	}
}
