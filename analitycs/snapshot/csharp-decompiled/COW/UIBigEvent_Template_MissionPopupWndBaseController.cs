using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_Template_MissionPopupWndBaseController : UIPopupWindowController, IEasyList, IUIModelDataChangeObserver, IBigEventTemplateIdentifier
{
	protected UIModelBigEventTemplate m_UIModelBigEventTemplate;

	protected UIButton BtnClose;

	protected UIEasyList MissionList;

	protected UINetworkTexture TextureBg;

	protected UISprite SpriteBtnClose;

	protected UILabel LabelTitle;

	protected UILabel LabelRefreshTime;

	protected UIButton AllClaimedBtn;

	protected UINetworkTexture TextureBtnClose;

	protected UILabel LabelTokenLimit;

	protected UILabel LabelTokenBR;

	protected UILabel LabelTokenCS;

	protected UILabel LabelTokenLW;

	protected UINetworkTexture DialogTextureRole;

	protected UINetworkTexture DialogTextureBg;

	protected UINetworkTexture ObtainTextureTokenIcon;

	protected GameObject DialogTips;

	public UITable Obtain;

	private const int UGCEasyListHeight = 104;

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

	protected override void OnUIDestroy()
	{
	}

	protected virtual UIBigEvent_Template_MissionItemBaseController GenerateMissionItemController(Transform parent)
	{
		return null;
	}

	private void RefreshView()
	{
	}

	protected void OnClickBtnClose()
	{
	}

	protected virtual void OnClickAllClaimedBtn()
	{
	}

	protected virtual void ReloadMissionList()
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

	public virtual EBigEventTemplateType GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	public void OnTemplateUIInit()
	{
	}

	private void FreshTokenInGame()
	{
	}

	private void _003COnTemplateUIInit_003Eb__38_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSetNavigationController()
	{
	}
}
