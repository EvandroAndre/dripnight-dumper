using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudPartyNPCInteractDialogController : UIBaseController
{
	private UIHudPartyNPCInteractDialogView m_View;

	private FBIFJLLHEDA m_CurNode;

	private uint m_CurChatNPCID;

	private List<UIHudPartyNPCInteractReactItemController> m_ResponseCtrlList;

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

	public void HideSelf()
	{
	}

	public void StartInteractWithNPC(uint NPCID)
	{
	}

	public void OnPlayerReact(object[] data)
	{
	}

	private void SetUIForNode(FBIFJLLHEDA node)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
