using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIPrivilegeIconController : UIBaseController
{
	private GameObject m_VFX;

	private Dictionary<ResourceID, GameObject> m_VFXDict;

	private PrimePrivilegeDetail m_PrimeInfo;

	private bool m_AddClickMask;

	private UIModelRole m_ModelRole;

	private UIModelProfile m_ModelProfile;

	private bool m_IsPrimeTipsOpen;

	private UIPrivilegeIconView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void EnbaleBtn(PrimePrivilegeDetail primeInfo, bool addClickMask = false)
	{
	}

	public void SetIconData(uint type, uint levelID, bool isInGame = false)
	{
	}

	private void SetVFX(ResourceID iconVfxRes)
	{
	}

	private void SetScale()
	{
	}

	private void OnIconBtnClick()
	{
	}

	public void TryClosePrimeTips()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
