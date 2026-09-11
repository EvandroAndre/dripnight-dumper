using GCommon;
using UnityEngine;
using tcp;

namespace COW;

public class UIRoomObserverItemController : UIBaseController
{
	private static Color NAME_NORMAL;

	private static Color NAME_WARNING;

	private UIWidget m_ItemWidget;

	private UIRoomObserverItemView m_View;

	private GameObject m_AdvEffect;

	private GameObject m_AdvEffectNotSelf;

	private float EXTERNAL_SCALE;

	private RoomPlayerInfo m_info;

	private bool m_IsEmptySeat;

	private UIModelCustomRoom m_Model;

	private UIPrivilegeIconController m_PrivilegeIconController;

	private const float NAME_OFFSET = 15f;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void ResetWidgetWidth()
	{
	}

	private void OnItemClick()
	{
	}

	private void OnGotoSeat(object data)
	{
	}

	public void SetUIData(RoomPlayerInfo info, int id)
	{
	}

	private void UpdateOwnerUI()
	{
	}

	private void OnMuteClick()
	{
	}

	private void SetVoiceMuteVisible(bool b)
	{
	}

	private void InfoGridReposition()
	{
	}

	private void SetVoiceVisible(bool b)
	{
	}

	public void SetEmptyUIData()
	{
	}

	private void OnVoiceStateChange(object[] data)
	{
	}

	private void OnMutePlayerStateChange(object[] data)
	{
	}

	private void OnSpeakerChange(int value)
	{
	}

	private void SetPrivilegeIcon(uint mainType, uint subType)
	{
	}

	private void _003COnItemClick_003Eb__15_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
