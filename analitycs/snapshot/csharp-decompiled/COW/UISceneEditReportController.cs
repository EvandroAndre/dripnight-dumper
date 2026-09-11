using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UISceneEditReportController : UIPopupWindowController
{
	private class ReportToggleItem
	{
		public UICheckboxButton Toggle;

		public WorkshopReportConfig WorkshopReportConfig;
	}

	private enum ReportReason
	{
		Nickname = 1,
		Violence,
		AD,
		Other
	}

	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public ReportToggleItem item;

		public UISceneEditReportController _003C_003E4__this;

		internal void _003CInitToggles_003Eb__0()
		{
		}
	}

	public static readonly uint COMMONREPORT;

	public static readonly uint OTHERREPORT;

	private List<ReportToggleItem> m_CommonReportToggles;

	private List<ReportToggleItem> m_OtherReportToggles;

	private UISceneEditReportView m_View;

	private string m_Code;

	private EUGCScene m_Src;

	private EUGCScene m_Map_Scene;

	private UIModelSceneEdit m_Model;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetUIData(string author, string name, string code, EUGCScene source, EUGCScene map_scene)
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
