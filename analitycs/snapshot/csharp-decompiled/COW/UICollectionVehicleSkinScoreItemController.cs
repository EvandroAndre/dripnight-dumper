using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UICollectionVehicleSkinScoreItemController : UIBaseController
{
	private UICollectionVehicleSkinScoreItemView m_View;

	private List<GameObject> m_UpIconList;

	private List<GameObject> m_DownIconList;

	private Color COLOR_SCORE_RED;

	private Color COLOR_SCORE_GREEN;

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

	public void SetUIData(string name, int scoreVal)
	{
	}

	public void SetArrowOffSet(int x)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
