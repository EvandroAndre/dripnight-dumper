using GCommon;

namespace COW;

public class NewPlayerGuideData : CSVBaseData
{
	public int Precdt1;

	public int Precdt_value1;

	public int Precdt2;

	public int Precdt_value2;

	public int Precdt3;

	public int Precdt_value3;

	public int Precdt4;

	public int Precdt_value4;

	public int GuideId;

	public string GuideIntroKey;

	public bool OpenToNewbie;

	public bool IsOpen;

	public bool IsForceClickFinish;

	public bool IsShowWithMask;

	public bool IsUseBackendFlag;

	public uint[] NextGuideIds;

	public int LobbyEntranceShowPrority;

	public bool UncloseIfShowNewGuide;

	public bool DefaultShowedIfNotGetData;

	public bool IsShowWhenTakePhotoState;

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
