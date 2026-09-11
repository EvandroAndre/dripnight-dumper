using GCommon;

namespace COW;

internal class UIHudTreasuryUpgradeBtnController : UIBaseController
{
	private UIHudTreasuryUpgradeBtnView m_View;

	private uint m_CurTreasuryID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	public void SetViewData(uint treasuryID)
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnUpgradeButtonClick()
	{
	}

	private void RefreshBountyPostPrice(int playerToken)
	{
	}

	private void RefreshView()
	{
	}

	private void RefreshVaultKeyIcon(bool hasVaultKey)
	{
	}

	private void RefreshMask()
	{
	}

	private void OnTreasuryUpgraded(uint treasuryID)
	{
	}

	private void OnTreasuryRobbedStateChanged(object[] data)
	{
	}

	private void OnVaultKeyStateChanged(object[] data)
	{
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
