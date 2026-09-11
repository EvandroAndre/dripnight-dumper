using System;
using GCommon;

namespace COW;

public class UIHudUGCTutorialDialogueController : UIBaseController
{
	private UIHudUGCTutorialDialogueView m_View;

	private TypewriterEffect m_TypewriterEffect;

	private Action m_OnLineComplete;

	private bool m_IsTyping;

	private bool m_TypewriterRegistered;

	private bool m_MaskClickRegistered;

	private bool m_IsInDelay;

	private string m_PendingContent;

	private uint m_DelayCallId;

	private const float CHARS_PER_SECOND = 30f;

	public const int DIALOGUE_PANEL_DEPTH = 985;

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

	public void ShowDialogue(string speaker, string content, Action onLineComplete)
	{
	}

	private int TryConsumeDelayDialogue()
	{
		return 0;
	}

	private void StartContentDelay(string content, int delaySeconds)
	{
	}

	private void OnDialogueDelayFinished()
	{
	}

	private void CancelDelayCall()
	{
	}

	private void EnsureContentVisible()
	{
	}

	private void StartTypewriter(string content)
	{
	}

	public void HideDialogue()
	{
	}

	private void OnClickMaskBG()
	{
	}

	private void OnTypewriterFinished()
	{
	}

	private void SetVisible(bool visible)
	{
	}

	private void InitComponents()
	{
	}

	private void ApplyPanelDepth(int depth)
	{
	}

	private void UnregisterTypewriter()
	{
	}

	private void UnregisterMaskClick()
	{
	}

	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}
}
