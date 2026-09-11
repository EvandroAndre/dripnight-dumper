using GCommon;
using UnityEngine;

namespace COW;

public class UIHudAutoQuickChatV2Controller : UIBaseController
{
	private UIHudAutoQuickChatV2View m_View;

	private IngameQuickChatV2Manager m_Manager;

	private InGameQuickChatV2 m_LastTriggeredConfig;

	private uint m_AutoHideCallId;

	private float m_TriggerStartTime;

	private float m_TriggerDuration;

	private Vector3 m_TargetPosition;

	private bool m_HasTargetPosition;

	private UIHudQuickChatV2ComboController m_ComboCtrl => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void Update()
	{
	}

	private void UpdateContent()
	{
	}

	private string GetSmartBubbleText()
	{
		return null;
	}

	private bool CheckCanTrigger(InGameQuickChatV2Message msgData)
	{
		return false;
	}

	private void SetTriggerData(InGameQuickChatV2Message msgData)
	{
	}

	private void UpdateCountdown()
	{
	}

	private void OnSendChatBtnClick()
	{
	}

	public void TryShowByTriggerData(object[] data)
	{
	}

	private void NotifyComboBeforeHide()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	private void ScheduleAutoHide()
	{
	}

	private void CancelAutoHide()
	{
	}

	private void OnDismissBubble(uint configId)
	{
	}

	protected override void OnUIClose()
	{
	}

	private void _003CScheduleAutoHide_003Eb__24_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
