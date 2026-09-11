using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHyperBookEntranceController : UIBaseController, IUIModelDataChangeObserver
{
	private const string PROGRESS_ICON_NAME = "ProgressIcon";

	private const string UNLOCK_ANIM_NAME = "VFX_UIHyperBookEntrance_lock01";

	private const string UNLOCK_ANIM_PLAYER_PREF_FORMAT_KEY = "HYPERBOOK_ENTRANCE_UNLOCK_ANIM_{0}_{1}";

	private uint m_BookID;

	private int m_Index;

	private uint m_EntranceGuideDelayCall;

	private UIHyperBookEntranceView m_View;

	private UINewDownloadInfoController m_DownloadInfoController;

	private List<ResourceID> m_NeedDownloadRes;

	private readonly List<Transform> m_ProgressUnlockIconList;

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

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void OnNotifyAssetRefresh()
	{
	}

	private void OnDownloadBtnClick()
	{
	}

	private void OnEntranceBtnClick()
	{
	}

	private void AddEventDelegate()
	{
	}

	private void SetupDownloadCtrl()
	{
	}

	private void SetupUnlockPageCount(int count)
	{
	}

	private void LoadStaticContent()
	{
	}

	private bool RefreshDynamicContent()
	{
		return false;
	}

	private void HideBook2DContentInternal()
	{
	}

	private bool GetIsUnlockAnimPlayed()
	{
		return false;
	}

	private void SetUnlockAnimPlayed()
	{
	}

	private void SetLockIconBgAlpha(float scale)
	{
	}

	private void PlayUnlockAnim()
	{
	}

	public void SetViewData(int index, uint bookItemID)
	{
	}

	public bool RefreshContent()
	{
		return false;
	}

	public float GetUnlockAnimLength()
	{
		return 0f;
	}

	public void HideBook2DContent()
	{
	}

	private bool IsBookEntranceTipsNeedShow()
	{
		return false;
	}

	private void ShowEntranceGuide()
	{
	}

	private void _003CShowEntranceGuide_003Eb__33_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
