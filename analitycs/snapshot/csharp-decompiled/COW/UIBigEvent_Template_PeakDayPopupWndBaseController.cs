using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_Template_PeakDayPopupWndBaseController : UIPopupWindowController, IUIModelDataChangeObserver, IBigEventTemplateIdentifier
{
	protected UIModelBigEventTemplate m_UIModelBigEventTemplate;

	protected UIModelActivity m_UIModelActivity;

	protected UIButton BtnClaim;

	protected UIButton BtnClose;

	protected UINetworkTexture TextureBg;

	protected UINetworkTexture TextureTitle;

	protected UILabel LabelTitle;

	protected UILabel LabelDesc;

	protected UIGrid GridAwardContainer;

	protected UISprite SpriteBtnClose;

	protected GameObject LabelCantClaim;

	protected GameObject GoClaimed;

	protected GameObject GoExpired;

	protected GameObject GoClaim;

	private uint m_ActivityId;

	private bool m_IsAutoOpen;

	private EBigEventTemplateUseType _003CTemplateUseType_003Ek__BackingField;

	protected virtual UICommonRewardWndController.WndStyleEnum WndStyle => UICommonRewardWndController.WndStyleEnum.COMMON;

	public EBigEventTemplateUseType TemplateUseType
	{
		get
		{
			return _003CTemplateUseType_003Ek__BackingField;
		}
		private set
		{
			_003CTemplateUseType_003Ek__BackingField = value;
		}
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnSetNavigationController()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected virtual void RefreshView()
	{
	}

	private void SetErrorView()
	{
	}

	private void OnBtnClaimClick()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public virtual EBigEventTemplateType GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	public void OnTemplateUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSetNavigationController()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
