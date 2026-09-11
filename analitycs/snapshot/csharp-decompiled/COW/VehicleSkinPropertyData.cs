using System.Collections.Generic;
using GCommon;

namespace COW;

public class VehicleSkinPropertyData : CSVBaseData
{
	public uint SkinID;

	public uint VehicleID;

	public string Region;

	public bool IsTaillight;

	public string HornAudioRes;

	public string StartSoundRes;

	public string ShiftSoundRes;

	public string HighAccRes;

	public string DeadEffectRes;

	public string DeadSoundRes;

	public string DeadSmokeLoopSoundRes;

	public Dictionary<string, TssSdtFloat> Params;

	public const string PROPERTYTYPE_MAXSPEED = "max_speed";

	public const string PROPERTYTYPE_REDUCEDAMGE = "reduce_damage";

	public const string PROPERTYTYPE_HIGHTSPEEDANGLE = "high_speed_steerangle";

	public const string PROPERTYTYPE_ENGINETORQUE = "engine_torque";

	public const string PROPERTYTYPE_BRAKETORQUE = "brake_torque";

	public const string PROPERTYTYPE_BOOSTDURATION = "boost_duration";

	public const string PROPERTYTYPE_BOOSTCD = "boost_cd";

	public const string PROPERTYTYPE_JUMPHEIGHT = "jump_height";

	public const string PROPERTYTYPE_JUMPCD = "jump_cd";

	public const string PROPERTYTYPE_ENABLEMARK = "mark_leave";

	public const string PROPERTYTYPE_MESSFACTOR = "mess_factor";

	public const string PROPERTYTYPE_CHIP_REDUCE_MAX_SPEED = "vehicle_chip_fortress_reduce_maxspeed";

	public const string PROPERTYTYPE_INV_CHANGE_SPEED_ZONE = "vehicle_inv_change_speed_zone";

	public static string[] PROPERTYTYPE_SHOWLIST;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
