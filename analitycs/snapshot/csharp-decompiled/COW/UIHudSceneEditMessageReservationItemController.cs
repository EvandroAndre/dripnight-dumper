using System;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudSceneEditMessageReservationItemController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__15_0;

		internal void _003CAfterAgreen_003Eb__15_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public ReserveReplyStatus status;

		public UIHudSceneEditMessageReservationItemController _003C_003E4__this;

		internal void _003CSetData_003Eb__0()
		{
		}
	}

	private UIHudSceneEditMessageReservationItemView m_View;

	private UIModelTeamReserve m_Model;

	private FriendAccountInfo m_Friend;

	private UIModelLadderMatch m_ModelLadderMatch;

	private UIModelCSLadderMatch m_ModelCSLadderMatch;

	private string m_ReservationStr;

	private uint m_DelayCallExpired;

	private Vector3 m_DefaultRankScale;

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

	private void InitView()
	{
	}

	public void SetData(ulong id, ReserveReplyStatus status)
	{
	}

	private void OnAgreeBtnClick()
	{
	}

	private void OnRejectBtnClick()
	{
	}

	private void AfterAgreen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
