using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UICustomRoomController : UIRoomBaseController, IEasyList
{
	private bool m_AutoShowOBListOnlyOnce;

	private bool m_HostActiveState;

	private UIHostInactivePromptController m_HostInactivePromptController;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	private void Update()
	{
	}

	private void RefreshOwnerInfo()
	{
	}

	protected override bool IsShowInviteBtn()
	{
		return false;
	}

	protected override bool IsShowOB()
	{
		return false;
	}

	protected override bool IsShowToggleDisplayTypeBtn()
	{
		return false;
	}

	protected override bool IsShowInfoPanelOpenBtn()
	{
		return false;
	}

	protected override bool IsShowLoadOut()
	{
		return false;
	}

	public override bool IsFreeToStartRoom()
	{
		return false;
	}

	protected override EInventory.ItemSubType RoomCardType()
	{
		return EInventory.ItemSubType.ItemSubType_NONE;
	}

	protected override void OnBtnGameStartCallBack()
	{
	}

	protected override string GetCurrentGameStartInfo()
	{
		return null;
	}

	protected override void OnBtnCustomize()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override List<RoomGameSettingData> PrepareGameSettingData()
	{
		return null;
	}

	public override bool OverwriteBackButtonLogic()
	{
		return false;
	}

	protected override void RefreshUIData(bool mapModeChanged)
	{
	}

	private void OnHostRecoverBtnClick()
	{
	}

	private void OnSendRecruitSuccess()
	{
	}

	public void RefreshHostActivityStatusUI(bool isHostActive)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public bool _003C_003EiFixBaseProxy_IsFreeToStartRoom()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public List<RoomGameSettingData> _003C_003EiFixBaseProxy_PrepareGameSettingData()
	{
		return null;
	}

	public new bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_RefreshUIData(bool P0)
	{
	}
}
