using System;
using GCommon;
using proto;

namespace COW;

internal class UICupMatchReviewRewardListController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<CupChestDesc> _003C_003E9__9_0;

		internal int _003CRefreshReward_003Eb__9_0(CupChestDesc a, CupChestDesc b)
		{
			return 0;
		}
	}

	private UICupMatchReviewRewardListView m_View;

	private UIModelCupMatch m_ModelCupMatch;

	private int m_CupMatchKey;

	private bool m_IsTicket;

	private bool m_IsLeft;

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

	public void SetData(int cupMatchKey, bool isLeft, bool isTicket)
	{
	}

	private void RefreshReward()
	{
	}

	private void RefreshCupMatchReward()
	{
	}

	private void OnTicketStateChange(object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
