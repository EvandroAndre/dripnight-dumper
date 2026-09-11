using System;
using GCommon;
using UnityEngine;

namespace COW.GamePlay;

[Serializable]
public class VehicleUpgradeSetting
{
	public GameObject Model;

	public Transform EffectAnchor;

	public string EffectResID;

	public ResourceID ResID;

	public string SoundResID;

	public ResourceID SoundRes;
}
