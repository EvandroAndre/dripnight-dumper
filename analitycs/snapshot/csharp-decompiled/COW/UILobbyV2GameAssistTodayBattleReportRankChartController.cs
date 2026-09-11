using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyV2GameAssistTodayBattleReportRankChartController : UIBaseController
{
	public class RankChartRecord
	{
		private int _003CBRScore_003Ek__BackingField;

		private int _003CChange_003Ek__BackingField;

		private int _003CCSRankPoint_003Ek__BackingField;

		private int _003CCSRank_003Ek__BackingField;

		private int _003CCSRankStar_003Ek__BackingField;

		private bool _003CHasCSRankData_003Ek__BackingField;

		private string _003CTimeText_003Ek__BackingField;

		private bool _003CHasHighlight_003Ek__BackingField;

		private EHighLightPlayType _003CHighlightType_003Ek__BackingField;

		public int BRScore
		{
			get
			{
				return _003CBRScore_003Ek__BackingField;
			}
			private set
			{
				_003CBRScore_003Ek__BackingField = value;
			}
		}

		public int Change
		{
			get
			{
				return _003CChange_003Ek__BackingField;
			}
			private set
			{
				_003CChange_003Ek__BackingField = value;
			}
		}

		public int CSRankPoint
		{
			get
			{
				return _003CCSRankPoint_003Ek__BackingField;
			}
			private set
			{
				_003CCSRankPoint_003Ek__BackingField = value;
			}
		}

		public int CSRank
		{
			get
			{
				return _003CCSRank_003Ek__BackingField;
			}
			private set
			{
				_003CCSRank_003Ek__BackingField = value;
			}
		}

		public int CSRankStar
		{
			get
			{
				return _003CCSRankStar_003Ek__BackingField;
			}
			private set
			{
				_003CCSRankStar_003Ek__BackingField = value;
			}
		}

		public bool HasCSRankData
		{
			get
			{
				return _003CHasCSRankData_003Ek__BackingField;
			}
			private set
			{
				_003CHasCSRankData_003Ek__BackingField = value;
			}
		}

		public string TimeText
		{
			get
			{
				return _003CTimeText_003Ek__BackingField;
			}
			private set
			{
				_003CTimeText_003Ek__BackingField = value;
			}
		}

		public bool HasHighlight
		{
			get
			{
				return _003CHasHighlight_003Ek__BackingField;
			}
			private set
			{
				_003CHasHighlight_003Ek__BackingField = value;
			}
		}

		public EHighLightPlayType HighlightType
		{
			get
			{
				return _003CHighlightType_003Ek__BackingField;
			}
			private set
			{
				_003CHighlightType_003Ek__BackingField = value;
			}
		}

		private RankChartRecord(int brScore, int change, int csRankPoint, int csRank, int csRankStar, string timeText, EHighLightPlayType highlightType)
		{
		}

		public static RankChartRecord CreateBR(int brScore, int change, string timeText, EHighLightPlayType highlightType = EHighLightPlayType.None)
		{
			return null;
		}

		public static RankChartRecord CreateCS(int csRankPoint, int csRank, int csRankStar, int change, string timeText, EHighLightPlayType highlightType = EHighLightPlayType.None)
		{
			return null;
		}
	}

	private class Linear
	{
		private float m_K;

		private float m_B;

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

		public static Converter<Vector2, Vector3> _003C_003E9__48_0;

		internal Vector3 _003CRefreshLine_003Eb__48_0(Vector2 vector2)
		{
			return default(Vector3);
		}
	}

	private UILobbyV2GameAssistTodayBattleReportRankChartView m_View;

	private readonly List<RankChartRecord> m_RankData;

	private readonly List<Vector2> m_BasePoints;

	private readonly List<Vector2> m_Points;

	private readonly List<GameObject> m_DynamicNodes;

	private readonly List<UILabel> m_TimeLabels;

	private readonly List<UILobbyV2GameAssistTodayBattleReportRankChartAxisItemController> m_AxisItemCtrls;

	private readonly List<UILobbyV2GameAssistTodayBattleReportRankChartPointItemController> m_PointItemCtrls;

	private readonly List<UIWidget> m_GridLineWidgets;

	private Mesh m_ShadowMesh;

	private bool m_IsBR;

	private float m_ContentWidth;

	private float m_AxisMinChartValue;

	private float m_AxisMaxChartValue;

	private float m_AxisBaseChartValue;

	private float m_AxisStepChartValue;

	private UIModelLadderMatch m_ModelLadderMatch;

	private UIModelCSLadderMatch m_ModelCSLadderMatch;

	private int m_MinAxisStepScore;

	private int m_MinCSAxisStepScore;

	private const int YAxisMaxNum = 4;

	private const int MaxPointCount = 20;

	private const int DefaultVisiblePointCount = 9;

	private const int DefaultMinAxisStepScore = 50;

	private const int DefaultMinCSAxisStepScore = 1;

	private const int MaxCSAxisStarValue = 999;

	private const int BRRankMinAxisScore = 1000;

	private const float LineWidth = 0.005f;

	private static readonly Color ChartBgColor;

	private static readonly Color LineColor;

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

	public void SetMode(bool isBR)
	{
	}

	public void SetViewData(List<RankChartRecord> dataList, bool isBR, uint brMinCalibration, uint csMinCalibration)
	{
	}

	private int GetMinAxisStepScore(uint calibration, int defaultValue)
	{
		return 0;
	}

	private void Draw()
	{
	}

	private void PrepareTemplates()
	{
	}

	private void SetupChartVisualStyle()
	{
	}

	private void InitGridLines()
	{
	}

	private void DrawAxis()
	{
	}

	private void RefreshAxisRange(int minChartValue, int maxChartValue)
	{
	}

	private void DrawYAxis(float topY, float stepY)
	{
	}

	private void RefreshGridLines(float topY, float stepY)
	{
	}

	private string FormatAxisValue(int axisChartValue)
	{
		return null;
	}

	private void DrawLine()
	{
	}

	private void RefreshLine()
	{
	}

	private void DrawShadow()
	{
	}

	private void RefreshShadow()
	{
	}

	private void DrawChartPointItems()
	{
	}

	private bool ShouldShowPointRankIcon(int index)
	{
		return false;
	}

	private int GetChartValue(RankChartRecord rankData)
	{
		return 0;
	}

	private int GetRankIconChartValue(RankChartRecord rankData)
	{
		return 0;
	}

	private int GetCSRank(RankChartRecord rankData)
	{
		return 0;
	}

	private int GetCSRankByRankPoint(int csRankPoint)
	{
		return 0;
	}

	private int GetCSAxisMaxChartValue(int csRankPoint, int csRank = 0)
	{
		return 0;
	}

	private int GetCSAxisStarValue(int csRankPoint, int csRank)
	{
		return 0;
	}

	private int GetCSAxisChartValueByStarValue(int csRankStar, int csRank)
	{
		return 0;
	}

	private int GetCSAxisChartValueBase(int csRank)
	{
		return 0;
	}

	private EHighLightPlayType GetPointHighlightType(int index)
	{
		return EHighLightPlayType.None;
	}

	private void DrawXAxis()
	{
	}

	private void RefreshDisplayedPoints()
	{
	}

	private void RefreshChartContent()
	{
	}

	private void RefreshScrollView()
	{
	}

	private bool CanScrollToTail()
	{
		return false;
	}

	public float GetLeftAlignOffset(Transform chartLeftAnchor)
	{
		return 0f;
	}

	private ResourceID GetAxisRankIconRes(int value)
	{
		return default(ResourceID);
	}

	private void ClearDynamicNodes()
	{
	}

	private void ClearChartVisualState()
	{
	}

	private void ClearItemControllers<T>(List<T> controllers) where T : UIBaseController
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
