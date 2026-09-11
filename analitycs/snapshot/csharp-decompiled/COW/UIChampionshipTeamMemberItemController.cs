using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIChampionshipTeamMemberItemController : UIEasyListItemController
{
	private static Color OnlineColor;

	private static Color OfflineColor;

	private UIChampionshipTeamMemberItemView m_View;

	private UIBaseProfileInfoController m_BaseProfileUI;

	private TeamMemberWithAccountInfo m_TeamMemberData;

	private UIModelChampionship m_ModelChampionship;

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

	protected override void OnUIClose()
	{
	}

	private void OnProfileClick()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void UpdateOnlineStateView()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
