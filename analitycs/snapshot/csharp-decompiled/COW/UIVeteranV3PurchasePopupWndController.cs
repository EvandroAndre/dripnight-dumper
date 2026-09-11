using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIVeteranV3PurchasePopupWndController : UIPopupWindowController
{
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public Dictionary<uint, byte> dic;

		internal int _003CShowUnlockReward_003Eb__0(AwardDesc a, AwardDesc b)
		{
			return 0;
		}
	}

	private UIVeteranV3PurchasePopupWndView m_View;

	private UIModelVeteran m_ModelVeteran;

	private int m_AwardNum;

	private float m_HalfRewardWidth;

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

	public void ShowUnlockReward()
	{
	}

	private void OnPurchaseBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
