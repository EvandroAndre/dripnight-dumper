using System;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIUGCSaveAsNewSlotItemController : UIBaseController
{
	public enum ESaveAsType
	{
		ESaveAsType_Lobby,
		ESaveAsType_InGame
	}

	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public UIUGCSaveAsNewSlotItemController _003C_003E4__this;

		public bool needPop;

		internal void _003COnBtnClick_003Eb__0()
		{
		}

		internal void _003COnBtnClick_003Eb__1(bool b)
		{
		}

		internal void _003COnBtnClick_003Eb__3()
		{
		}

		internal void _003COnBtnClick_003Eb__4()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass16_1
	{
		public bool b;

		public _003C_003Ec__DisplayClass16_0 CS_0024_003C_003E8__locals1;

		internal void _003COnBtnClick_003Eb__2()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public UIUGCSaveAsNewSlotItemController _003C_003E4__this;

		public HNDHJGJILHC game;

		internal void _003COnExportAndSave_003Eb__0(bool result)
		{
		}
	}

	private UIUGCSaveAsNewSlotItemView m_View;

	private SceneEditSlotInfo m_DestSlotInfo;

	private UIModelSceneEdit m_ModelSceneEdit;

	private SceneEditSlotInfo m_SrcSlotInfo;

	private bool m_ReopenModeSetting;

	private ESaveAsType m_CurSaveAsType;

	private Action<uint> m_CallBack;

	private bool m_exportingData;

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

	public void SetUIData(SceneEditSlotInfo selectedInfo, SceneEditSlotInfo info, int index, bool reopenModeSetting = true)
	{
	}

	public void SetCallBack(Action<uint> callback)
	{
	}

	private void RefreshCDNMapIcon(SceneEditSlotInfo info)
	{
	}

	private void ProcessUnlockContent()
	{
	}

	private void OnBtnClick()
	{
	}

	private void OnExportAndSave()
	{
	}

	private void OnExportAndSaveFinished(HNDHJGJILHC game, bool success)
	{
	}

	private void ShowLobbySaveAsPop(Action callBack)
	{
	}

	private void _003CRefreshCDNMapIcon_003Eb__14_0()
	{
	}

	private void _003CRefreshCDNMapIcon_003Eb__14_1()
	{
	}

	private void _003CRefreshCDNMapIcon_003Eb__14_2()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
