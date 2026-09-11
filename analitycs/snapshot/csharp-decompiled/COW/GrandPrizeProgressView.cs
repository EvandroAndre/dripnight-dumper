using System;
using GCommon;
using UnityEngine;

namespace COW;

public class GrandPrizeProgressView : MilestoneProgressView
{
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public GrandPrizeProgressView _003C_003E4__this;

		public Action<uint> callback;

		public float time;

		public float duration;

		internal void _003CPlayUnlockEffect_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public GrandPrizeProgressView _003C_003E4__this;

		public Action<uint> callback;

		internal void _003CPlayUnlockEffectVFX_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass31_0
	{
		public float duration;

		public GrandPrizeProgressView _003C_003E4__this;

		public Action<uint> callback;

		public float time;

		internal void _003CSetProgress_003Eb__0()
		{
		}
	}

	public GameObject m_NormalGo;

	public GameObject m_GrandPrizeGo;

	public UILabel m_GrandPrizeNameText;

	public Transform m_GrandPrizeStageLockEffectParent;

	public UINetworkTextureExt m_GrandPrizeProgressTexture;

	public UINetworkTextureExt m_GrandPrizeRedDotTexture;

	public Transform m_GrandPrizeEffectParent;

	public UINetworkTextureExt m_GrandPrizeRewardIconTexture;

	public UINetworkTextureExt m_GrandPrizeShareIconTexture;

	public UIButton m_GrandPrizeRewardBtn;

	public UIButton m_GrandPrizeShareBtn;

	public UINetworkTextureExt m_GrandPrizeStageBgTexture;

	public UITable m_LockTable;

	public GameObject m_StageLockStageGo;

	public GameObject m_TimeLockStageGo;

	public UILabel m_StageLockStageConditionText;

	public UILabel m_TimeLockStageConditionText;

	public UINetworkTexture m_ConditionBgTexture;

	public AnimatedFillAmount m_ConditionBgFillAmount;

	public AnimatedAlpha m_StageLockEffectAnimatedAlpha;

	private GameObject m_StageLockEffectGo;

	private GameObject m_UnlockEffect;

	private UIModelBigEvent_Milestone.GrandPrizeProgressInfo.LockType m_LockType;

	private string m_GrandPrizeProgressUrl;

	protected Animation m_GrandPrizeAnimation;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void SetData(UIModelBigEvent_Milestone.IProgressInfo info, uint useType, UIModelBigEvent_Milestone.IProgressAnimation anim)
	{
	}

	public override void PlayUnlockEffect(Action<uint> callback)
	{
	}

	private void PlayUnlockEffectVFX(Action<uint> callback)
	{
	}

	protected override void SetStatus(UIModelBigEvent_Milestone.ProgressStatus status, ProgressStatusMode mode)
	{
	}

	public override void SetProgress(uint progress, float duration, bool effect, Action<uint> callback)
	{
	}

	protected override void PlayerRewardAndShareSwitchAnim()
	{
	}

	private void Update()
	{
	}

	private void SetGrandPrizeProgressStatus(bool bLock, UIModelBigEvent_Milestone.GrandPrizeProgressInfo.LockType lockType = UIModelBigEvent_Milestone.GrandPrizeProgressInfo.LockType.ALL)
	{
	}

	protected override void SetShareActive(bool active)
	{
	}

	protected override void SetEffectActive(bool active)
	{
	}

	protected override void SetRedDotActive(int count)
	{
	}

	private void ConditionBgTextureAdapt()
	{
	}

	private void _003CPlayerRewardAndShareSwitchAnim_003Eb__32_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_SetData(UIModelBigEvent_Milestone.IProgressInfo P0, uint P1, UIModelBigEvent_Milestone.IProgressAnimation P2)
	{
	}

	public void _003C_003EiFixBaseProxy_PlayUnlockEffect(Action<uint> P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetStatus(UIModelBigEvent_Milestone.ProgressStatus P0, ProgressStatusMode P1)
	{
	}

	public void _003C_003EiFixBaseProxy_SetProgress(uint P0, float P1, bool P2, Action<uint> P3)
	{
	}

	public void _003C_003EiFixBaseProxy_PlayerRewardAndShareSwitchAnim()
	{
	}

	public void _003C_003EiFixBaseProxy_SetShareActive(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetEffectActive(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetRedDotActive(int P0)
	{
	}
}
