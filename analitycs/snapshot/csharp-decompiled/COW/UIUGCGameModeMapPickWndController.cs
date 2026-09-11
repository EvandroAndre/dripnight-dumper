using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIUGCGameModeMapPickWndController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private UIUGCGameModeMapPickWndView m_View;

	private List<uint> m_Selected;

	private List<uint> m_InitialSelected;

	private UIModelSceneEdit m_Model;

	private List<UIUGCGameModeMapPickItemController> m_PickItemCtrls;

	public List<int> Tags;

	private bool m_IsNew;

	private bool m_HasInit;

	private EUGCScene m_src;

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

	public void InitCloseUI()
	{
	}

	private void OnMyClose()
	{
	}

	private void InitView()
	{
	}

	private void OnTipBtnClick()
	{
	}

	public override string Rule()
	{
		return null;
	}

	public override bool OverrideRuleBtnClick()
	{
		return false;
	}

	private void OnPreferClick()
	{
	}

	public void SetData(bool isNew, EUGCScene src = EUGCScene.EUGCScene_None)
	{
	}

	private void OnClickConfirm()
	{
	}

	private void OnClickSelectAll()
	{
	}

	public void OnItemSelect(bool select, uint tagId)
	{
	}

	public void SaveAll()
	{
	}

	private void RefreshAllPickTick()
	{
	}

	private bool IsPickAll()
	{
		return false;
	}

	public void OnBtnGoToClick()
	{
	}

	private void RefreshUI()
	{
	}

	private void RefreshOptionalMapRes()
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
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

	public string _003C_003EiFixBaseProxy_Rule()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_OverrideRuleBtnClick()
	{
		return false;
	}
}
