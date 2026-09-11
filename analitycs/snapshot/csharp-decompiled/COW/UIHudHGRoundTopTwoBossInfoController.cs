using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIHudHGRoundTopTwoBossInfoController : UIBaseController
{
	private UIHudHGRoundTopTwoBossInfoView m_View;

	private const float Const_finalCountDownTimeSec = 5f;

	private BNEFLFAMOCE m_RoundType;

	private bool m_IsShowBoss;

	private bool m_IsShowProgress;

	private float m_EndTimeSec;

	private UITimeLabelHelper m_NormalTimeHelper;

	private bool m_IsBossHPUpdated;

	private ulong m_CurBossID;

	private int m_OneLayerMaxHP;

	private int m_CurBossRealHP;

	private bool m_IsShowedFinalCountDown;

	private bool m_IsNeedShowFinalCountDown;

	public float HPAnimDereaseSpeed;

	public int TriggerAnimHPDereaseNum;

	private int m_CurBossAnimHP;

	private int m_CurAnimHPLayerIndex;

	private int m_CurRealHPLayerIndex;

	private bool m_IsPlayingBossHPAnim;

	private List<Color> m_HPColorList;

	private int m_ColorListCount;

	private Color m_OrgProgressColor;

	private bool IsPlayingBossHPAnim
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void UpdateShowdata(HGRoundTopDataParam showParam)
	{
	}

	private void SetNormalRoundStyle(HGRoundTopDataParam showParam)
	{
	}

	protected override void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void UpdateNormalRound()
	{
	}

	private void UpdateShowFinalCountDown()
	{
	}

	private void UpdateProgress()
	{
	}

	private void OnBossDead(ulong bossUID)
	{
	}

	private void OnBossOneLayerHPCome(int oneLayerHP)
	{
	}

	private void OnBossHPChange(object[] data)
	{
	}

	private void OnBossChange(object[] data)
	{
	}

	private void SetBossHPStaticShow()
	{
	}

	private void UpdateBossHpProgress()
	{
	}

	private int CalcHpLayerIndex(int hp)
	{
		return 0;
	}

	private float GetHpProgressValue(int hp)
	{
		return 0f;
	}

	private void UpdateHpLayerCountAndColor(int curLayerIndex)
	{
	}

	private void OpenScoreBoard()
	{
	}

	private void OnDragonHeadDead(ulong playerID)
	{
	}

	private void OnDragonHeadRebornEnd(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
