using GCommon;

namespace COW;

public class TechDeviceTable : CSVBaseData, IGetId
{
	public string name_key_splice;

	public string decoration_skin;

	public string device_hud_button_hint;

	public int use_type;

	public uint id;

	public ResourceID use_button_icon;

	public uint effect;

	public float cd;

	public uint use_time;

	public uint activity_flag;

	public ResourceID cd_refresh_skin;

	public int type;

	public override string GetPrimaryKey()
	{
		return null;
	}

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

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
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
