using GCommon;

namespace COW;

internal class UIHudEvoGunKillCountController : UIBaseController
{
	private UIHudEvoGunKillCountView m_View;

	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	private ResourceID m_VFXResId;

	private VisualInstanceHolder m_VFXHolder;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	public static bool DontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetKillCountView(uint weaponSkinID, uint killCount)
	{
	}

	private VisualInstanceHolder EnsureVisualInstanceHolder()
	{
		return null;
	}

	private void TryReleasePreviousHolder()
	{
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
