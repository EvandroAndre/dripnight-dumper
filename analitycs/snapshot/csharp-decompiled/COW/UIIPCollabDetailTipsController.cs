using GCommon;
using proto;

namespace COW;

public class UIIPCollabDetailTipsController : UIBaseController
{
	private UIIPCollabDetailTipsView m_View;

	private UIModelInventory m_ModelInventory;

	private UIModelWishList m_ModelWishList;

	private CollabItemDesc m_AvatarDesc;

	private ItemChannelInfo m_TargetItemChannelInfo;

	private int m_Index;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void ShowDetailTips(CollabItemDesc avatarDesc, int index, bool hasExtraBundle = false, bool showChangeSetTips = false)
	{
	}

	private void OnEquipBtnClick()
	{
	}

	private void OnGotoPosClick()
	{
	}

	private void OnTopBtnClick()
	{
	}

	private void OnChangeSetBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
