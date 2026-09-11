using GCommon;

namespace COW;

internal class UIHudSightController : UIHudButtonBaseController
{
	private UIHudSightView m_View;

	private bool m_bSighting;

	private const string AimShoot = "UI_icon_aim";

	private const string AimShootClose = "UI_icon_aim_close";

	private const string AimShoot_Shield = "UI_icon_Shield";

	private const string AimShootClose_Shield = "UI_icon_Shield_close";

	private uint m_SightDataID;

	private uint weaponID;

	private bool m_PendingHideAfterSightClose;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void InitIsNewUI()
	{
	}

	protected override string GetMappingName()
	{
		return null;
	}

	public override void Show()
	{
	}

	public void HideWhenSightClosed()
	{
	}

	private void Update()
	{
	}

	private void SetBtnSpriteView(string spriteName, bool useHighlightColor = false)
	{
	}

	private void RefreshMountGrenadeIcon(bool sighting)
	{
	}

	private void CloseClickEffect(bool bBtnSightVisible)
	{
	}

	private void ShowTutorialOpenGunSight(object[] data)
	{
	}

	private void ShowTutorialSightOpeningInForceTutorial(object[] param)
	{
	}

	private void ShowTutorialSightClosingInForceTutorial(object[] param)
	{
	}

	protected override void OnBtnDown()
	{
	}

	protected override void OnBtnUp()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnEquipAttachment(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnDown()
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnUp()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
