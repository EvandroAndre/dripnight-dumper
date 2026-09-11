using System;
using UnityEngine;

namespace COW.Gameplay.UGC;

[Serializable]
public class UGCTutorialCameraPoseData
{
	public bool hasPosition;

	public Vector3 position;

	public bool hasRotation;

	public Vector3 rotationEuler;

	public string cameraMode;

	public string projection;

	public bool HasAnyConfig()
	{
		return false;
	}
}
