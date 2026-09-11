using GCommon;
using UnityEngine;

namespace COW;

internal abstract class UIHUDFeedbackItemBaseController : UIBaseController
{
	private TweenAlpha m_TweenAlpha;

	private TweenScale m_TweenScale;

	public abstract void ShowIcon(NotificationData data);

	public virtual void HideIcon()
	{
	}

	public virtual float PlayKillNotifyInLobby(uint weaponSkinId, bool loop = true, bool playSound = true, int maxDepth = 30)
	{
		return 0f;
	}

	protected virtual GameObject GetLabelRoot()
	{
		return null;
	}

	public void Sample(float time)
	{
	}

	public void PlayTween()
	{
	}

	public void ResetLanelAnimation()
	{
	}

	public void AddLabelAnimation(TweenAlpha srcAlpha, TweenScale srcScale)
	{
	}

	private void CopyTween(UITweener src, UITweener dest)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
