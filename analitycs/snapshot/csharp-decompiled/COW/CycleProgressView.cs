using System;
using UnityEngine;
using proto;

namespace COW;

public class CycleProgressView : MilestoneProgressView
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<AwardDesc, BaseItemInfo> _003C_003E9__10_0;

		internal BaseItemInfo _003COnClickRewardBtn_003Eb__10_0(AwardDesc item)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public CycleProgressView _003C_003E4__this;

		public Action<uint> callback;

		internal void _003CPlayUnlockEffect_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public Action closeAction;

		public CycleProgressView _003C_003E4__this;

		internal void _003COnReceiveStageReward_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public CycleProgressView _003C_003E4__this;

		public uint progress;

		public float duration;

		public Action<uint> callback;

		internal void _003CSetProgress_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public float duration;

		public CycleProgressView _003C_003E4__this;

		public Action<uint> callback;

		public float time;

		internal void _003CPlayProgress_003Eb__0()
		{
		}
	}

	public UINetworkTextureExt mCycleRedDotTexture;

	public UILabel mCycleRedDotLabel;

	private GameObject m_UnlockEffect;

	public override void SetData(UIModelBigEvent_Milestone.IProgressInfo info, uint useType, UIModelBigEvent_Milestone.IProgressAnimation anim)
	{
	}

	public override void PlayUnlockEffect(Action<uint> callback)
	{
	}

	public override void OnReceiveStageReward(ExchangeChangeData rewards, Action closeAction)
	{
	}

	protected override void SetStatus(UIModelBigEvent_Milestone.ProgressStatus status, ProgressStatusMode mode)
	{
	}

	public override void SetProgress(uint progress, float duration, bool effect, Action<uint> callback)
	{
	}

	private void PlayProgress(uint progress, float duration, Action<uint> callback)
	{
	}

	protected override void SetRedDotActive(int count)
	{
	}

	protected override void OnClickRewardBtn()
	{
	}

	public void _003C_003EiFixBaseProxy_SetData(UIModelBigEvent_Milestone.IProgressInfo P0, uint P1, UIModelBigEvent_Milestone.IProgressAnimation P2)
	{
	}

	public void _003C_003EiFixBaseProxy_PlayUnlockEffect(Action<uint> P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnReceiveStageReward(ExchangeChangeData P0, Action P1)
	{
	}

	public void _003C_003EiFixBaseProxy_SetStatus(UIModelBigEvent_Milestone.ProgressStatus P0, ProgressStatusMode P1)
	{
	}

	public void _003C_003EiFixBaseProxy_SetProgress(uint P0, float P1, bool P2, Action<uint> P3)
	{
	}

	public void _003C_003EiFixBaseProxy_SetRedDotActive(int P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnClickRewardBtn()
	{
	}
}
