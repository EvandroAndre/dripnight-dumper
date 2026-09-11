using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIBigEvent_Template_LobbyIconWndController : UIPopupWindowController
{
	private UIBigEvent_Template_LobbyIconWndView m_View;

	private UIModelBigEventTemplate m_ModelBigEventTemplate;

	private uint m_AnimKey;

	private CustomEventLobbyIconDesc m_Desc;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	public void SetLobbyIconDesc(CustomEventLobbyIconDesc desc)
	{
	}

	private float GetAnimationTime(Animation animation)
	{
		return 0f;
	}

	private void ExecuteFlyEffect()
	{
	}

	private void _003CSetLobbyIconDesc_003Eb__8_0()
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
