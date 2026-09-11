using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using message;

namespace COW;

public class UIHudSceneEditInspectorCompController : UIBaseController
{
	protected UIHudSceneEditInspectorCompView m_View;

	protected bool m_IsCollapse;

	protected Dictionary<string, UIBaseController> m_AttributeItemUI;

	protected List<UIBaseController> m_AttributeItemUIList;

	protected List<UIBaseController> m_AttributeFuncItemUI;

	protected List<EJAOBJCGLKD.JNHDMBBECJP> m_SecondLevelAttrList;

	private UISceneEditItemFuncAttributeController m_SecondLevelAttributeUI;

	private List<UIHudSceneEditCustomAttributeEditItemController> m_AttributeCustomItemUIList;

	protected string m_EntityType;

	private bool m_HasConflict;

	private string m_Tips;

	protected SceneEditObjectBase m_ModifyObject;

	private SceneEditAgent m_Agent;

	private bool m_AttrBtnActive;

	private bool m_RemoveBtnActive;

	private string m_ConflictInfo;

	protected SceneEditAgent Agent => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public virtual void SetViewData(string title, string entityType, SceneEditObjectBase objectBase, string tips)
	{
	}

	public virtual bool IsEmptyInspectorComp()
	{
		return false;
	}

	private void OnCollapseBtnClick()
	{
	}

	private void OnMoreBtnClick()
	{
	}

	private void OnCloseMoreBtnClick()
	{
	}

	private void OnAttributeBtnClick()
	{
	}

	private void OnRemoveBtnClick()
	{
	}

	protected virtual void TriggerRefreshAllAttributes()
	{
	}

	protected virtual bool EnableExpand()
	{
		return false;
	}

	public void CreateAttributeItemUI(ItemEditAttributeUIData_V2 uiData, int siblingIndex = -1)
	{
	}

	private UISceneEditItemFuncAttributeController CreateFuncAttributeUI(ItemFunctionUIData uidata)
	{
		return null;
	}

	private void CreateAttributeCustomItemUI(IPIFNFDIIKK data, string entityID)
	{
	}

	private void CreateSecondLevelFuncUI()
	{
	}

	private void RefreshFunAttriUI(object[] data)
	{
	}

	private void OnShowSecondLevelAttributes()
	{
	}

	public virtual void ReplaceUIByConfig(int startIndex, List<ItemEditAttributeUIData_V2> uidataList, List<EJAOBJCGLKD.JNHDMBBECJP> secondLevelUIDataList)
	{
	}

	public virtual void RefreshSingleUIByConfig(ItemEditAttributeUIData_V2 uiData)
	{
	}

	private void OnRefreshAttributeUI(object[] data)
	{
	}

	private void RefreshAttributeUI(bool immediate = false)
	{
	}

	private void AdjustMoreBtnsPosition()
	{
	}

	public void SetBtnAttributeActive(bool active)
	{
	}

	public void SetBtnRemoveActive(bool active)
	{
	}

	private void RefreshBtnState()
	{
	}

	public void SetExpandState(bool expand)
	{
	}

	public void SetConflictTip(bool hasConflict, string conflictInfo)
	{
	}

	private void OnConflictTipClick()
	{
	}

	private void OnTipsQuestionMarkClick()
	{
	}

	private void RefreshTips()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
