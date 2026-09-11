using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UISeasonReplayOverviewController : UIBaseController, IUISeasonReplayItem
{
	private class RankingSeasonReplayEventCluster
	{
		private float _003CRatio_003Ek__BackingField;

		private List<RankingSeasonReplayEvent> _003CHighlights_003Ek__BackingField;

		public float Ratio
		{
			get
			{
				return _003CRatio_003Ek__BackingField;
			}
			private set
			{
				_003CRatio_003Ek__BackingField = value;
			}
		}

		public List<RankingSeasonReplayEvent> Highlights
		{
			get
			{
				return _003CHighlights_003Ek__BackingField;
			}
			private set
			{
				_003CHighlights_003Ek__BackingField = value;
			}
		}

		public RankingSeasonReplayEventCluster()
		{
		}

		public RankingSeasonReplayEventCluster(float ratio)
		{
		}
	}

	private class Linear
	{
		private float mk;

		private float mb;

		public Linear(float x1, float y1, float x2, float y2)
		{
		}

		public float GetY(float x)
		{
			return 0f;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<float, float, float> _003C_003E9__53_0;

		public static Converter<Vector2, Vector3> _003C_003E9__56_0;

		public static Comparison<RankingSeasonReplayEvent> _003C_003E9__64_0;

		internal float _003CDrawAxis_003Eb__53_0(float x, float y)
		{
			return 0f;
		}

		internal Vector3 _003CDrawLine_003Eb__56_0(Vector2 vector2)
		{
			return default(Vector3);
		}

		internal int _003CDrawHighlight_003Eb__64_0(RankingSeasonReplayEvent a, RankingSeasonReplayEvent b)
		{
			return 0;
		}
	}

	private sealed class _003CAnimateChart_003Ed__63 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UISeasonReplayOverviewController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CAnimateChart_003Ed__63(int _003C_003E1__state)
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

	private sealed class _003CDelayedAction_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float time;

		public Action action;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayedAction_003Ed__48(int _003C_003E1__state)
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

	private uint m_SeasonID;

	private bool m_IsBR;

	private float m_AnimationTimer;

	private UISeasonReplayOverviewView m_View;

	private UIModelSeasonReplay m_ModelReplay;

	private List<Vector2> m_Points;

	private List<RankingSeasonRankRecord> m_RankData;

	private List<RankingSeasonReplayEvent> m_HighlightList;

	private Linear m_MinXLinear;

	private Linear m_MaxXLinear;

	private const float AnimationTime = 2f;

	private const int HighlightButtonGap = 40;

	private const int HighlightButtonEdgeGap = 20;

	private const int YAxisMaxRankNum = 6;

	public const int MaxHighlightNum = 4;

	private float m_InAnimTime;

	private uint m_Ticket_SEASONREPLAYOVERVIEWTITLE_VFX;

	private const string InAnimClip = "UIFX_UISeasonReplayOverview_In2";

	private const string OutAnimClip = "UIFX_UISeasonReplayOverview_Out";

	private const string ExpandSeasonalHighlightAnim = "UIFX_UISeasonReplayOverview_Open";

	private const string CollapseSeasonalHighlightAnim = "UIFX_UISeasonReplayOverview_Close";

	private Dictionary<int, Linear> m_DicLinear;

	private List<RankingSeasonReplayEventCluster> m_HighlightClusterList;

	private List<UISeasonReplayOverviewHighlightButtonController> m_HighlightBtnCtrls;

	private List<UISeasonReplayOverviewHighlightController> m_HighlightCtrls;

	private Dictionary<int, Linear> DicLinear => null;

	private List<RankingSeasonReplayEventCluster> HighlightClusterList => null;

	private List<UISeasonReplayOverviewHighlightButtonController> HighlightBtnCtrls => null;

	private List<UISeasonReplayOverviewHighlightController> HighlightCtrls => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnAsyncLoadResFinished(uint ticket, bool success, UnityEngine.Object obj)
	{
	}

	public void Init(bool isBR)
	{
	}

	public void Selected(bool isFirstEnter)
	{
	}

	public void UnSelected()
	{
	}

	public void HideView()
	{
	}

	public void HidePreview()
	{
	}

	public void RecoverPreview()
	{
	}

	public CombineScreenshotData BeforeCombineShare()
	{
		return default(CombineScreenshotData);
	}

	public void AfterCombineShare()
	{
	}

	public void PrepareControllerBeforeScreenshot()
	{
	}

	private IEnumerator DelayedAction(float time, Action action)
	{
		return null;
	}

	private void SetUIView()
	{
	}

	private void RefreshHasReachedGrandMaster()
	{
	}

	private void RefreshExpandButton()
	{
	}

	private void Draw()
	{
	}

	private void DrawAxis()
	{
	}

	private void DrawXAxis()
	{
	}

	private void DrawYAxis(List<uint> sortedRankList)
	{
	}

	private void DrawLine()
	{
	}

	private void DrawShadow()
	{
	}

	private void OnInAnimationEnd()
	{
	}

	private void HideChart()
	{
	}

	private void ShowChart()
	{
	}

	private void ShowHighlight()
	{
	}

	private void CarouselHighlightButtonImmediately()
	{
	}

	private IEnumerator AnimateChart()
	{
		return null;
	}

	private void DrawHighlight()
	{
	}

	private void DisableExpandButton()
	{
	}

	private void EnableExpandButton()
	{
	}

	private void ExpandSeasonalHighlight()
	{
	}

	private void CollapseSeasonalHighlight()
	{
	}

	private void ShowSeasonalHighlightDetail()
	{
	}

	private void ShowOriginalHighlightButton()
	{
	}

	private void ShowSimplifiedHighlightButton()
	{
	}

	private void ShowSeasonalHighlightGuide()
	{
	}

	private void _003CSelected_003Eb__40_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
