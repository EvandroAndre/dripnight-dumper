using GCommon;
using UnityEngine;

namespace COW;

internal class UIHGSnowTalentController : UINavigationController, IEasyList, IUIModelDataChangeObserver
{
	private UIModelHuntingGround m_Model;

	private UIHGSnowTalentView m_View;

	private UIHGSnowTalentNodeDetailController m_DetailNodeCtrl;

	private UIHGSnowTalentDetailController m_TalentDetailCtrl;

	private const string GUIDE_STEP4_KEY = "HgSnow_GuideStep4";

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	private void RefreshTalentCount()
	{
	}

	private void InitTalentTree()
	{
	}

	private void RefreshTalentToken()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void OnShowTalentNodeDetail(object[] data)
	{
	}

	public void SetDetailButtonActive(bool isActive)
	{
	}

	private void OnBtnDetailClick()
	{
	}

	private void OnBtnTalentTokenClick()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}
}
