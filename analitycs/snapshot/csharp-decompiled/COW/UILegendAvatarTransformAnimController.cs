using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UILegendAvatarTransformAnimController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public int index;

		public UILegendAvatarTransformAnimController _003C_003E4__this;

		internal void _003CInitBtnList_003Eb__0()
		{
		}
	}

	private UILegendAvatarTransformAnimView m_View;

	private List<UIToggleButton> m_AvatarAnimBtn;

	private List<Action> m_BtnActionList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected virtual void InitBtnList()
	{
	}

	public void RefreshHighLightByIndex(int index)
	{
	}

	public void SetDefaultView()
	{
	}

	public void UpdateLabelKey(string key1, string key2)
	{
	}

	public void SetBtnAction(int index, Action action)
	{
	}

	private void RefreshCollectionItemByLv(int index)
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData()
	{
	}

	public void SetCDNBg(uint chestID)
	{
	}

	public void SetTitleText(uint chestID)
	{
	}

	private void _003CSetCDNBg_003Eb__15_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
