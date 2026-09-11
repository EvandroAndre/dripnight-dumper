using System;
using UnityEngine;
using proto;

namespace COW;

[Serializable]
public class SparkPetStageBoxColliderSettings
{
	public Vector3 activeCenter;

	public Vector3 activeSize;

	public Vector3 dormantCenter;

	public Vector3 dormantSize;

	public Vector3 extinguishedCenter;

	public Vector3 extinguishedSize;

	public Vector3 GetCenterByState(EFriend.SparkState sparkState)
	{
		return default(Vector3);
	}

	public Vector3 GetSizeByState(EFriend.SparkState sparkState)
	{
		return default(Vector3);
	}
}
