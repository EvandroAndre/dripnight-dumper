using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class InGameHint3DManager : SingletonModule<InGameHint3DManager>
{
	public enum EHint3DType
	{
		None,
		NormalHitHint,
		PenetrateHitHint,
		FireHint,
		GrenadeHint,
		EnemyReviveHint,
		EnemyChargeHint
	}

	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public Vector3 pos1;

		public Vector3 pos2;

		public InGameHint3DManager _003C_003E4__this;

		internal void _003CPlayHitTraceIceWallPenetrated_003Eb__0(uint ticket, bool success, Object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public Vector3 pos1;

		public Vector3 pos2;

		public InGameHint3DManager _003C_003E4__this;

		internal void _003CPlayHitTrace_003Eb__0(uint ticket, bool success, Object obj)
		{
		}
	}

	private List<float> m_HintObjYOffset;

	private Vector3 m_HintObjScale;

	private Dictionary<uint, bool> m_Hint3DShow;

	private readonly Color HINT_COLOR1;

	private readonly Color HINT_COLOR2;

	private List<uint> m_HitTraceParams;

	public static int HitTraceCnt;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public void InitYOffset()
	{
	}

	public void InitScale()
	{
	}

	private void Init3DShow()
	{
	}

	public bool CheckShowHint3D()
	{
		return false;
	}

	public bool CheckShowHint3DByHint3DType(EHint3DType hint3DType)
	{
		return false;
	}

	private float GetYOffsetByHint3DType(float diff, EHint3DType hint3DType)
	{
		return 0f;
	}

	public ResourceID GetResIDByHint3DType(float diff, EHint3DType hint3DType)
	{
		return default(ResourceID);
	}

	private Vector3 GetScaleByHint3DType(EHint3DType hint3DType)
	{
		return default(Vector3);
	}

	public void InitHint3DByHint3DType(UIHud3DHint hud3DHint, float diff)
	{
	}

	private ResourceID GetVFXResourceIDByHint3DType(EHint3DType hint3DType)
	{
		return default(ResourceID);
	}

	private Vector3 GetVFXlocalScaleByHint3DType(EHint3DType hint3DType)
	{
		return default(Vector3);
	}

	public void SetHint3DRotation(UIHud3DHint hint, bool isPlayer = true)
	{
	}

	private void InitHitTraceParams()
	{
	}

	public void PlayHitTraceIceWallPenetrated(Vector3 fromPos)
	{
	}

	public void PlayHitTrace(BHGGAEEHJCO playerID)
	{
	}
}
