using System.Collections.Generic;
using UnityEngine;
using message;

namespace COW;

public class BRMatchReviewMapObjectRenderer
{
	private class IconEntry
	{
		public GameObject Go;

		public EBRMatchReviewLegendType LegendType;

		public long FirstTeamInteractedMs;
	}

	private Transform m_MapPanel;

	private Transform m_Container;

	private GameObject m_IconPrefab;

	private UIMapUtil.MapOffsetContext m_MapOffsetContext;

	private bool m_Initialized;

	private readonly List<IconEntry> m_AllIcons;

	private readonly Dictionary<EBRMatchReviewLegendType, bool> m_LegendOnState;

	private long m_LastUpdateMs;

	private Vector3 m_IconScale;

	private float m_BaseScale;

	public void Init(Transform mapPanel, UIMapUtil.MapOffsetContext mapOffsetContext, GameObject iconPrefab)
	{
	}

	public void SetData(List<IHEPBAGKINP> allMapObjects, HashSet<uint> myTeamPlayerIds)
	{
	}

	public void UpdateToTime(float currentTimeMs)
	{
	}

	public void SetIconScale(Vector3 scale)
	{
	}

	public void SetBaseScale(float baseScale)
	{
	}

	private void ApplyScaleToAllIcons()
	{
	}

	private Vector3 GetFinalIconScale()
	{
		return default(Vector3);
	}

	public void SetTypeVisible(EBRMatchReviewLegendType type, bool legendOn)
	{
	}

	public void Reset()
	{
	}

	private void DestroyContainer()
	{
	}

	public void ClearAll()
	{
	}

	private static long ComputeFirstTeamInteractionMs(List<NJEKJEGJKCC> interactions, HashSet<uint> myTeamPlayerIds)
	{
		return 0L;
	}

	private GameObject InstantiateIcon(IHEPBAGKINP mapObj, EBRMatchReviewLegendType legendType)
	{
		return null;
	}

	private static EBRMatchReviewLegendType MapObjectTypeToLegendType(OCGKABKDAKP objType)
	{
		return EBRMatchReviewLegendType.EnemyPosition;
	}

	private static string GetIconSpriteName(EBRMatchReviewLegendType type)
	{
		return null;
	}

	private Vector2 WorldIntToLocalPos(int worldIntX, int worldIntZ)
	{
		return default(Vector2);
	}
}
