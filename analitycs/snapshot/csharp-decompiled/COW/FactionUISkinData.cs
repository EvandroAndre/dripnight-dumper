using GCommon;

namespace COW;

public class FactionUISkinData : CSVBaseData, IGetId
{
	public string TeamScoreLeftBGColorLeft;

	public ResourceID[] CustomSpawnAreaFences;

	public string TeamScoreLeftLineColorLeft;

	public string FactionMyTeamVFXTextureColor;

	public string TrasitionNextVFXColor;

	public string TransitionScoreVFXBoomRightColor4;

	public string TransitionScoreVFXBoomRightColor3;

	public string TransitionScoreVFXBoomRightColor2;

	public string TransitionScoreVFXBoomRightColor1;

	public string TransitionScoreVFXBoomLeftColor4;

	public string TransitionScoreVFXBoomLeftColor3;

	public string TransitionScoreVFXBoomLeftColor2;

	public string FactionOppoTeamVFXTextureColor;

	public string TransitionScoreVFXBoomLeftColor1;

	public string TeamScoreLeftLineColorRight;

	public string FactionOppoTeamLineColorRight;

	public string FactionOppoTeamLineColorLeft;

	public string FactionOppoTeamBgColorRight;

	public string FactionOppoTeamBgColorLeft;

	public string FactionMyTeamLineColorRight;

	public string FactionMyTeamLineColorLeft;

	public string FactionMyTeamBgColorRight;

	public string TeamScoreRightBGColorLeft;

	public string TopScoreRightColor;

	public string TopScoreLeftColor;

	public string TeamScoreRightLineColorRight;

	public string TeamScoreRightBGColorRight;

	public string TeamScoreRightLineColorLeft;

	public string FactionMyTeamBgColorLeft;

	public string TeamScoreLeftBGColorRight;

	public ResourceID Banner;

	public ResourceID HeadPic;

	public uint MatchMode;

	public uint ID;

	public uint GameMode;

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

	public bool NeedChangeHeadPic()
	{
		return false;
	}

	public bool HasCSPeakFenceRes()
	{
		return false;
	}

	public ResourceID GetCSPeakTeamFenceRes(uint teamIndex)
	{
		return default(ResourceID);
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
