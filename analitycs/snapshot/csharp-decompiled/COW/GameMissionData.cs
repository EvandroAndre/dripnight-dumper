using GCommon;

namespace COW;

public class GameMissionData : CSVBaseData, IGetId
{
	public int HippoCrisisCount;

	public int CoinCount;

	public bool ShowCountdown;

	public string Description;

	public string TypeName;

	public string Parameters;

	public string TypeColor;

	public string[] group_mode;

	public string reward_description;

	public string[] Rewards;

	public string MachineDescription;

	public ResourceID FailureEffect;

	public ResourceID ActivationSound;

	public float Param2;

	public float Param1;

	public uint Type;

	public uint ID;

	public float TimeLimit;

	public float StartTime;

	public ResourceID FailureSound;

	public ResourceID IconRes;

	public ResourceID VictorySound;

	public ResourceID ActivationEffect;

	public ResourceID VictoryEffect;

	public bool HideCountdown;

	public bool ShowInPC;

	public override bool AfterParseData()
	{
		return false;
	}

	private int GetCount(string[] infos)
	{
		return 0;
	}

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

	public bool _003C_003EiFixBaseProxy_AfterParseData()
	{
		return false;
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
