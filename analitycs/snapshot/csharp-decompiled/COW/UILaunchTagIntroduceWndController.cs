using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

internal class UILaunchTagIntroduceWndController : UIPopupWindowController
{
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public long subType;

		internal bool _003CRefreshCdnByIndex_003Eb__0(AdvertDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public uint subType;

		internal bool _003CInitViewData_003Eb__0(AdvertDesc x)
		{
			return false;
		}
	}

	private UILaunchTagIntroduceWndView m_View;

	private List<UILaunchTagIntroduceItemController> m_ItemList;

	private UIModelCDNAd m_ModelCDN;

	private List<AdvertDesc> m_CDNList;

	private OgTagConfigDesc m_TagConfigDesc;

	private bool m_IsCommonLaunchTag;

	private const uint COMMON_LAUNCH_TAG_CDN_SUBTYPE_START = 6u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitViewData()
	{
	}

	public bool RefreshLaunchTagDesc(uint tagID)
	{
		return false;
	}

	private void RefreshCdnByIndex(UILaunchTagIntroduceItemController.EIntroduceIndex index)
	{
	}

	public void SetCurrentIndex(UILaunchTagIntroduceItemController.EIntroduceIndex index)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
