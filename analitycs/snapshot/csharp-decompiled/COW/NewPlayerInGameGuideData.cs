using GCommon;

namespace COW;

public class NewPlayerInGameGuideData : CSVBaseData
{
	public TutorialUIType DisplayType;

	public uint[] LinkBotagentECAId;

	public uint[] MatchMode;

	public string StringDisplayType;

	public uint[] GameMode;

	public uint[] GroupMode;

	public uint[] ShowToNewbieChoice;

	public string HintText;

	public int IntEventType;

	public float Shrink;

	public int DisplaySubType;

	public int DepthType;

	public float HideDelay;

	public bool CanShowInWaitingRoom;

	public bool OpenToNewBie;

	public bool IsOpen;

	public bool AboveBigMap;

	public bool ShowEveryLauncher;

	public bool AbovePopup;

	public bool TapOnEmptyClose;

	public TutorialEventEnum EventType => TutorialEventEnum.None;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
	}

	public override void PostDeserializeData()
	{
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_PostDeserializeData()
	{
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
