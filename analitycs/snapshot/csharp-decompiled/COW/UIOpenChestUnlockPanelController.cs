using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UIOpenChestUnlockPanelController : UIPopupWindowController
{
	private UIOpenChestUnlockPanelView m_View;

	private Action<bool> m_UnlockAction;

	private GameObject m_AnimationRoot;

	private uint m_GachaID;

	private UIGachaTreatureBoxV2AnimationAssist m_AnimatorAssist;

	private bool m_Unlocked;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	private void PlayDropBoxAnim(bool isRepurchase)
	{
	}

	private void ProcessAnimEvt(object[] data)
	{
	}

	public void SetUnlockCallback(Action<bool> action)
	{
	}

	private void EndPlayDrawAnim(bool showAnime)
	{
	}

	private void OnRewardPopWndClose(object[] data)
	{
	}

	public void ClearCache()
	{
	}

	public void SetViewData(uint gachaID, bool isRepurchase)
	{
	}

	private void OnUnlockClick(GameObject go, bool press)
	{
	}

	private void PlayUnlockAnimation(bool isQuick)
	{
	}

	private void OnSkipClick()
	{
	}

	public override bool ClosedByEsc()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return false;
	}
}
