using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIActivityADFullContentTemplateController : UIPreviewBaseController, IUIActivityContent, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<UIActivityADFullContentTemplateController, IUIActivityContent> _003C_003E9__21_0;

		public static Func<UIActivityADFullContentTemplateController, IUIActivityContent> _003C_003E9__21_1;

		public static Func<UIActivityADFullContentTemplateController, IUIActivityContent> _003C_003E9__21_2;

		internal IUIActivityContent _003Cget_TemplateRegistry_003Eb__21_0(UIActivityADFullContentTemplateController host)
		{
			return null;
		}

		internal IUIActivityContent _003Cget_TemplateRegistry_003Eb__21_1(UIActivityADFullContentTemplateController host)
		{
			return null;
		}

		internal IUIActivityContent _003Cget_TemplateRegistry_003Eb__21_2(UIActivityADFullContentTemplateController host)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public uint activityId;

		internal bool _003COnDataChanged_003Eb__0(ClientActivityDesc d)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass60_0
	{
		public int tempIndex;

		public UIActivityADFullContentTemplateController _003C_003E4__this;

		internal void _003CCreateThirdTabs_003Eb__0()
		{
		}
	}

	private UIActivityADFullContentTemplateView m_View;

	private UIModelActivity m_ModelActivity;

	private ActivityGroupDesc m_Descs;

	private IUIActivityContent m_BodyController;

	private Dictionary<uint, GameObject> m_ThirdTabTipsDict;

	private List<UIToggleButton> m_ThirdToggles;

	private List<uint> m_ThirdAffiliateKeys;

	private UIGrid m_ThirdTabsGrid;

	private uint m_AffiliateTab;

	private int m_LeftOffset;

	private int m_RightOffset;

	private bool m_ShowModel;

	private AwardDesc m_CurrentPreviewItem;

	protected bool m_IsHideByPreviewPop;

	private const int ADSafeWidth = 1608;

	private const float TimeRootHelpOffsetX = 28f;

	private float m_TimeRootBaseLocalX;

	private static Dictionary<EActivityADFullTemplateStyle, Func<UIActivityADFullContentTemplateController, IUIActivityContent>> s_TemplateRegistry;

	public bool ShowModel => false;

	private static Dictionary<EActivityADFullTemplateStyle, Func<UIActivityADFullContentTemplateController, IUIActivityContent>> TemplateRegistry => null;

	public GameObject Root => null;

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

	public void SetData(object data)
	{
	}

	public void Reload()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
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

	public void SetViwAdjust(int leftOffset = 0)
	{
	}

	private void SetPreviewAdjust(int rightOffset = 0)
	{
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

	private void OpenPreviewInternal()
	{
	}

	public override bool IsAutoCalculatePreviewPanelSize()
	{
		return false;
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	private void SetupShell()
	{
	}

	private void ApplyThirdTabBgCdn()
	{
	}

	private void ApplyThirdToggleSelectBgCdn(UIToggleButton toggle, string url)
	{
	}

	private static void SetCdnWithFallback(GameObject fallback, UINetworkTexture target, string url)
	{
	}

	private static void SetCdn(UINetworkTexture target, string url)
	{
	}

	private void SetupTitle()
	{
	}

	private void RefreshCountDownState()
	{
	}

	private void RefreshCountDownState(uint groupId)
	{
	}

	private void SetupPreviewTimeLockLabel()
	{
	}

	private void SetupHelpBtn()
	{
	}

	private void AdjustTimeRootPosition(bool showHelp)
	{
	}

	private EActivityADFullTemplateStyle ResolveTemplateStyle(List<ClientActivityDesc> list)
	{
		return EActivityADFullTemplateStyle.None;
	}

	private void OpenTemplateBody(object bodyData)
	{
	}

	private int GetTemplatePreviewOffset(EActivityADFullTemplateStyle style)
	{
		return 0;
	}

	private void CloseTemplateBody()
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

	private void OnHelpBtnClicked()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsAutoCalculatePreviewPanelSize()
	{
		return false;
	}
}
