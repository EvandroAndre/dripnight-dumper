using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class FinalShotData : CSVBaseData, IGetId
{
	public enum ELastKillEffectType
	{
		None,
		VFX,
		Animation
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<int> _003C_003E9__1_0;

		internal int _003CGetFinalShotFeatures_003Eb__1_0(int a, int b)
		{
			return 0;
		}
	}

	public Vector3 IngameTeamKillEffectPosOffset;

	public Vector3 IngameTeamKillEffectRotationVector3;

	public Vector3 IngameTeamKillEffectScale;

	public string HideModelTimeMale;

	public string HideModelTimeFemale;

	public ELastKillEffectType LastKillEffectType;

	public ResourceID PreviewLastKillEffect;

	public float LastKillTime;

	public float InGameLastKillEffectRecycleTime;

	public ResourceID IngameLastKillSound;

	public ResourceID BooyahSkinPreview;

	public ResourceID BooyahSkin;

	public uint WeaponID;

	public uint SkyBoxPrivilege;

	public ResourceID IngameLastKillAnimEffect;

	public ResourceID PreviewLastKillAnimEffectFemale;

	public ResourceID PreviewLastKillAnimEffect;

	public ResourceID LastKillAnimFemale;

	public ResourceID LastKillAnim;

	public ResourceID IngameLastKillEffectPerson;

	public ResourceID IngameLastKillEffect;

	public uint ID;

	public uint SortID;

	public ResourceID IngameLastKillAnimEffectFemale;

	public bool HideSafeZone;

	public bool IngameLastKillEffectLookAtKiller;

	public Quaternion IngameTeamKillEffectRotation;

	public bool IsInGameLastKillEffectPlayable(BHGGAEEHJCO killerID, bool isMatchLastKill, bool isTeamLastKill)
	{
		return false;
	}

	public List<int> GetFinalShotFeatures()
	{
		return null;
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
	}

	public override uint GetUIntKey()
	{
		return 0u;
	}

	public override int GetIntKey()
	{
		return 0;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public override void PostDeserializeData()
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public uint _003C_003EiFixBaseProxy_GetUIntKey()
	{
		return 0u;
	}

	public int _003C_003EiFixBaseProxy_GetIntKey()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}

	public void _003C_003EiFixBaseProxy_PostDeserializeData()
	{
	}
}
