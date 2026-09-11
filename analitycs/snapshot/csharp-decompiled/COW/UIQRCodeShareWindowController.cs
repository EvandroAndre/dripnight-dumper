using GCommon;
using UnityEngine;

namespace COW;

public class UIQRCodeShareWindowController : UIPopupWindowController
{
	private UIQRCodeShareWindowView m_View;

	private UIModelUser m_ModelUser;

	private UIModelProfile m_ModelProfile;

	private UIModelGroup m_ModelGroup;

	private UIModelCustomRoom m_ModelCustomRoom;

	private UIModelClan m_ModelClan;

	private UIModelLeaderBoard m_ModelLeaderBoard;

	private UIModelQRCode m_ModelQRCode;

	private UIInvitePlatformCommonGridController m_InvitePlatformCommonGridCtrl;

	private UIInvitePlatformCommonGridController m_RoomInvitePlatformCommonGridCtrl;

	private UIQRCodeController m_QRCodeCtrl;

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

	public void SetUIData(QRCodeType type)
	{
	}

	private void SetProfileData()
	{
	}

	private void SetTeamData()
	{
	}

	private void SetRoomData()
	{
	}

	private void SetRoomInviteState()
	{
	}

	private void SetClanData()
	{
	}

	private void SetClanInviteState()
	{
	}

	private void ClearInit()
	{
	}

	private void CreateQRCode(Transform transform, Texture2D texture)
	{
	}

	private void OnClickScanButton()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
