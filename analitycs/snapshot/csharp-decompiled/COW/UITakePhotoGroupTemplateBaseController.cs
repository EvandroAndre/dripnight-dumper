using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public abstract class UITakePhotoGroupTemplateBaseController : UIBaseController, IEasyList
{
	protected UIEasyList EasyList;

	protected UILabel Desc;

	protected UIButton ExpandBtn;

	protected UISprite IsExpandIcon;

	protected UISprite UnExpandIcon;

	protected List<UITakePhotoGroupTemplateItemBaseController> m_ItemListController;

	protected List<UITakePhotoGroupTemplateItemController> m_ItemListGroundEditController;

	protected List<UITakePhotoGroupBigEventBgItemBaseController> m_ItemListBigEventGroundController;

	private bool IsExpand;

	protected bool IsShowNameCtrl;

	protected UIButton HideNameCtrlsBtn;

	protected UISprite HideNameCtrlCheckIcon;

	protected Animation ExpandAnim;

	protected UITakePhotoGroupBaseController ParentCtrl;

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	protected abstract UIEasyListItemController OpenItemControllerInteral(Transform parent);

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	protected abstract void InitView();

	public virtual void SetData(List<GroupPhotoTemplateData> list, uint templateId = 0u, uint templateType = 0u)
	{
	}

	private void CheckAndGetNoGoposItem(List<GroupPhotoTemplateData> list)
	{
	}

	public void RefreshAllSelected(uint templateId)
	{
	}

	public void RefreshAllSelectedEditBackGround(uint backGroundId)
	{
	}

	public void RefreshAllSelectedBigEventBackGround(uint backGroundId)
	{
	}

	public void RefreshAllDeleteEditBackGround(uint backGroundId)
	{
	}

	public void DeleteAllEditBackGround()
	{
	}

	public virtual void OnSelectTemplate(GroupPhotoTemplateData templateData)
	{
	}

	public void OnExpandBtn()
	{
	}

	public void ExpandTemplate(bool isIn, bool isSkip = false)
	{
	}

	protected abstract string GetExpandAnimStr(bool isExpand);

	protected void OnHideNameCtrlsBtn()
	{
	}

	public void RefreshExpandIcon()
	{
	}

	protected Type GetBigEventBgItemControllerType()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}
}
