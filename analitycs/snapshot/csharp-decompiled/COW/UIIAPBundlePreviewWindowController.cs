using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIIAPBundlePreviewWindowController : UIPopupWindowController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<IAPBundleStoreData> _003C_003E9__14_0;

		internal int _003CUpdateItemControllers_003Eb__14_0(IAPBundleStoreData a, IAPBundleStoreData b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public int[] reviewList;

		internal bool _003CUpdateItemControllers_003Eb__1(IAPBundleStoreData d)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public int index;

		public UIIAPBundlePreviewWindowController _003C_003E4__this;

		public Action _003C_003E9__1;

		internal void _003CTakeScreenshots_003Eb__0()
		{
		}

		internal void _003CTakeScreenshots_003Eb__1()
		{
		}
	}

	private UIIAPBundlePreviewWindowView m_View;

	private int m_ScreenshotIndex;

	private const float DELAY_DETAIL = 0.25f;

	private const float DELAY_BACK = 0.5f;

	private const float DELAY_SCREENSHOT = 1f;

	private List<UIIAPBundlePreviewItemController> m_ItemControllers;

	private List<IAPBundleStoreData> m_IAPBundles;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private string ScreenshotFilePath(IAPBundleStoreData data)
	{
		return null;
	}

	private void TakeScreenshots(int index = 0)
	{
	}

	public override void AfterScreenshot()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void ClearItemControllers()
	{
	}

	private void UpdateItemControllers()
	{
	}

	private void OnItemClick(IAPBundleStoreData data)
	{
	}

	private void UpdateData()
	{
	}

	private void _003CAfterScreenshot_003Eb__9_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
