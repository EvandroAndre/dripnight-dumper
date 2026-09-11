using System;
using System.Collections.Generic;
using COW.GamePlay;
using COW.Gameplay.UGC;
using GCommon;
using LitJson;
using UnityEngine;

namespace COW;

public class UIUGCDebuggerOpen : UIPopupWindowController, IUIModelDataChangeObserver, IEasyList
{
	public class DownloadInfoForLocalTest
	{
		public UGCSimpleDownloadTask DownloadTask;

		public Action OnConfirm;

		public Action OnCancel;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static ImporterFunc<double, float> _003C_003E9__65_0;

		internal float _003CParseDebugDatabaseSheet_003Eb__65_0(double input)
		{
			return 0f;
		}
	}

	private sealed class _003C_003Ec__DisplayClass37_0
	{
		public UIUGCDebuggerOpen _003C_003E4__this;

		public HNDHJGJILHC game;

		public UIModelSceneEdit sceneEdit;

		internal void _003COnButtonStartDebug_003Eb__0(EExportFailReason reason)
		{
		}
	}

	private UIUGCDebuggerOpenView m_View;

	private UIModelUGCDebugger m_Debugger;

	private int m_Height;

	public static readonly string DefaultMode;

	private bool m_exportingData;

	private readonly float m_ResDownloadCheckCoolingTime;

	private const int MAX_GEM_COUNT = 999;

	private float m_ResDownloadCheckCoolingStart;

	private bool m_IsDownloadStarted;

	private string m_FromGraphId;

	private bool m_IsPremiumViper;

	private uint m_PremiumGemCount;

	private UIPopMenuSmallControlerForScrollPanel m_PlayerDropDown;

	private Dictionary<string, Dictionary<string, LocalSheetItemData>> m_DatabaseData;

	private uint m_CurrentSlotID;

	private int m_CurrentPlayerIndex;

	private float m_reqDebugTime;

	private UINewDownloadInfoController m_OptionalMapResDownloader;

	private bool IsFillFullBot => false;

	private bool IsStrictMode => false;

	private bool IsStartFromCurCamera => false;

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

	protected override void OnUIOpen()
	{
	}

	private void OnToggleFullBot()
	{
	}

	private void OnToggleStrictMode()
	{
	}

	private void OnToggleStartMode()
	{
	}

	private void OnToggleLookMode()
	{
	}

	private void OnToggleDebuggerMode()
	{
	}

	private void OnClickGoCreatBtn()
	{
	}

	private void OnPremiumVipSwitchChanged(UIToggleButton toggle)
	{
	}

	private void OnSlidePremiumGemCount()
	{
	}

	private void OnInputPremiumGemCount()
	{
	}

	private static void OnHandleReturnToEdit()
	{
	}

	public void OnButtonStartDebug(bool forceDebugMode = false)
	{
	}

	private void StartDebug()
	{
	}

	private bool CheckNeedDownloadAndPopup()
	{
		return false;
	}

	private bool RefreshOptionalMapResDownloader(bool showDownloadPop = false)
	{
		return false;
	}

	private void OnDownloaderClicked()
	{
	}

	private void OnCancelDownload()
	{
	}

	private void ShowDownloader()
	{
	}

	private void HideDownloader()
	{
	}

	public void OpenDebugFromGraph(string graphId)
	{
	}

	public void ChangeDebuggerTogglesShow(bool show)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void UpdateReqDebugTime()
	{
	}

	public override bool IgnoreEsc()
	{
		return false;
	}

	public void SwitchToDatabaseTab()
	{
	}

	private void OnToggleSetUp(UIToggleButton selectBtn)
	{
	}

	private void RefreshPlayerDropDown()
	{
	}

	private void GeneratePlayerMenuData()
	{
	}

	private void OnPlayerDropDownItemSelected(object data)
	{
	}

	private void RefreshPlayerDataList(int playerIndex)
	{
	}

	private void AdjustPlayerDropDownDepth()
	{
	}

	private void UpdateSavedDataBgHeight(int itemCount)
	{
	}

	private Dictionary<string, LocalSheetItemData> GetDefaultPlayerAttributeData(string userID = "")
	{
		return null;
	}

	private int GetMaxPlayerCount()
	{
		return 0;
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public Dictionary<string, Dictionary<string, LocalSheetItemData>> ParseDebugDatabaseSheet(uint slotID)
	{
		return null;
	}

	public override void Hide()
	{
	}

	private void OnClickResetAllPlayerAttributes()
	{
	}

	private void SaveDatabaseDataToLocal()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public bool _003C_003EiFixBaseProxy_IgnoreEsc()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}
}
