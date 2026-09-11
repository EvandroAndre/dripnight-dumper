using GCommon;
using UnityEngine;

namespace COW;

internal class UIHGSnowTalentDetailController : UIBaseController, IEasyList, IUIModelDataChangeObserver
{
	private UIHGSnowTalentDetailView m_View;

	private UIModelHuntingGround m_Model;

	private bool m_IsTalentUpdate;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void Show()
	{
	}

	private void OnBtnCloseClick()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}
}
