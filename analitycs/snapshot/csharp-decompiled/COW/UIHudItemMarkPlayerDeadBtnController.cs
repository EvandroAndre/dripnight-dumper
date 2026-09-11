using GCommon;
using UnityEngine;

namespace COW;

public class UIHudItemMarkPlayerDeadBtnController : UIBaseController
{
	private UIHudItemMarkPlayerDeadBtnView m_View;

	private Vector3 m_pinPos;

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

	public void ShowBtn(Vector3 pinPos, float hideDelayTime)
	{
	}

	private void OnClick(GameObject go)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
