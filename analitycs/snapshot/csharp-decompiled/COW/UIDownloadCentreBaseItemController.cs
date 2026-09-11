using GCommon;
using UnityEngine;

namespace COW;

public class UIDownloadCentreBaseItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	protected UIButton downloadBtn;

	protected UIButton pauseDownloadBtn;

	protected UIButton inPendingBtn;

	protected UISprite rewardIcon;

	protected UIButton rewardBtn;

	protected GameObject rewardEffect;

	protected UISprite progressBar;

	protected UILabel progressLabel;

	protected UILabel title;

	protected GameObject finishIcon;

	protected UILabel rewardNum;

	protected GameObject downloadingEffect;

	protected GameObject recommendTagIcon;

	protected UIButton rewardTip;

	protected UIToggle deletedToggle;

	protected UILabel deletedStroage;

	protected BoxCollider containerDragCollider;

	protected GameObject downloadState;

	protected GameObject deleteState;

	protected GameObject mask;

	protected UIModelOptionalDownload m_Model;

	protected uint m_OptionalReDefId;

	protected PatchOptionalResManagerData m_ManagerShowData;

	protected PatchOptionalCategoryManagerData m_DownloadShowInfo;

	protected EDownloadContextState m_LastDownloadState;

	protected TagDownloadInfo m_DownloadInfo;

	protected UIDownloadCentreController parentCtrl;

	protected bool rewardTipsShow;

	private float m_PreDownloadedSize;

	private float m_PreDeletedDownloadedSize;

	private float m_PreTotalZipSize;

	private uint m_PreDownloadTagId;

	private MutableString m_ShowDownloadedTextSb;

	private MutableString m_ShowTotalZipTextSb;

	private EDownloadCentreDownloadState m_LastContextState;

	protected override void OnUIInit()
	{
	}

	private void OnStartDownloadClick()
	{
	}

	private void OnPauseDownloadClick()
	{
	}

	private void OnPendingBtnClick()
	{
	}

	protected void OnRewardTipsBtnClick()
	{
	}

	protected void OnDeletedToggleClick()
	{
	}

	private void OnRewardBtnClick()
	{
	}

	protected virtual void InitRewardTipsShow()
	{
	}

	protected virtual void BtnGroupInit(bool forceRefresh = false)
	{
	}

	protected bool CheckShowRewardBtnShowState()
	{
		return false;
	}

	protected void RefreshDownloadingEffect(EDownloadContextState CurrentState)
	{
	}

	private void Update()
	{
	}

	protected virtual void RefreshProgress()
	{
	}

	private void RefreshProgress_Old(EDownloadCentreDownloadState state)
	{
	}

	private void RefreshProgress_New(EDownloadCentreDownloadState state)
	{
	}

	private void InitRewardRelativeShow()
	{
	}

	private void RefreshRecommendShow(bool show)
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void CheckThisOptionalIsDeleted()
	{
	}

	public void ClearToggleState()
	{
	}

	public void ClickToggleState()
	{
	}

	public virtual void SwitchShowDownloadOrDeletedState()
	{
	}

	public void ChangeToggleShowState()
	{
	}

	public virtual void SetParent(UIDownloadCentreController downloadCentreCtrl)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
