using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSettingController : UIBaseController
{
	private UIHudSettingView m_View;

	private List<Transform> m_RemainInfo;

	private List<Transform> m_Settinfo;

	private bool m_ForceCheck;

	private uint frame;

	private UIPanel m_Panel;

	public static readonly int UGC_MAP_DEPTH;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnInGameChatOpen(bool isOpen)
	{
	}

	private void InitIsNewUI()
	{
	}

	private void OnBtnClick()
	{
	}

	public void SetRemainInfo(List<Transform> list1)
	{
	}

	private void Update()
	{
	}

	public void ForceCheckSettingBg()
	{
	}

	public void ShowSettingBg()
	{
	}

	private void CheckHudSettingBg()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
