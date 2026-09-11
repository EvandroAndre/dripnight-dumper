using GCommon;
using UnityEngine;

namespace COW;

public class UIHudLadderMatchResultHeroicStarController : UIBaseController
{
	private UIHudLadderMatchResultHeroicStarView m_View;

	private GameObject[] m_StarList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public GameObject[] GetStarList()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
