using System;
using UnityEngine;

public class VehicleConfig : MonoBehaviour
{
	[Serializable]
	public class CarCrashParam
	{
		public float messFactor;

		public float maxSpeed;

		public float minDamage;

		public float maxDamage;
	}

	[Serializable]
	public class CarExplodeParam
	{
		public float ExplodeDelay;

		public float ExplodeRange;

		public uint ExplodeDamage;

		public float BurnTime;

		public BoxCollider BurnRange;

		public uint BurnDamage;

		public float BurnInterval;
	}

	public EControlMode conrolMode;

	public CarCrashParam crashParam;

	public CarExplodeParam ExplodeParam;

	public CarInWaterParam InWaterParam;

	public VehicleInteractWorldTrigger InteractWorldTrigger;
}
