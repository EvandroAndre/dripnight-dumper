using GCommon;

namespace COW;

public class UIEVOGunPrivilegeTitleController : UIBaseController
{
	private UIEVOGunPrivilegeTitleView m_View;

	private WeaponSkinUpgradeInfoData m_FeatureInfo;

	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	private SkinOwnAndOpenInfo m_SkinOwnAndOpenInfo;

	private int m_Index;

	private WeaponSkinFeature m_Feature;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitState()
	{
	}

	public void SetData(WeaponSkinFeature feature, SkinOwnAndOpenInfo skinOwnAndOpenInfo, int index)
	{
	}

	private void OnTitleBtnClick()
	{
	}

	private void OnTipsBtnClick()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void OnSelectNotify()
	{
	}

	public void OnSelect()
	{
	}

	public void OnCancelSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
