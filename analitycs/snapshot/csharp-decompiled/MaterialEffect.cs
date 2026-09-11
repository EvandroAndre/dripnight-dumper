using System.Collections.Generic;
using GCommon;
using UnityEngine;

public class MaterialEffect
{
	public static RGBCurve curve;

	public ResourceID curveID;

	internal static readonly int ColorName;

	public float maxTime;

	private List<Material> mats;

	public STimer timer;

	public void Play(List<Material> curMats)
	{
	}

	public bool Update()
	{
		return false;
	}

	private void SetColor(float time)
	{
	}

	public void Release()
	{
	}
}
