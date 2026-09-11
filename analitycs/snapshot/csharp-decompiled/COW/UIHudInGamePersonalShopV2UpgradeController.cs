using GCommon;

namespace COW;

public class UIHudInGamePersonalShopV2UpgradeController : UIHudInGamePersonalShopV2Controller
{
	private const string NEED_SHOW_UPGRADE_VFX_ON_SHOW_KEY = "NeedShowUpgradeVFXOnShow";

	private bool m_NeedShowUpgradeVFXOnShow;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override void OnUIReInit()
	{
	}

	protected override bool CheckCanShow()
	{
		return false;
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void UpdateShopBackground()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_CheckCanShow()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_UpdateShopBackground()
	{
	}
}
