using GCommon;
using UnityEngine;

namespace COW;

public class UITrainMapSlotItemController : UIEasyListItemController
{
	private const int DIFFICULTY_EASY = 1;

	private const int DIFFICULTY_NORMAL = 2;

	private const int DIFFICULTY_HARD = 3;

	private UITrainMapSlotItemView m_View;

	private UITrainingCenterController.TrainingCourseData m_Data;

	private UINewDownloadInfoController m_DownloadCtrl;

	private UIModelSceneEdit m_ModelSceneEdit;

	private UIModelActivity m_ModelActivity;

	private EDownloadShowState m_PreDownloadState;

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

	public override void SetViewData(object data, int dataIndex)
	{
	}

	private void RefreshUI()
	{
	}

	private void RefreshCover()
	{
	}

	private string GetCoverUrl()
	{
		return null;
	}

	private void SetDifficultyTag(int difficulty)
	{
	}

	private Color GetDifficultyColor(int difficulty)
	{
		return default(Color);
	}

	private string GetDifficultyText(int difficulty)
	{
		return null;
	}

	private bool CheckCourseCompleted()
	{
		return false;
	}

	private void SetCompletionState(bool completed)
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	private void OnCardClick()
	{
	}

	private void RefreshDownloadUI()
	{
	}

	private void FetchAndCheckDownloadState()
	{
	}

	private void CheckResInfoAndRefresh()
	{
	}

	private void EnsureDownloadTask()
	{
	}

	private void ShowDownloadState()
	{
	}

	private void HideDownloadProgress()
	{
	}

	public bool IsDownloaded()
	{
		return false;
	}

	public void TriggerDownload()
	{
	}

	private void OnDownloadBtnClick()
	{
	}

	private void OnDownloadStateChanged()
	{
	}

	private void NotifyParentIfSelected()
	{
	}

	private string BuildDownloadPopupLog(string logKey)
	{
		return null;
	}

	private void OnRefreshDownloadCDNBtn(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
