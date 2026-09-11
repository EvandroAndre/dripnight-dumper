using System;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIChampionshipMemberReviewPopupController : UIPopupWindowController, IUIModelDataChangeObserver
{
	public class ApplyEasyListFacotry : IEasyList
	{
		private UIChampionshipMemberReviewPopupController teamProfile;

		public ApplyEasyListFacotry(UIChampionshipMemberReviewPopupController teamProfile)
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
		private UIChampionshipMemberReviewPopupController teamProfile;

		public InviteEasyListFacotry(UIChampionshipMemberReviewPopupController teamProfile)
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

		public static Converter<AccountInfoBasic, ulong> _003C_003E9__17_0;

		public static Converter<AccountInfoBasic, ulong> _003C_003E9__18_0;

		internal ulong _003CRejectAllApply_003Eb__17_0(AccountInfoBasic e)
		{
			return 0uL;
		}

		internal ulong _003CRejectAllInvite_003Eb__18_0(AccountInfoBasic e)
		{
			return 0uL;
		}
	}

	private UIChampionshipMemberReviewPopupView m_View;

	private UIModelChampionship m_ModelChampionship;

	protected ApplyEasyListFacotry m_ApplyEasyListFactory;

	protected InviteEasyListFacotry m_InviteEasyListFactory;

	private uint m_ChampionshipType;

	private const string TabApply = "TabApply";

	private const string TabInvite = "TabInvite";

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

	public void SetInviteView(uint championshipType)
	{
	}

	public void SetChampionshipType(uint championshipType)
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
