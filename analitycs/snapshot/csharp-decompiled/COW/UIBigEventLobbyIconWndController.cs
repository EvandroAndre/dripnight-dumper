using GCommon;
using UnityEngine;

namespace COW;

public abstract class UIBigEventLobbyIconWndController : UIPopupWindowController
{
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public UIBigEventLobbyIconWndController _003C_003E4__this;

		public UIBigEventLobbyEntranceBaseController banner;

		internal void _003CExecuteFlyEffect_003Eb__0()
		{
		}
	}

	private uint m_AnimKey;

	private uint m_DelayCloseKey;

	protected Animation wndAnimation;

	protected EffectMovement flyMovement;

	protected bool m_EnableDelayClose;

	private const float flyTime = 0.35f;

	protected abstract int EventId { get; }

	protected override void OnUIInit()
	{
	}

	public virtual bool IsManualPref()
	{
		return false;
	}

	public virtual void SetManualPrefKey(string key)
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	public void StartAnimation()
	{
	}

	public void ExecuteFlyEffect()
	{
	}

	protected virtual void PlayFlySound()
	{
	}

	protected float GetAnimationTime(Animation animation)
	{
		return 0f;
	}

	private void _003CStartAnimation_003Eb__13_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}
}
