using GCommon;

namespace COW;

public class UIClanRecruitItemController : UIEasyListItemController
{
	private FriendAccountInfo m_info;

	private UIClanRecruitItemView m_View;

	private UIBaseProfileInfoController m_ProfileCtrl;

	private UIModelClan m_ModelClan;

	private bool HasRecruited => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnRecruitClick()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
