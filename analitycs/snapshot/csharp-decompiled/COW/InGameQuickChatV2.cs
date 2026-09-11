using GCommon;

namespace COW;

public class InGameQuickChatV2 : CSVBaseData, IGetId
{
	public uint[] MatchMode;

	public uint[] GameMode;

	public string SmartBubbleKey;

	public string TeammatesKey;

	public ResourceID SmartBubbleIcon;

	public float param2;

	public uint Sort;

	public float param1;

	public uint Priority;

	public uint AutoMark;

	public uint id;

	public uint type;

	public float SmartBubbleDuration;

	public float TeamBroadCD;

	public float CD;

	public float param3;

	public uint ChatID;

	public float SoundDistance;

	public uint AutoPlay;

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
