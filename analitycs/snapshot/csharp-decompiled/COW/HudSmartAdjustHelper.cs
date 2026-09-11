using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class HudSmartAdjustHelper
{
	public delegate CustomHudItem FindHudItemDelegate(string hudName);

	public delegate void ApplyHudPositionDelegate(string hudName, float localX, float localY);

	public delegate Vector2 GetSavedHudLocalPositionDelegate(string hudName);

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<GlobalClickRecorder.ClickRecord, Vector2> _003C_003E9__45_0;

		internal Vector2 _003CSmartAdjustCoroutine_003Eb__45_0(GlobalClickRecorder.ClickRecord r)
		{
			return default(Vector2);
		}
	}

	private sealed class _003CShowDotsOnlyCoroutine_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HudSmartAdjustHelper _003C_003E4__this;

		public uint level;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowDotsOnlyCoroutine_003Ed__43(int _003C_003E1__state)
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

	private sealed class _003CSmartAdjustCoroutine_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public uint level;

		public HudSmartAdjustHelper _003C_003E4__this;

		private HeatmapType _003CtargetHeatmapType_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSmartAdjustCoroutine_003Ed__45(int _003C_003E1__state)
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

	private const string LOG_TAG = "[HudSmartAdjust]";

	private const int MAX_MEMORY_LEVEL = 2;

	private MonoBehaviour m_Host;

	private FindHudItemDelegate m_FindHudItem;

	private ApplyHudPositionDelegate m_OnPositionApplied;

	private GetSavedHudLocalPositionDelegate m_GetSavedLocalPosition;

	private int m_PresetIndex;

	private KMeansClustering.ClusterResult m_ClusterResult;

	private bool m_ShowClusters;

	private bool m_ShowFittedCenters;

	private int m_ClusterCount;

	private List<GlobalClickRecorder.ClickRecord> m_FilteredRecords;

	private List<GlobalClickRecorder.ClickRecord> m_DisplayRecords;

	private List<HudClickCollectionInfo> m_HudCollectionInfos;

	private List<float> m_CentroidRadii;

	private bool m_EnableNoiseFiltering;

	private HeatmapType m_CurrentHeatmapType;

	private Material m_GLMaterial;

	private bool m_ShowClickDots;

	private bool m_DotsHiddenByPopup;

	private Coroutine m_SmartAdjustCoroutine;

	private const int DOT_SEGMENTS = 12;

	private const float DOT_RADIUS_BASE = 3f;

	private const string DOT_COLOR_HEX = "#00FFEA";

	private Color m_DotColor;

	private bool m_DotColorParsed;

	private const string CONSUMED_TIMESTAMP_KEY_PREFIX = "SmartAdjust_LastFileTime_P";

	private bool m_HasAppliedAdjustment;

	public bool HasClusterResult => false;

	public bool HasAppliedAdjustment => false;

	public HudSmartAdjustHelper(MonoBehaviour host, FindHudItemDelegate findHudItem, ApplyHudPositionDelegate onPositionApplied, int presetIndex, GetSavedHudLocalPositionDelegate getSavedLocalPosition = null)
	{
	}

	private void StopSmartAdjustCoroutine()
	{
	}

	public void SetPresetIndex(int presetIndex)
	{
	}

	private string GetConsumedTimestampKey()
	{
		return null;
	}

	public bool HasNewDataSinceLastAdjust()
	{
		return false;
	}

	public void MarkDataAsConsumed()
	{
	}

	public void HudSmartAdjust()
	{
	}

	public void ShowDotsOnly()
	{
	}

	private IEnumerator ShowDotsOnlyCoroutine(uint level)
	{
		return null;
	}

	public bool CheckMatchCountValid()
	{
		return false;
	}

	private IEnumerator SmartAdjustCoroutine(uint level)
	{
		return null;
	}

	public void ClearVisualization()
	{
	}

	public void ApplyClusterResultsToHudPositions()
	{
	}

	public void Dispose()
	{
	}

	private void SetupHudCollectionInfoList(string[] hudNames, float noiseMultiplier)
	{
	}

	private void LoadHudInfoFromCache(HudClickCollectionInfo info)
	{
	}

	private List<GlobalClickRecorder.ClickRecord> FilterNoisePoints(List<GlobalClickRecorder.ClickRecord> records)
	{
		return null;
	}

	private List<GlobalClickRecorder.ClickRecord> DownsampleRecords(List<GlobalClickRecorder.ClickRecord> records, int maxCount)
	{
		return null;
	}

	private void PerformKMeansClustering(List<Vector2> points)
	{
	}

	private void PerformCentroidAnalysis(List<GlobalClickRecorder.ClickRecord> filteredRecords, uint level)
	{
	}

	private void EnsureGLMaterial()
	{
	}

	private void OnPostRenderDots(Camera cam)
	{
	}

	public void SetDotsHiddenByPopup(bool hidden)
	{
	}

	private void ShowClickDots()
	{
	}

	private void HideClickDots()
	{
	}
}
