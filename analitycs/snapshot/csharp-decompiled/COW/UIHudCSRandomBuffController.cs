using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHudCSRandomBuffController : UIPopupWindowController
{
	private UIHudCSRandomBuffView m_View;

	private uint LevelUpId;

	private uint RandomNewId;

	private float m_TotalTime;

	private float m_EndTime;

	private PMFDLKMCHKA phase;

	private UITimeLabelHelper m_TimeHelper;

	private Vector3 pos;

	private bool setDepth;

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

	public void SetView()
	{
	}

	private void Update()
	{
	}

	private void OnItemSelect(object[] data)
	{
	}

	private void OnBtnConfirmClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
