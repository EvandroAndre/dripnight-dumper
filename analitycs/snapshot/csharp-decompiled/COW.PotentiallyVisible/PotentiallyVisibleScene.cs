using System.Collections.Generic;
using UnityEngine;

namespace COW.PotentiallyVisible;

public class PotentiallyVisibleScene : ScriptableObject
{
	public string RootNode;

	public int CenterX;

	public float CenterY;

	public int CenterZ;

	public int SizeX;

	public float SizeY;

	public int SizeZ;

	public int TotalTransCount;

	public List<PVSItemData> portalList;
}
