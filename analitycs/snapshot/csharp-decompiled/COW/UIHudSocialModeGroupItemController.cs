using GCommon;
using UnityEngine;
using tcp;

namespace COW;

public class UIHudSocialModeGroupItemController : UIBaseController
{
	private enum SocialModeGroupItemState
	{
		MemberState,
		PlusState,
		EmptyState
	}

	private SocialModeGroupItemState m_State;

	private UIHudSocialModeGroupItemView m_View;

	private UIModelGroup m_ModelGroup;

	private bool m_IsShowLobbyContainer;

	private UIHudSocialModeGroupController.SocialModeGroupItemData m_data;

	private bool IsLocalPlayer;

	private Color DefaultNickNameColor;

	private Color SelfNickNameColor;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetMemberState(UIHudSocialModeGroupController.SocialModeGroupItemData data, int index)
	{
	}

	private void SetLocationState(int index)
	{
	}

	private void SetReadyState(bool ready, bool leader)
	{
	}

	private void OnClickSwitchBtn()
	{
	}

	private void RefreshLobbyShowState(bool state)
	{
	}

	public void SetPlusState()
	{
	}

	public void SetOnlySelf()
	{
	}

	public UIWidget GetBG()
	{
		return null;
	}

	public ulong GetAccountId()
	{
		return 0uL;
	}

	public void OnSyncOptionalMapResNtf(EGroup.PlayerPatchOptionalResStatus status)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
