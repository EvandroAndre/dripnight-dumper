using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudClanGameInfoController : UIBaseController
{
	private UIHudClanGameInfoView m_View;

	private UIModelClanWarV2 m_ModelClanWarV2;

	private const uint TOPITEMCOUNT = 3u;

	private Vector2 NORMALITEM_SIZE;

	private ulong m_StartShowTime;

	private ulong m_ShowTime;

	private bool m_firstHidePage;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private void SetControlStatus()
	{
	}

	protected override void OnUIInit()
	{
	}

	public override void Show()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override void Hide()
	{
	}

	private void ShowRankBtn()
	{
	}

	private void InitGameInfoItemTemplate()
	{
	}

	private void InitGameInfoItemList()
	{
	}

	private void ScrollToMyClan()
	{
	}

	private void RefreshView()
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

	private UITable2.IUITable2Item _003CInitGameInfoItemTemplate_003Eb__14_0()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
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
