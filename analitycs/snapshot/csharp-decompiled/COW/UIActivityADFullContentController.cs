using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIActivityADFullContentController : UIPreviewBaseController, IUIActivityContent, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public uint activityId;

		internal bool _003COnDataChanged_003Eb__0(ClientActivityDesc temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass33_0
	{
		public int tempIndex;

		public UIActivityADFullContentController _003C_003E4__this;

		internal void _003CCreateThirdTabs_003Eb__0()
		{
		}
	}

	private UIActivityADFullContentView m_View;

	private UIModelActivity m_ModelActivity;

	private ActivityGroupDesc m_Descs;

	private UIActivityContentController m_Content;

	private UIActivityTokenExchangeContentController m_ExchangeContentController;

	private UIActivityListContentController m_ListContentController;

	private Dictionary<uint, GameObject> m_ThirdTabTipsDict;

	private List<UIToggleButton> m_ThirdToggles;

	private UIGrid m_ThirdTabsGrid;

	private int m_LeftOffset;

	private int m_RightOffset;

	private bool m_ShowModel;

	private uint m_AffiliateTab;

	private const int ADSafeWidth = 1608;

	private AwardDesc m_CurrentPreviewItem;

	protected bool m_IsHideByPreviewPop;

	public bool ShowModel => false;

	public GameObject Root => null;

	public UIActivityContentController CurrentContent => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void Reload()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public void SetViwAdjust(int leftOffset = 0)
	{
	}

	private void SetPreviewAdjust(int rightOffset = 0)
	{
	}

	public void SetData(object data)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void UpdateIntroData()
	{
	}

	private void RefreshCountDownState()
	{
	}

	private void UpdateActivityInfo()
	{
	}

	private bool CreateThirdTabs()
	{
		return false;
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

	private UIActivityContentController OpenThirdTabContent(uint affiliateTab, out object data)
	{
		data = null;
		return null;
	}

	private void ShowPreview(object[] parameters)
	{
	}

	private void ShowPriveiwItem(AwardDesc awardDesc)
	{
	}

	private void RefreshPreviewItem()
	{
	}

	public override bool IsAutoCalculatePreviewPanelSize()
	{
		return false;
	}

	private void OpenPreviewInternal()
	{
	}

	public void OnPopUpWindowListChange(bool isCovered)
	{
	}

	public void OnVisibilityChange(bool isVisible, bool needRefresh)
	{
	}

	public void HideContent()
	{
	}

	public void CloseContent()
	{
	}

	public void ShowContent()
	{
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsAutoCalculatePreviewPanelSize()
	{
		return false;
	}
}
