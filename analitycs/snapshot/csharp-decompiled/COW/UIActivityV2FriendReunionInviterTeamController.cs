using GCommon;
using UnityEngine;

namespace COW;

internal class UIActivityV2FriendReunionInviterTeamController : UIBaseController, IEasyList, IUIModelDataChangeObserver
{
	private UIActivityV2FriendReunionInviterTeamView m_View;

	private UIModelFriendReunion m_ModelFriendReunion;

	private UIModelFriends m_ModelFriends;

	private bool m_UseBigType;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void RefreshView()
	{
	}

	public void ChangeWidthForOnlyOne(bool flag)
	{
	}

	public void SetBigType(bool flag)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public virtual UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
