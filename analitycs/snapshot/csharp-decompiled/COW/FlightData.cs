using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class FlightData : CSVBaseData, IGetId
{
	public enum EFlightParentTransform
	{
		EFlightParentTransform_Bip,
		EFlightParentTransform_Toe,
		EFlightParentTransform_Root,
		EFlightParentTransform_FilghtSelf
	}

	public enum EFlightType
	{
		Flight,
		MultiFlight,
		FlightMove
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<int> _003C_003E9__53_0;

		internal int _003CGetFlightPrivilegeType_003Eb__53_0(int x, int y)
		{
			return 0;
		}
	}

	public uint iID;

	public uint sortId;

	public uint flightType;

	public string name;

	public ResourceID previewRes;

	public ResourceID flyMoveAnimIdMale;

	public ResourceID flyMoveAnimIdFemale;

	public ResourceID inGameRes;

	public ResourceID FemaleInGameRes;

	public ResourceID inGameRes3P;

	public ResourceID FemaleInGameRes3P;

	public ResourceID FrameResId;

	public ResourceID OpenParaSoundID;

	public ResourceID DivingOnceSoundIDOn;

	public ResourceID DivingOnceSoundIDOff;

	public ResourceID AccOnceSoundIDOn;

	public ResourceID AccOnceSoundIDOff;

	public ResourceID EngineLoopSoundID;

	public ResourceID EngineLoopSoundIDWwise;

	public ResourceID AnimID;

	public ResourceID FemaleAnimID;

	public ResourceID EjectSoundID;

	public ResourceID EndSoundID;

	public ResourceID MusicID;

	public ResourceID FlightLevelSoundRes;

	public int HideModelPhyicsState;

	public ResourceID FlightOpeningAnimRes;

	public ResourceID OpeningCameraEndEffect;

	public float OpeningAnimDuration;

	public ResourceID LandAnimClip;

	public ResourceID LandAnimClipFemale;

	public float LandAnimDuration;

	public ResourceID EjectLoopSoundID;

	public ResourceID SkinUpgradeAnimRes;

	public ResourceID LandAnimEffectRes;

	public bool IsMultiStageFlight;

	public int OpeningCameraMountPos;

	public EFlightParentTransform ParentTransformID;

	public uint NewMatType;

	public uint FormationId;

	public string TipsBackgroundSpriteName;

	public ResourceID ParachuteStateParameter;

	public ESourceType sourceTypeKey;

	public bool EnableFlightShow;

	public uint GetId()
	{
		return 0u;
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public bool IsMultiSeatFlight()
	{
		return false;
	}

	public bool IsFlightMove()
	{
		return false;
	}

	public bool IsMultiSeatFlightMove()
	{
		return false;
	}

	public bool HasOpenAnim()
	{
		return false;
	}

	public List<int> GetFlightPrivilegeType()
	{
		return null;
	}

	public ResourceID GetResId(bool isFemale, bool is3P)
	{
		return default(ResourceID);
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
