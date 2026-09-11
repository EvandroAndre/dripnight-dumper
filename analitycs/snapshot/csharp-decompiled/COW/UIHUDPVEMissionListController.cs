using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDPVEMissionListController : UIBaseController
{
	private const int m_MaxItemNum = 6;

	private float m_ItemHeight;

	private int m_CurTopItemIndex;

	private Coroutine m_AnimCoroutine;

	private Queue<UIHUDPVEMissionItemController> m_ItemControllers;

	private UIHUDPVEMissionListView m_View;

	public Transform ItemContainer => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void OnMissionCome(string content, Vector3 topAnimStartLocalPos, float topAnimStartWidth)
	{
	}

	private void PlayAnim()
	{
	}

	private void TopItemAnim(UIHUDPVEMissionItemController item, Vector3 targetPos)
	{
	}

	private void LowItemAnim(UIHUDPVEMissionItemController item, Vector3 targetPos)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
