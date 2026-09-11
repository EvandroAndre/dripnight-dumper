using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIActivityADMiniContentController : UIActivityContentController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public uint activityId;

		internal bool _003COnDataChanged_003Eb__0(ClientActivityDesc temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public int tempIndex;

		public UIActivityADMiniContentController _003C_003E4__this;

		internal void _003CCreateThirdTabs_003Eb__0()
		{
		}
	}

	private UIActivityADMiniContentView m_View;

	private UIModelActivity m_ModelActivity;

	private ActivityGroupDesc m_Descs;

	private UIActivityContentController m_Content;

	private UIActivityExchangeContentController m_ExchangeContentController;

	private Dictionary<uint, GameObject> m_ThirdTabTipsDict;

	private List<UIToggleButton> m_ThirdToggles;

	private UIGrid m_ThirdTabsGrid;

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

	protected override void OnUIOpen()
	{
	}

	public override void SetData(object data)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void SetAD(string url)
	{
	}

	private void UpdateIntroData()
	{
	}

	private void UpdateActivityInfo()
	{
	}

	private bool CreateThirdTabs()
	{
		return false;
	}

	public override void Reload()
	{
	}

	private void UpdateThirdTabsTips()
	{
	}

	private void OnThirdTabSelected(int index)
	{
	}

	private void CloseOldContent()
	{
	}

	private UIActivityContentController OpenThirdTabContent(int index, out object data)
	{
		data = null;
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_SetData(object P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Reload()
	{
	}
}
