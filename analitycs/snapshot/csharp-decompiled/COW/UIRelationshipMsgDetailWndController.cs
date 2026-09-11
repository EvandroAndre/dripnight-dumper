using GCommon;

namespace COW;

internal class UIRelationshipMsgDetailWndController : UIPopupWindowController
{
	private UIRelationshipMsgDetailWndView m_View;

	private UIModelRelationShip modelRelationShip;

	private RelationshipMessageInfo m_RelationMsgInfo;

	private uint m_delayCall;

	private ulong m_SendMsgAccountId;

	protected override void OnUIInit()
	{
	}

	private void CloseMsgDetailWnd(object[] param)
	{
	}

	protected override void OnDestroy()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetUIData(RelationshipMessageInfo reInfo, string CDNUrl)
	{
	}

	public void SetUIData(RelationshipInfo reInfo, string CDNUrl)
	{
	}

	private void OnClickClose()
	{
	}

	protected override void OnUIClose()
	{
	}

	private void OnClickConfirm()
	{
	}

	private void OnClickRefuce()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
