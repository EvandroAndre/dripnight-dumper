using GCommon;
using UnityEngine;

namespace COW;

public class UIHudWereWolvesWolfCountController : UIBaseController
{
	private UIHudWereWolvesWolfCountView m_View;

	private GameObject[] m_wolfList;

	private GameObject[] m_deadWolfList;

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

	protected override void OnUIOpen()
	{
	}

	private void SetAliveWolfCount(uint cur_count, uint all_count)
	{
	}

	private void RefreshWolfCount(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
