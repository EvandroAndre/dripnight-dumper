using GCommon;

namespace COW;

public class SpectateHighligntLike : CSVBaseData, IGetId
{
	public enum EHighlikeID
	{
		FirstBlood = 1,
		TripleKill,
		QuadKill,
		HeadShot,
		FinishHuntMission,
		AntiKill,
		KillByCar
	}

	private sealed class _003C_003Ec__DisplayClass1_0
	{
		public uint curGameMode;

		internal bool _003CCheckCanShowByMode_003Eb__0(string element)
		{
			return false;
		}
	}

	public uint HighlightID;

	public uint Priority;

	public string Mode;

	public string Buttondesc;

	public uint ClickLimit;

	public ResourceID UIButtonicon;

	public bool CheckCanShowByMode()
	{
		return false;
	}

	public static uint TypeConvertToID(UIHudThumbUpChatBtnController.EThumbUpType thumbUpType)
	{
		return 0u;
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
