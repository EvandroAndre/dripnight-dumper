using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIAcitivtyPreloginContentController : UIActivityContentController
{
	private UIActivityPreloginContentView m_View;

	private ActivityGroupDesc m_GroupDesc;

	private List<ActivityPreloginDescription> m_AwardDescUIs;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetData(object data)
	{
	}

	private void UpdateActivityInfo()
	{
	}

	private void CreateEventDescList()
	{
	}

	private ActivityPreloginDescription CreateEventDesc(ClientActivityDesc desc)
	{
		return null;
	}

	public override void Reload()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetData(object P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Reload()
	{
	}
}
