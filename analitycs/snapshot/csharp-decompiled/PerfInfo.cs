using System.Collections.Generic;
using UnityEngine;

public class PerfInfo
{
	public float height;

	public int matNum;

	public HashSet<Material> materials;

	public int drawCallNum;

	public int drawCallNumInTotal;

	public int tris;

	public int trisInTotal;

	public string hint;

	public int warning;
}
