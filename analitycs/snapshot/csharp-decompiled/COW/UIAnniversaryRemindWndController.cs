using GCommon;
using proto;

namespace COW;

public class UIAnniversaryRemindWndController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private UIAnniversaryRemindWndView m_View;

	private UIStandardItemMiniController m_ItemCtrl;

	private BirthdayConfigData m_Data;

	private UIModelAchievement m_Model;

	private AchievementEntryDesc m_EntryDesc;

	private bool m_NeedRequestUpdate;

	private ulong m_StartShowTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	protected override void OnUIDestory()
	{
	}

	public void SetViewData(uint anniversaryYear, bool isAutoTask)
	{
	}

	private void OnShareBtnClick()
	{
	}

	private void OnClaimBtnCLick()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void RefreshItem()
	{
	}

	private void PlayAnimIn()
	{
	}

	private void PlayAnimReward()
	{
	}

	private void PlayAnimInWithGiftGot()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
