using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHippoCrisisLobbyTeamInfoController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private UIHippoCrisisLobbyTeamInfoView m_View;

	private UIModelGroup m_ModelGroup;

	private UIModelHippoCrisis m_ModelHippoCrisis;

	private List<UIHippoCrisisLobbyTeamInfoItemController> m_MemberList;

	private BitArrayBoolean m_GroupCodeEnable;

	private const uint GroupCodeNormalLogic = 1u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public void RefreshView()
	{
	}

	private void RefreshSelfEquipView()
	{
	}

	private void OnClickMaskClick()
	{
	}

	private void OnCodeCopyBtnClick()
	{
	}

	private void OnGroupCodeBtnClick()
	{
	}

	private void OnGroupCodeHelperBtnClick()
	{
	}

	private void OnGroupTeammateClick()
	{
	}

	private void OnQRCodeBtnClick()
	{
	}

	private void SetGroupCodeData(object[] param)
	{
	}

	protected override void OnUIDestory()
	{
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

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
