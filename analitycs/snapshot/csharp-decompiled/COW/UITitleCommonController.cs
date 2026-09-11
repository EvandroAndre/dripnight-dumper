using GCommon;
using UnityEngine;

namespace COW;

public class UITitleCommonController : UIBaseController
{
	private GameObject m_TitleVFX;

	private TitleInfo m_Data;

	private UITitleCommonView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetView(UITitleCommonView view)
	{
	}

	public void SetViewData(TitleInfo info, bool IsSelf = false, EventDelegate.Callback onClick = null)
	{
	}

	private void SetTitleEffect()
	{
	}

	public int GetBgDepth()
	{
		return 0;
	}

	public void SetViewDataInProfileCustom(TitleInfo data, bool showButton)
	{
	}

	private void ShowCommonTips()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
