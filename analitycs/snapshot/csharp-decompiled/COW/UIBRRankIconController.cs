using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIBRRankIconController : UIBaseController
{
	private UIBRRankIconView m_View;

	private ResourceID m_BRRankIconUIFXRes;

	private GameObject m_BRRankIconUIFX;

	private ResourceID m_CrossModeUIFXRes;

	private GameObject m_CrossModeUIFX;

	private UIModelLadderMatch m_ModelLadderMatch;

	private List<GameObject> m_ListGoStars;

	private Vector3 m_NormalIconPos;

	private bool m_IsReachPeakRank;

	private float m_BRGroupSpecialGrandmasterScale;

	private float m_SeasonReplayOverviewTitleScale;

	private uint m_CurRankStage;

	private Vector3 m_UnderHeroicCrossScale;

	private Vector3 m_ReachHeroicCrossScale;

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

	public void SetBRRankViewData(int rank, int peakRankPos, uint iconDisplayType, uint ladderRankIconType, int rankScore = 0, bool isShowUIFX = false, uint rankMasterLevel = 0u, bool getUIFXFromPool = true, ERankIconSpecialAdaptTypes adaptType = ERankIconSpecialAdaptTypes.None, bool applyPeakRankIconScale = true, Vector3 rankIconOffset = default(Vector3))
	{
	}

	private void AdaptBySpecialAdaptTypes(ERankIconSpecialAdaptTypes adaptType, bool isGrandMaster = false)
	{
	}

	private void SetBRRankIconPos(bool isGrandMaster)
	{
	}

	private void SetStarView(int rank, int rankScore)
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

	public void SetCrossModeView(int csRank, ECrossModeDisplayTypes displayType, bool getUIFXFromPool = true)
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
