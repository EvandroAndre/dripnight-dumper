using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudReviveMissionBtnController : UIBaseController
{
	private UIHudReviveMissionBtnView m_View;

	private IPLIFLLGADH m_ReviveMission;

	private float m_TickCount;

	private UIGrid m_ParentGrid;

	private uint m_DelayCallID;

	private const float CLOSETIME = 3f;

	private bool m_NeedClose;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(UIGrid grid, IPLIFLLGADH mission)
	{
	}

	private void OnReviveMissionBtnClick(GameObject go, bool pressed)
	{
	}

	private void Update()
	{
	}

	private void OnReviveMissionEnd(object[] data)
	{
	}

	private void CloseHud()
	{
	}

	private UIHudInventoryTagController OpenInventoryTagFromPool(Transform transform)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
