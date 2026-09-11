using GCommon;
using proto;

namespace COW;

public abstract class UIFrontEndPreviewWeaponProgressBarBaseController : UIFrontEndPreviewUIComponentTemplateBaseController<UIFrontEndPreviewWeaponProgressBarBaseView>, IUIModelDataChangeObserver
{
	protected UIModelMall m_ModelMall;

	protected UIModelWeaponSkinPokedex m_ModelWeaponSkinPokedex;

	protected WeaponSkinPermanentDesc m_PermanentDesc;

	protected WeaponSkinPermanentGoPosDesc m_PermanentGoPosDesc;

	protected const string COLOR_YELLOW = "ffba00";

	protected uint m_BeforePermanent;

	protected BaseItemInfo m_SkinItemInfo;

	protected override void OnUIInit()
	{
	}

	public void RefreshAllByItemInfo(BaseItemInfo skinItemInfo)
	{
	}

	public bool RefreshBeforeByItemID(uint itemID, bool needGoto = false, bool showOldPermanent = false)
	{
		return false;
	}

	private void OnClickTipsBtn()
	{
	}

	private void OnClickGotoBtn()
	{
	}

	public void CustomizeInWeaponSkinLobbyMain()
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
}
