using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIBM26_SYSWarmUpController : UIBigEventWarmUpBaseController
{
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public UIStandardItemMiniController controller;

		public UIBM26_SYSWarmUpController _003C_003E4__this;

		internal void _003COnBigEventWarmupSettingCallback_003Eb__0()
		{
		}
	}

	private UIBM26SysWarmUpView m_View;

	private List<UIStandardItemMiniController> m_ListItems;

	private BaseItemInfo m_BigPrizeItem;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override ELimitedEvent.EventID GetBigEventId()
	{
		return ELimitedEvent.EventID.EventID_NONE;
	}

	protected override string GetTitleCDNUrl()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void LogClick(string posfix)
	{
	}

	private void OnClickBtnBigReward()
	{
	}

	private void CloseChildControlloer(List<UIStandardItemMiniController> itemControllers)
	{
	}

	protected override void OnBigEventWarmupSettingCallback(List<BigEventShowAwardDesc> list)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
