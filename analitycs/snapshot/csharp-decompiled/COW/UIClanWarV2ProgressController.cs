using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIClanWarV2ProgressController : UIBaseController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<GuildWarMemberStats, uint> _003C_003E9__40_0;

		internal uint _003CRefreshCSMatchResult_003Eb__40_0(GuildWarMemberStats x)
		{
			return 0u;
		}
	}

	private sealed class _003C_003Ec__DisplayClass37_0
	{
		public int lastOne;

		internal bool _003CRefreshViewBySelectedRegion_003Eb__2(LeaderBoardInfo x)
		{
			return false;
		}
	}

	private sealed class _003CStartNumberRoll_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public uint startPoint;

		public uint endPoint;

		public UIClanWarV2ProgressController _003C_003E4__this;

		private float _003ClerpValue_003E5__2;

		private float _003Cspeed_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStartNumberRoll_003Ed__49(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private const string UP_ANIM = "UIFX_UIClanWarV2Progress_UP";

	private const string DOWN_ANIM = "UIFX_UIClanWarV2Progress_Down";

	private Vector3 DOWN_ARROW_SCALE;

	private Color UP_COLOR;

	private Color DOWN_COLOR;

	private UIClanWarV2ProgressView m_View;

	private UIModelClanWarV2 m_ModelWar;

	private int m_DistanceToLast;

	private int m_DistanceToNext;

	private float m_LeftPos;

	private float m_LeftAnchor;

	private float m_RightPos;

	private float m_RightAnchor;

	private UIModelLeaderBoard m_ModelLeaderBoard;

	private UIModelClan m_ModelClan;

	private LeaderBoardInfo m_SelfInfo;

	private LeaderBoardInfo m_LastClanInfo;

	private LeaderBoardInfo m_NextClanInfo;

	private uint m_NotifyID;

	private ELeaderBoardTitleRegionType m_SelectedRegion;

	private bool m_OnBoard;

	private uint m_Rank;

	private bool m_IsCS;

	private UILabel ScoreLabel;

	private Animation RankChangeAnim;

	private GameObject RankChange;

	private GameObject Up;

	private GameObject Down;

	private UISprite Arrow;

	private UILabel RankChangeLabel;

	private Vector3 m_ContentOriginPosition;

	private Vector3 m_ContentOriginDownPosition;

	private Vector3 m_OriginClanAreaDeleteLabelPos;

	private List<UIClanWarCSMatchResultBarItemController> m_CSMatchResultList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void GotoLeaderboard()
	{
	}

	public void RefreshViewBySelectedRegion(uint notifyID = 0u, ELeaderBoardTitleRegionType type = ELeaderBoardTitleRegionType.None)
	{
	}

	private void InitState()
	{
	}

	private void SetDefultState()
	{
	}

	private void RefreshCSMatchResult()
	{
	}

	private void RefreshRankChange()
	{
	}

	private void RefreshDistance()
	{
	}

	private void SetLastClanInfo()
	{
	}

	private void SetNextClanInfo()
	{
	}

	private void SetTitleIcon()
	{
	}

	private void OnRuleBtnClick()
	{
	}

	private void OnMatchResultClick()
	{
	}

	private void ShowScoreNumber(uint number)
	{
	}

	private IEnumerator StartNumberRoll(uint startPoint, uint endPoint)
	{
		return null;
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private bool _003CRefreshViewBySelectedRegion_003Eb__37_0(LeaderBoardInfo x)
	{
		return false;
	}

	private bool _003CRefreshViewBySelectedRegion_003Eb__37_1(LeaderBoardInfo x)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
