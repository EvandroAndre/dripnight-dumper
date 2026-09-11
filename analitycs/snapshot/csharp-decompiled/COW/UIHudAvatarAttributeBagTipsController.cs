using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudAvatarAttributeBagTipsController : UIPopupWindowController
{
	private UIHudAvatarAttributeBagTipsView m_View;

	private const float m_HeightSpace = 40f;

	private UIRoot m_UIRoot;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	public void SetDetailTips(Vector3 tipsPos, string title, string desc)
	{
	}

	private void SetPosition(Vector3 itemPos)
	{
	}

	public override int MinGroupDepth()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public int _003C_003EiFixBaseProxy_MinGroupDepth()
	{
		return 0;
	}
}
