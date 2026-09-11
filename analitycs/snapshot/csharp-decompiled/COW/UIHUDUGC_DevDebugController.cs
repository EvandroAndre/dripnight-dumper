using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHUDUGC_DevDebugController : UIPopupWindowController
{
	public struct UGCGSConnectInfo
	{
		public string IP;

		public uint Port;

		public uint ClientCount;

		public uint TeamID;

		public ulong MatchID;

		public uint MapID;

		public bool FillBot;

		public bool StrictMode;

		public string MapURL;
	}

	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public UIHUDUGC_DevDebugController _003C_003E4__this;

		public HNDHJGJILHC game;

		public UIModelSceneEdit sceneEdit;

		public UGCGSConnectInfo info;

		internal void _003CConnectMatch_003Eb__0(bool result)
		{
		}
	}

	private UIHUDUGC_DevDebugView m_View;

	private bool m_exportingData;

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

	private void InitViewData()
	{
	}

	private void OnBtnCloseClick()
	{
	}

	private void OnBtnCreateMatchClick()
	{
	}

	private void OnBtnJoinMatchClick()
	{
	}

	private void SaveGsConfig(UGCGSConnectInfo info)
	{
	}

	private UGCGSConnectInfo ParseGSConnectInfo()
	{
		return default(UGCGSConnectInfo);
	}

	private void ConnectMatch(UGCGSConnectInfo info)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
