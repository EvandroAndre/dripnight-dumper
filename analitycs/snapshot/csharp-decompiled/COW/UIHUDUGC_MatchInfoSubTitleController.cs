using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHUDUGC_MatchInfoSubTitleController : UIHUDUGC_InternalHudController
{
	private UIHUDUGC_MatchInfoSubTitleView m_View;

	private UGCMatchInfoSubTitleHudRepItem m_ViewData;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void SetEntityID(string entityID)
	{
	}

	public override void DestroyEntity()
	{
	}

	private string GetText(string key, object[] param)
	{
		return null;
	}

	private void ShowSubTitle()
	{
	}

	private void OnOpenStateChanged(bool cur)
	{
	}

	private void OnLocSwitchChanged(bool cur)
	{
	}

	private void OnTextKeyChanged(string cur)
	{
	}

	private void OnTextKey_ParamsChanged(List<object> cur)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}
}
