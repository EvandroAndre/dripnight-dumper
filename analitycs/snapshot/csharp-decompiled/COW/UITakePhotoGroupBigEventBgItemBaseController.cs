using GCommon;
using UnityEngine;

namespace COW;

public abstract class UITakePhotoGroupBigEventBgItemBaseController : UIEasyListItemController
{
	protected UIButton SelectBtn;

	protected GameObject Selected;

	protected GameObject SelectedTri;

	protected GameObject NotOwnedContainer;

	protected GameObject LeftTimeContainer;

	protected UILabel LeftTimeLabel;

	protected UIButton GotoBtn;

	protected GameObject NameContainer;

	protected UILabel Name;

	protected UILabel NotOwnedName;

	protected UINetworkTexture TextureCDN;

	protected UISprite BackGroundPreviewCDN;

	protected UILabel GoPosLabel;

	protected PhotoBackGroundData m_PhotoBackGroundData;

	private UITakePhotoGroupBaseController m_Parent;

	protected UITakePhotoGroupBaseController Parent => null;

	protected override void OnUIInit()
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

	protected virtual string GetGoPosLabelText()
	{
		return null;
	}

	private void _003COnUIInit_003Eb__17_0()
	{
	}

	private void _003COnUIInit_003Eb__17_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnClick()
	{
	}
}
