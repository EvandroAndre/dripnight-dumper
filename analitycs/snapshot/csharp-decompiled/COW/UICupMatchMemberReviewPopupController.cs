using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UICupMatchMemberReviewPopupController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private enum PageType
	{
		Apply,
		Invite
	}

	public class ApplyEasyListFacotry : IEasyList
	{
		private UICupMatchMemberReviewPopupController teamProfile;

		public ApplyEasyListFacotry(UICupMatchMemberReviewPopupController teamProfile)
		{
		}

		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}
	}

	public class InviteEasyListFacotry : IEasyList
	{
		private UICupMatchMemberReviewPopupController teamProfile;

		public InviteEasyListFacotry(UICupMatchMemberReviewPopupController teamProfile)
		{
		}

		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<UIModelCupMatch.AccountInfoBasicWithCupInfo, ulong> _003C_003E9__17_0;

		public static Converter<UIModelCupMatch.AccountInfoBasicWithCupInfo, ulong> _003C_003E9__18_0;

		internal ulong _003CRejectAllApply_003Eb__17_0(UIModelCupMatch.AccountInfoBasicWithCupInfo e)
		{
			return 0uL;
		}

		internal ulong _003CRejectAllInvite_003Eb__18_0(UIModelCupMatch.AccountInfoBasicWithCupInfo e)
		{
			return 0uL;
		}
	}

	private UICupMatchMemberReviewPopupView m_View;

	private UIModelCupMatch m_ModelCupMatch;

	protected ApplyEasyListFacotry m_ApplyEasyListFactory;

	protected InviteEasyListFacotry m_InviteEasyListFactory;

	private int m_CupMatchKey;

	private PageType m_PageType;

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

	public void SetInviteView(int cupMatchKey)
	{
	}

	public void SetCupMatchType(int cupMatchKey)
	{
	}

	public void SetApplyAndInviteView()
	{
	}

	private void ShowApplyPage()
	{
	}

	private void ShowInvitePage()
	{
	}

	private void RejectAllApply()
	{
	}

	private void RejectAllInvite()
	{
	}

	private void UpdateInvitation()
	{
	}

	private void UpdateApplicant()
	{
	}

	private void UpdateInvitationRedTips()
	{
	}

	private void UpdateApplicationRedTips()
	{
	}

	private void OnRefreshBtnClick()
	{
	}

	private void SetRefreshBtnState()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003CSetRefreshBtnState_003Eb__24_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
