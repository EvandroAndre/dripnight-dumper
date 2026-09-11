using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudPlayerRemainingInfoController : UIBaseController, IUIModelDataChangeObserver
{
	private UIHudPlayerRemainingInfoView m_View;

	private UIModelMatch m_MatchModel;

	private bool m_ShowKda;

	private InfoStyle m_InfoStyle;

	private int m_AliveCount;

	private bool m_IsShowRating;

	private UIHudBigHeadScoreInfoController m_BigHeadScoreCtrl;

	private uint PlayerRatingLvImproveGoldVFXDelayCall;

	private uint PlayerRatingLvImproveSilveryVFXDelayCall;

	private uint PlayerRatingHighImproveVFXDelayCall;

	public bool IsShowRating => false;

	public List<Transform> GetRemainInfoList()
	{
		return null;
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	public static bool DontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	private void OnSwitchObserver(object[] param)
	{
	}

	private void OnBRRatingChange(GEvent gEvent)
	{
	}

	private void PlayerRatingLvImproveGoldVFX(float delta)
	{
	}

	private void PlayerRatingLvImproveSilveryVFX(float delta)
	{
	}

	private void PlayerRatingHighImproveVFX(float delta)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override void OnRecyle()
	{
	}

	private void HideObject()
	{
	}

	private void ResetCntLabel()
	{
	}

	public void OnHideTheUIView(object[] param)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void OnTrainingZonePlayerCntChange(object[] data)
	{
	}

	public void InitGameModeStyle()
	{
	}

	public void RefreshInfoStyle(InfoStyle infoType)
	{
	}

	private void RefreshAlive_Kill()
	{
	}

	public void SetRemainLabel(string transfer)
	{
	}

	private void SetScoreText(string transfer)
	{
	}

	private void UpdateKillCnt(int cnt, bool isNeedCheckMax = true)
	{
	}

	private void UpdateRatingNum(float rating)
	{
	}

	private void UpdateKDACnt(float cnt)
	{
	}

	private void UpdateAliveCnt(int cnt)
	{
	}

	private void UpdateEnemyCnt(int cnt)
	{
	}

	private void ShowTutorial(object[] data)
	{
	}

	private void OnSettingNoHudNotify(object[] data)
	{
	}

	private void OnScoreChanged(object[] data)
	{
	}

	private void OnShowFateRandomGuide(object[] data)
	{
	}

	private void OnSPSwitchOB(object[] data)
	{
	}

	private void _003CPlayerRatingLvImproveGoldVFX_003Eb__20_0()
	{
	}

	private void _003CPlayerRatingLvImproveSilveryVFX_003Eb__21_0()
	{
	}

	private void _003CPlayerRatingHighImproveVFX_003Eb__22_0()
	{
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
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

	public void _003C_003EiFixBaseProxy_OnRecyle()
	{
	}
}
