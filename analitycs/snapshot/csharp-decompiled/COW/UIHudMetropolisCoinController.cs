using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMetropolisCoinController : UIBaseController
{
	private UIHudMetropolisCoinView m_View;

	private int m_CoinNum;

	private int m_CashNum;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public Vector3 GetTokenFlyEndPos()
	{
		return default(Vector3);
	}

	private void OnClickDetailBtn()
	{
	}

	private void OnClickLevelupBtn()
	{
	}

	private void OnClickConfirmBtn()
	{
	}

	private void OnCurCoinChanged(int data)
	{
	}

	private void OnLocalPlayerFactionChange(object[] data)
	{
	}

	private void OnPackageLevelChanged()
	{
	}

	private void OnItemCountChanged(uint itemID)
	{
	}

	private void RefreshPackageInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
