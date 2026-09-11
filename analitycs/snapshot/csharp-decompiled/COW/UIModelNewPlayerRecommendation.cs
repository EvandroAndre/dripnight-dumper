using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIModelNewPlayerRecommendation : UIBaseModel
{
	public const uint PropID_RefreshNewPlayerRecommendationInfo = 1u;

	public bool NewPlayerRecommendationShowSwitch;

	public bool NeedRefreshNewPlayerData;

	private List<SceneEditSlotInfo> m_NewPlayerRecDataList;

	public bool GetNewPlayerRecommendationActive()
	{
		return false;
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public void RequestNewPlayerRecommendationInfo()
	{
	}

	public void UpdateNewPlayerRecommendationExpireTime()
	{
	}

	public int GetNewPlayerRecommendationExpireTimeStamp()
	{
		return 0;
	}

	public List<SceneEditSlotInfo> GetNewPlayerRecommendationData()
	{
		return null;
	}

	public override void Logout(object[] data)
	{
	}

	private void _003CRequestNewPlayerRecommendationInfo_003Eb__6_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
