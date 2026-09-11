using System;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class MilestoneProgressView : MonoBehaviour, IUIModelDataChangeObserver
{
	protected enum ProgressStatusMode
	{
		Init,
		Force,
		Pre
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<AwardDesc, BaseItemInfo> _003C_003E9__47_0;

		internal BaseItemInfo _003COnClickRewardBtn_003Eb__47_0(AwardDesc item)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass41_0
	{
		public float duration;

		public Action<uint> callback;

		public MilestoneProgressView _003C_003E4__this;

		public float progress;

		public float time;

		internal void _003CPlayUnlockEffect_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass44_0
	{
		public Action closeAction;

		public MilestoneProgressView _003C_003E4__this;

		internal void _003COnReceiveStageReward_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass46_0
	{
		public float duration;

		public Action<uint> callback;

		public MilestoneProgressView _003C_003E4__this;

		public uint progress;

		public float time;

		internal void _003CSetProgress_003Eb__0()
		{
		}
	}

	public UILabel m_NumLabel;

	public UINetworkTextureExt m_NumTexture;

	public UINetworkTextureExt m_RewardIconTexture;

	public UINetworkTextureExt m_ShareIconTexture;

	public UISlider m_ProgressSlider;

	public UINetworkTextureExt m_BackgroundTexture;

	public UINetworkTextureExt m_ForegroundTexture;

	public UILabel m_MileageLabel;

	public UINetworkTextureExt m_StageBgTexture;

	public UILabel m_ProgressValueLabel;

	public UINetworkTextureExt m_ProgressDiTexture;

	public UINetworkTextureExt m_RedDotTexture;

	public GameObject m_ThumbGo;

	public UINetworkTextureExt m_HighLighTexture;

	public Transform m_EffectParent;

	public UIButton m_RewardBtn;

	public UIButton m_ShareBtn;

	protected Animation m_Animation;

	protected UIModelBigEvent_Milestone.IProgressInfo m_Info;

	protected CustomMilestoneProgressDesc m_ProgressDesc;

	protected UIModelBigEvent_Milestone m_ModelMilestone;

	protected UIModelBigEventTemplate m_ModelBigEventTemplate;

	protected UIModelBigEvent_Milestone.ProgressStatus m_Status;

	protected uint m_Progress;

	protected CustomMilestoneShareDesc m_ShareDesc;

	protected uint m_CurrentUseType;

	protected GameObject m_EffectGo;

	protected GameObject m_HighLighEffectGo;

	protected uint mEffectDelayKey;

	protected UIModelBigEvent_Milestone.IProgressAnimation m_ProgressAnimation;

	protected string m_strNumTextureUrl;

	protected string m_strRewardIconTextureUrl;

	protected bool m_FirstShare;

	public uint StageId => 0u;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	protected virtual void OnUIInit()
	{
	}

	protected virtual void OnUIDestroy()
	{
	}

	public virtual void SetData(UIModelBigEvent_Milestone.IProgressInfo info, uint useType, UIModelBigEvent_Milestone.IProgressAnimation anim)
	{
	}

	public virtual void PlayUnlockEffect(Action<uint> callback)
	{
	}

	protected virtual void SetStatus(UIModelBigEvent_Milestone.ProgressStatus status, ProgressStatusMode mode)
	{
	}

	public Vector3 GetThumbPosition()
	{
		return default(Vector3);
	}

	public virtual void OnReceiveStageReward(ExchangeChangeData rewards, Action closeAction)
	{
	}

	protected virtual void PlayerRewardAndShareSwitchAnim()
	{
	}

	public virtual void SetProgress(uint progress, float duration, bool effect, Action<uint> callback)
	{
	}

	protected virtual void OnClickRewardBtn()
	{
	}

	protected virtual void OnClickShareBtn()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	protected virtual void SetShareActive(bool active)
	{
	}

	protected virtual void SetEffectActive(bool active)
	{
	}

	protected virtual void SetThumbActive(bool active)
	{
	}

	protected virtual void SetRedDotActive(int count)
	{
	}

	protected virtual void SetRewardIconTextureState(UINetworkTexture texture, UIModelBigEvent_Milestone.ProgressStatus status)
	{
	}

	protected void SetTween(GameObject go, bool active)
	{
	}

	protected void SetUINetworkTexture(UINetworkTexture texture, string url)
	{
	}

	protected AnimationClip GetAnimationClip(Animation anim)
	{
		return null;
	}

	private void _003CPlayerRewardAndShareSwitchAnim_003Eb__45_0()
	{
	}
}
