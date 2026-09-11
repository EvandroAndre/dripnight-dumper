using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudPlayerMarkWinterlandController : UIBaseController
{
	private UIHudPlayerMarkWinterlandView m_View;

	private Vector3 m_WorldPos;

	private UIMapUtil.EMapType m_MapType;

	private int m_PreDistance;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void Update()
	{
	}

	public void SetInfo(int playerTeamIndex, Vector3 iconWorldPos, UIMapUtil.EMapType mapType)
	{
	}

	private void UpdateDistanceTxt()
	{
	}

	private void ShowDistanceTxt(int distance)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
