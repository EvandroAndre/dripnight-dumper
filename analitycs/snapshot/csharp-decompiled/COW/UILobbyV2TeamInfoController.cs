using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using tcp;

namespace COW;

internal class UILobbyV2TeamInfoController : UIPopupWindowController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<uint> _003C_003E9__29_0;

		internal bool _003CAssembleIconGrid_003Eb__29_0(uint x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public UILobbyV2TeamInfoController _003C_003E4__this;

		public ulong memberAccountId;

		public GroupMemberInfo dest;

		internal bool _003COnGroupKickOutPopMenuClick_003Eb__0(GroupMemberInfo temp)
		{
			return false;
		}

		internal void _003COnGroupKickOutPopMenuClick_003Eb__1()
		{
		}
	}

	private UILobbyV2TeamInfoView m_View;

	private List<UILobbyV2TeamInfoIconController> m_IconList;

	private List<UILobbyV2TeamInfoItemController> m_MemberList;

	private UIModelGroup m_ModelGroup;

	private List<uint> m_IconTypeList;

	private BitArrayBoolean m_GroupCodeEnable;

	private const uint GroupCodeNormalLogic = 1u;

	private const uint GroupCodeRoomHangupLogic = 2u;

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

	private void OnTeamRankLimitTipsClick()
	{
	}

	private void OnRecruitBtnClick()
	{
	}

	private void SetGroupCodeData(object[] param)
	{
	}

	private void OnTransferLeaderBtnClick()
	{
	}

	private void OnTransferLeaderPopMenuClick(ulong id)
	{
	}

	private void OnGroupKickOutBtnClick()
	{
	}

	private void OnGroupKickOutPopMenuClick(ulong id)
	{
	}

	private void OpenPopMenu(Vector3 position, string title, Action<ulong> callback)
	{
	}

	private void OnQuitBtnClick()
	{
	}

	private void OnQRCodeBtnClick()
	{
	}

	public void OnRoomHangupChange(bool isHangUp)
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	private void AssembleIconGrid(List<uint> iconList)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public override int MinGroupDepth()
	{
		return 0;
	}

	private void _003COnQuitBtnClick_003Eb__25_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public int _003C_003EiFixBaseProxy_MinGroupDepth()
	{
		return 0;
	}
}
