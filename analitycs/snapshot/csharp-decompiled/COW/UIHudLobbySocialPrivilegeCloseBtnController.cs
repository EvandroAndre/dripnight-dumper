using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudLobbySocialPrivilegeCloseBtnController : UIBaseController
{
	private UIHudLobbySocialPrivilegeCloseBtnView m_View;

	private Transform m_FireHud;

	public const uint VISIBILITY_STATE_DANCEPOOL = 1073741824u;

	public const uint VISIBILITY_STATE_CHANGE = 536870912u;

	public const uint VISIBILITY_STATE_EVENT = 268435456u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnLobbySocialHudStateChanged(bool visible)
	{
	}

	public override void OnUIReInit()
	{
	}

	public void SetFireHud(Transform fireHud)
	{
	}

	private void OnSetVisible(bool isVisible)
	{
	}

	private void SetVisible(bool visible)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnCloseClick()
	{
	}

	public void LogClick(string posfix)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
