using GCommon;

namespace COW;

public class WeaponAimAssistAutoAbsorbData : CSVBaseData, IGetId
{
	public uint[] auto_type;

	public float[] max_range;

	public uint scale_end_distance;

	public uint scale_start_distance;

	public uint obj_type;

	public uint max_count;

	public float scale_param;

	public float max_distance;

	public uint priority_algorithm_space;

	public uint weapon_id;

	public uint GetId()
	{
		return 0u;
	}

	public override uint GetUIntKey()
	{
		return 0u;
	}

	public override int GetIntKey()
	{
		return 0;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public uint _003C_003EiFixBaseProxy_GetUIntKey()
	{
		return 0u;
	}

	public int _003C_003EiFixBaseProxy_GetIntKey()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
