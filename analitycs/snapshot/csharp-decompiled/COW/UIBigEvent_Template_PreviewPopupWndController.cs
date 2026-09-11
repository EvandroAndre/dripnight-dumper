using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public abstract class UIBigEvent_Template_PreviewPopupWndController : UIPopupWindowController, IBigEventTemplateIdentifier
{
	protected List<UIStandardItemMiniController> m_rewardCtrlList;

	protected UIModelBigEventTemplate m_ModelBigEventTemplate;

	protected UILabel RewardGetRequestLabel;

	protected UIGrid RewardGridContainer;

	protected UINetworkTexture CdnBg;

	protected UIButton CloseBtn;

	protected UISprite CloseBtnSpriteIcon;

	protected UILabel TitleLabel;

	protected UINetworkTexture CloseBtnTextureIcon;

	private EBigEventTemplateUseType _003CTemplateUseType_003Ek__BackingField;

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

	private void OnCloseBtnClick()
	{
	}

	private void InitCDN()
	{
	}

	public void SetData(List<BaseItemInfo> show_rewardList, string strTitle, Color titleColor, string strContent, Color contentColor, bool isReceived)
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
}
