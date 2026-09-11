using GCommon;
using proto;

namespace COW;

internal class UIRelationshipController : UIBaseController, IUIModelDataChangeObserver
{
	public enum CtrlType
	{
		NONE,
		CloseFriend
	}

	private UIRelationShipView m_View;

	private UICloseFriendController m_CloseFriendController;

	private EFriend.RelationType m_CurrentType;

	private CtrlType m_CtrlType;

	private UIModelRelationShip m_Model;

	public CtrlType CurCtrlType
	{
		get
		{
			return CtrlType.NONE;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void OnUIInit()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public void ShowContentByCurrentRelationship(EFriend.RelationType currentType)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void InitControllers()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnCompatibleLogin(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
