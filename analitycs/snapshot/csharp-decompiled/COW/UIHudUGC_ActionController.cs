using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIHudUGC_ActionController : UIHUDUGC_InternalHudController
{
	private UIHudUGC_ActionView m_View;

	private UGCActionHudRepItem m_ViewData;

	private string m_TriggerEntityID;

	private List<object> m_ParamsList;

	private bool m_IsIconRefreshed;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetEntityID(string entityID)
	{
	}

	public override void DestroyEntity()
	{
	}

	private void OnOpenStateChanged(bool cur)
	{
	}

	private void OnEntityIDChanged(string cur)
	{
	}

	private void OnParamsChanged(List<object> cur)
	{
	}

	private void RefreshUIByTriggerEntity()
	{
	}

	private void OnBtnActionClick()
	{
	}

	private void OnBlockClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}
}
