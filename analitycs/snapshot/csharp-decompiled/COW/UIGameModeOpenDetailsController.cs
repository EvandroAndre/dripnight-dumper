using GCommon;
using UnityEngine;

namespace COW;

internal class UIGameModeOpenDetailsController : UIBaseController
{
	private UIGameModeOpenDetailsView m_View;

	private Vector3 m_DefaultOpenPos;

	private MapModeData m_SelectedMapData;

	private UIModelMapOpeningInfo m_ModelMap;

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	public void SetUIData(MapModeData mapModeData)
	{
	}

	public bool CheckOpenTimeIsActive()
	{
		return false;
	}

	public void SetOpenTimeUI()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}
}
