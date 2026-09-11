using GCommon;
using UnityEngine;

namespace COW;

public class UICupMatchTeamMemberItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private static Color OnlineColor;

	private static Color OfflineColor;

	private UICupMatchTeamMemberItemView m_View;

	private UIBaseProfileInfoController m_BaseProfileUI;

	private UIModelCupMatch.AccountInfoBasicWithCupInfo m_TeamMemberData;

	private UIModelCupMatch m_ModelCupMatch;

	private int m_CupMatchKey;

	private bool m_IsSelf;

	private bool _003CShowPresence_003Ek__BackingField;

	private bool _003CShowPopupMenu_003Ek__BackingField;

	public bool ShowPresence
	{
		get
		{
			return _003CShowPresence_003Ek__BackingField;
		}
		set
		{
			_003CShowPresence_003Ek__BackingField = value;
		}
	}

	public bool ShowPopupMenu
	{
		get
		{
			return _003CShowPopupMenu_003Ek__BackingField;
		}
		set
		{
			_003CShowPopupMenu_003Ek__BackingField = value;
		}
	}

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

	private void OnProfileClick()
	{
	}

	private void OnTicketBtnClick()
	{
	}

	private void OnTierBtnClick()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void SetCupMatchKey(int key)
	{
	}

	private void RefreshTicketState()
	{
	}

	private void RefreshSelfTicketState()
	{
	}

	private void RefreshTeammateTicketState()
	{
	}

	private void UpdateOnlineStateView()
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

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
