using GCommon;

namespace COW;

public class UIHudAffixPopupController : UIBaseController
{
	private UIHudAffixPopupView m_View;

	private uint m_DelayCall;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetData(float time, string titleKey)
	{
	}

	private void LoadAllGameplayAffixItems(uint[] pickedAffixes)
	{
	}

	private void SetData(GameplayAffixConfigData configData)
	{
	}

	public void SetData()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
