using System;
using GCommon;

namespace COW;

public class UIClanPrivilegeSharePreviewController : UIPopupWindowController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__8_0;

		internal void _003CRefreshPreviewCDN_003Eb__8_0()
		{
		}
	}

	private UIClanPrivilegeSharePreviewView m_View;

	private UIModelClan m_ModelClan;

	private UIBaseProfileInfoController m_BaseProfile;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void RefreshView()
	{
	}

	private void RefreshPreviewCDN()
	{
	}

	private void RefreshClanInfo()
	{
	}

	private void RefreshPrivilegeInfo()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
