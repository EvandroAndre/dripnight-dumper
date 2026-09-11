using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public abstract class UITakePhotoGroupTemplateItemBaseController : UIEasyListItemController, IUIModelDataChangeObserver
{
	protected UIButton SelectBtn;

	protected GameObject Selected;

	protected GameObject SelectedTri;

	protected GameObject NotOwnedContainer;

	protected GameObject LeftTimeContainer;

	protected UILabel LeftTimeLabel;

	protected UIButton GotoBtn;

	protected GameObject NameContainer;

	protected UILabel MemberCount;

	protected UILabel Name;

	protected UILabel NotOwnedName;

	protected UINewDownloadInfoController m_DownLoadCtrl;

	protected GameObject DownLoadPos;

	protected UINetworkTexture TextureCDN;

	protected UISprite EditBackGroundPreviewCDN;

	protected Transform NewTipsContainer;

	public UIModelOptionalDownload m_ModelDownload;

	public UIModelInventory m_ModelInventory;

	protected UITipsNormalController m_NewTipsCtrl;

	private GroupPhotoTemplateData m_Data;

	private PhotoEditBackgroundData m_EditBackGroundData;

	private bool m_EditBackGroundSelected;

	private bool m_IsPhotoGroupSelected;

	private UITakePhotoGroupBaseController m_Parent;

	private List<ResourceID> m_NeedDownloadResIdsCache;

	public bool EditBackGroundSelected => false;

	private UITakePhotoGroupBaseController Parent => null;

	protected override void OnUIInit()
	{
	}

	private void OnGotoBtnClick()
	{
	}

	protected abstract void InitView();

	public override void SetViewData(object data, int data_index)
	{
	}

	public override void OnItemBtnClick()
	{
	}

	public void RefreshSelected(uint templateId)
	{
	}

	private void RefreshOwnedStatus(bool isOwned)
	{
	}

	public void RefreshSelectedEditBackGround(uint backGroundId)
	{
	}

	public void RefreshDeleteEditBackGround(uint backGroundId)
	{
	}

	public void DeleteEditBackGround()
	{
	}

	public void RefreshDownload()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	protected virtual void RefreshNewStatus()
	{
	}

	protected virtual void RefreshGoposButtonVisibility()
	{
	}

	private void _003COnUIInit_003Eb__28_0()
	{
	}

	private void _003CRefreshDownload_003Eb__39_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnClick()
	{
	}
}
