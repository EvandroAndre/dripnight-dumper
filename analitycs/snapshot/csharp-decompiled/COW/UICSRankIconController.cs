using GCommon;
using UnityEngine;

namespace COW;

public class UICSRankIconController : UIBaseController
{
	private UICSRankIconView m_View;

	private UIModelCSLadderMatch m_ModelCSLadderMatch;

	private UIModelPeriodicLadderMatch m_ModelPeriodicLadderMatch;

	private ResourceID m_CSRankIconUIFXRes;

	private GameObject m_CSRankIconUIFX;

	private ResourceID m_CrossModeUIFXRes;

	private GameObject m_CrossModeUIFX;

	private bool m_IsReachPeakRank;

	private UISprite[] m_CSStarArray;

	private UISprite[] m_CSBlackStarArray;

	private Vector3 m_NormalIconPos;

	private uint m_CurRankStage;

	private float m_CSGroupSpecialGrandmasterScale;

	private float m_SeasonReplayOverviewTitleScale;

	private Vector3 m_UnderHeroicCrossScale;

	private Vector3 m_ReachHeroicCrossScale;

	private Vector3 m_StarContainerPos;

	private Vector3 m_NormalMaxRankTxtScale;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void SetDefaultStates()
	{
	}

	public void SetCSRankViewData(int rank, int peakRankPos, uint iconDisplayType, uint ladderRankIconType, int rankScore = 0, bool isShowUIFX = false, uint rankMasterLevel = 0u, bool getUIFXFromPool = true, ERankIconSpecialAdaptTypes adaptType = ERankIconSpecialAdaptTypes.None, bool applyPeakRankIconScale = true, Vector3 rankIconOffset = default(Vector3))
	{
	}

	public void SetPeriodicViewData(int rank, int rankScore, uint iconDisplayType, uint ladderRankIconType, ERankIconSpecialAdaptTypes adaptType = ERankIconSpecialAdaptTypes.None)
	{
	}

	private void SetUIViewByRankIconDisplayType(uint type)
	{
	}

	private void SetCSRankIconPos(bool isGrandMaster)
	{
	}

	private void AdaptBySpecialAdaptTypes(ERankIconSpecialAdaptTypes adaptType, bool isGrandMaster = false)
	{
	}

	private void SetStarView(int stars, int num)
	{
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	public static bool DontDestroy()
	{
		return false;
	}

	public void SetCrossModeView(int brRank, ECrossModeDisplayTypes displayType, bool getUIFXFromPool = true)
	{
	}

	public void SetCrossModeViewVisible(bool isVisible)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}
}
