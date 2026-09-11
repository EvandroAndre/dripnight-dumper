using System;
using UnityEngine;

namespace COW.DynamicPVS;

public class DynamicPVSEventHandler
{
	public Transform root;

	public bool isBounds;

	public Vector3 size;

	public float boundsCenterOffset;

	public float ignoreGroundHeight;

	public Action<bool> callBack;

	public DynamicPVSType type;

	public bool isVisible;

	public bool isValid => false;

	public Bounds Bounds => default(Bounds);

	public void Clear()
	{
	}
}
