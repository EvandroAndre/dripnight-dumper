using System.Collections.Generic;
using message;

namespace COW.Gameplay.UGC;

public class UGCV4UpToV5Adapter : UGCBaseVersionAdapter
{
	public class AdapterVehicleInfo
	{
		public int TypeID;

		public int VehicleID;
	}

	public class AdapterVehicleDetailInfo
	{
		public int ID;

		public float EngineTorque;

		public float BrakeTorque;

		public float HighSpeedSteerAngle;

		public float HighSpeedSteerAngleAtSpeed;

		public float IdleBrakeInput;

		public float GearShiftingDelay;

		public float MaxSpeed;

		public float CrashMessFactor;

		public float CrashMaxSpeed;

		public float CrashMinDamage;

		public float CrashMaxDamage;

		public float ExplodeDelay;

		public float ExplodeRange;

		public int ExplodeDamage;

		public float BurnTime;

		public int BurnDamage;

		public float BurnInterval;

		public int HP;
	}

	private readonly Dictionary<uint, AdapterVehicleInfo> m_ItemIDToVehicleIDDict;

	private readonly Dictionary<int, AdapterVehicleDetailInfo> m_ItemIDToVehicleDetailDict;

	private readonly Dictionary<string, int> m_VehicleEntityIDToTypeID;

	private readonly Dictionary<string, int> m_VehicleEntityIDToVehicleID;

	public override void Convert(MFMLHNJCNGB verCtl, JOEANMPIFAB gameData)
	{
	}

	private void UGCVehicleEntityDataV4ToV5(PLMKOPJMIEP oldData, int newTypeID, int vehicleID, AdapterVehicleDetailInfo detailInfo)
	{
	}
}
