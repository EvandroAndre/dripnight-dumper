using GCommon;
using proto;

namespace COW;

public class UIDownloadCentreTabItemController : UIBaseController, IUIModelDataChangeObserver
{
	private UIDownloadCentreTabItemView m_View;

	private uint m_CategoryTypeId;

	private PatchOptionalTypeManagerData m_ShowData;

	private bool m_IsSelected;

	private EDownloadContextState m_LastShowState;

	private DownloadInfoGroup m_DownloadInfo;

	private UIModelOptionalDownload m_Model;

	private UIDownloadCentreController m_Parent;

	private const string TABREWARDSELECTEDNAME = "UI_Icon_gift03";

	private const string TABREWARDUNSELECTEDNAME = "UI_Icon_gift02";

	private const string PrecentStr = "{0}%";

	private const uint DownloadPrecentUint = 100u;

	private bool m_OptimizePrecentStr;

	private MutableString m_ShowDownloadedTextSb;

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetViewData(uint typeId)
	{
	}

	public void SetParent(UIDownloadCentreController parentCtrl)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetHighLightBGState(bool show)
	{
	}

	public void OnItemBtnClick()
	{
	}

	public void OnTabItemSelect(uint selectedTypeId)
	{
	}

	private void Update()
	{
	}

	private void RefreshProgressText_Old(bool forceRefresh = false)
	{
	}

	private void RefreshProgressText_New(bool forceRefresh = false)
	{
	}

	private void RefreshProgressText(bool forceRefresh = false)
	{
	}

	private void StartBtnClick()
	{
	}

	private void PauseBtnClick()
	{
	}

	private void PendingBtnClick()
	{
	}

	private void InitBtnShowState()
	{
	}

	private void ChangeBtnShowState(bool forceRefresh = false)
	{
	}

	private void RefreshRewardBtnState()
	{
	}

	public void SwitchShowState()
	{
	}

	private void OnRewardBtnClick()
	{
	}

	private EActivity.State GetpriorityState(EActivity.State old_state, EActivity.State new_state)
	{
		return EActivity.State.State_RECEIVED;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
