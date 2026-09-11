using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;

namespace COW;

internal class UISceneEditAssetStoreReportController : UIPopupWindowController
{
	private class ReportToggleItem
	{
		public UICheckboxButton Toggle;

		public AssetStoreReportConfig AssetStoreReportConfig;
	}

	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public ReportToggleItem item;

		public UISceneEditAssetStoreReportController _003C_003E4__this;

		internal void _003CInitToggles_003Eb__0()
		{
		}
	}

	public static readonly uint COMMONREPORT;

	public static readonly uint OTHERREPORT;

	private List<ReportToggleItem> m_CommonReportToggles;

	private List<ReportToggleItem> m_OtherReportToggles;

	private UISceneEditReportView m_View;

	private UGCResourceShopMetaData m_MetaData;

	private UIModelSceneEdit m_Model;

	private SceneEditResourceShopManager m_Manager;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetUIData(UGCResourceShopMetaData metaData)
	{
	}

	private void InitToggles()
	{
	}

	private void OnToggleSelected(ReportToggleItem item)
	{
	}

	private void OnBtnConfirmClick()
	{
	}

	private void OnReportFinished()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
