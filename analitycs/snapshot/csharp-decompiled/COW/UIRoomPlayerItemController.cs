using System.Collections.Generic;
using GCommon;
using UnityEngine;
using tcp;

namespace COW;

public class UIRoomPlayerItemController : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public int from;

		public int to;

		public UIRoomPlayerItemController _003C_003E4__this;

		internal void _003COnItemClick_003Eb__0()
		{
		}
	}

	private static Color NAME_NORMAL;

	private static Color NAME_WARNING;

	private static Color OFFLINE;

	private UIPrivilegeIconController m_PrivilegeIconController;

	private GameObject m_AdvEffect;

	private GameObject m_AdvEffectNotSelf;

	private UIRoomPlayerItemView m_View;

	private RoomPlayerInfo m_info;

	private bool m_IsEmptySeat;

	private uint m_TeamIndex;

	private uint m_MemberIndex;

	private const uint MAX_VERSION = 2u;

	private UIModelCustomRoom m_Model;

	private AutoChangeComp m_AutoChangeComp;

	private BitArrayBoolean m_MaxInfoFlag;

	private uint BMaxIconMid;

	private uint BMaxIconBot;

	private uint BSimulationIcon;

	private uint BSimulationScore;

	private float EXTERNAL_SCALE;

	public bool IsEmptySeat => false;

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

	public void SetUIData(RoomPlayerInfo info, int teamIndex, int memberIndex)
	{
	}

	private void UpdateOwnerUI()
	{
	}

	private void SetSimulationInfo()
	{
	}

	private void ShowSimulationInfo()
	{
	}

	private void HideSimulationInfo()
	{
	}

	private void HideMaxInfo()
	{
	}

	private void ShowMaxInfo()
	{
	}

	private void CheckOfflineState()
	{
	}

	private void CheckMaxInfoState()
	{
	}

	private void SetMapResVisible(bool b)
	{
	}

	private void SetVoiceVisible(bool b)
	{
	}

	private void SetVoiceMuteVisible(bool b)
	{
	}

	private void OnVoiceStateChange(object[] data)
	{
	}

	private bool SwitchValidCheck(int from, int to)
	{
		return false;
	}

	private void UpdateNickNameAndAlias()
	{
	}

	private void UpdateRepeatActiveSkill(Dictionary<ulong, HashSet<ulong>> accountIDs)
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void InfoGridReposition()
	{
	}

	private void OnMuteClick()
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

	private void RefreshBRAntiAddictionIcon()
	{
	}

	private void _003COnItemClick_003Eb__25_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
