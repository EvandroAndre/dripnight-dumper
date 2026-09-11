using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIHudHGRoundTopInfoController : UIBaseController
{
	private UIHudHGRoundTopInfoView m_View;

	private const float Const_finalCountDownTimeSec = 5f;

	private const float Const_WarningLeftTimeSec = 30f;

	private BNEFLFAMOCE m_RoundType;

	private bool m_IsShowBoss;

	private bool m_IsShowProgress;

	private int m_ZombieNum;

	private float m_EndTimeSec;

	private UITimeLabelHelper m_NormalTimeHelper;

	private UITimeLabelHelper m_SurviveTimeHelper;

	private bool m_IsKilledZombieCountUpdated;

	private int m_KilledZombieCount;

	private bool m_IsBossHPUpdated;

	private int m_OneLayerMaxHP;

	private int m_CurBossRealHP;

	private bool m_IsShowedFinalCountDown;

	private bool m_IsNeedShowFinalCountDown;

	private bool m_IsShowedLeftTimeWarning;

	private bool m_IsNeedShowLeftTimeWarning;

	public float HPAnimDereaseSpeed;

	public int TriggerAnimHPDereaseNum;

	private int m_CurBossAnimHP;

	private int m_CurAnimHPLayerIndex;

	private int m_CurRealHPLayerIndex;

	private bool m_IsPlayingBossHPAnim;

	private List<Color> m_HPColorList;

	private int m_ColorListCount;

	private Color m_OrgProgressColor;

	private uint m_FightBeginEffectDelaycallID;

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

	private void OnKilledZombieCountChange(object[] data)
	{
	}

	public void UpdateShowdata(HGRoundTopDataParam showParam)
	{
	}

	private void SetSurviveRoundStyle()
	{
	}

	private void SetNormalRoundStyle(HGRoundTopDataParam showParam)
	{
	}

	private void PlayFightBeginEffect()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void CancelDelayCall()
	{
	}

	private void Update()
	{
	}

	private void UpdateSurviveRound()
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

	private void OnBossOneLayerHPCome(int oneLayerHP)
	{
	}

	private void OnBossHPChange(object[] data)
	{
	}

	private void OnWaveChange(object[] data)
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

	private void UpdateKilledCountProgress()
	{
	}

	private void OpenScoreBoard()
	{
	}

	private void _003CPlayFightBeginEffect_003Eb__38_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
