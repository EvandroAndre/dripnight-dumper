using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHUDUGC_RoundNumController : UIHUDUGC_InternalHudController
{
	private UIHUDUGC_RoundNumView m_View;

	private UGCRoundNumHudRepItem m_ViewData;

	public override void SetEntityID(string entityID)
	{
	}

	public override void DestroyEntity()
	{
	}

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

	private string GetText(string key, object[] param)
	{
		return null;
	}

	private void ShowRoundNum()
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

	private void OnThemeColorChanged(int cur)
	{
	}

	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
