using System;
using GCommon;

namespace COW;

public class UIOfflinePlayTipsController : UIBaseController
{
	private UIOfflinePlayTipsView m_View;

	private EOfflineTipsSource m_Source;

	private Action m_OnOfflinePlayClick;

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

	public void SetViewData(EOfflineTipsSource source, Action onOfflinePlayClick = null)
	{
	}

	private void CheckLangRes()
	{
	}

	private void SetLabelBySource()
	{
	}

	private void ApplyAlignment()
	{
	}

	private void ApplyRightAlignment()
	{
	}

	private void OnOfflinePlayBtnClick()
	{
	}

	public void SetOfflinePlayTipsLabel(string tips, string offlinePlay)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
