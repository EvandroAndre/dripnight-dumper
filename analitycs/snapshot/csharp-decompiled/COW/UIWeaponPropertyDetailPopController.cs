using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIWeaponPropertyDetailPopController : UIPopupWindowController
{
	private UIWeaponPropertyDetailPopView m_View;

	private int m_BgHeight;

	private const int UPPADDING = 18;

	private const int DOWNPADDING = 18;

	private int LINEPADDING;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public void SetViewData(Vector3 pos, List<WeaponScoreName> scoreNames)
	{
	}

	private void SetPos(Vector3 pos)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
