using UnityEngine;
using message;

namespace COW;

public class FSceneEditObjectData
{
	public uint Index;

	public uint ItemID;

	public uint Direction;

	public uint FreeDirection;

	public Vector3 RotatorEulerForRuntime;

	public Vector3 ScaleForRuntime;

	public Vector3 Position;

	public uint LevelObjectIDByTag;

	public string LogicEntityID;

	public string CustomizedName;

	public uint ResetPerRound;

	public bool IsEditorInvisible;

	public string Color;

	public int surColor;

	public int borColor;

	public string surTex;

	public string borTex;

	public int GroupID;

	public FSceneEditObjectTeleportDoorData doorData;

	public FSceneEditObjectBuffData buffData;

	public FSceneEditObjectMusicElementData musicData;

	public FSceneEditObjectMoveObjectData moveData;

	public FSceneEditObjectScaleData scaleData;

	public FSceneEditObjectTriggerData triggerData;

	public FSceneEditObjectItemBoxData itemboxData;

	public HOGBJEELAMK miniSentryData;

	public GGILFJBAFFI customPathData;

	public AKBBCCDFHJB botGenData;

	public FSceneEditObjectBigToyBallData ballData;

	public ANGPIGJLPIB vendingMachineData;

	public OOMGGMKKNBG ugcAIData;

	public MFFBCOHEIIF entityGeneratorData;

	public EPNCAGJLLJJ coinGeneratorData;

	public FLEANKHAGDO wardrobeData;

	public ENFJOJLEKCD footballData;

	public FGIIDHKECNK goalData;

	public AMPMJFDLIFH spawnBoxData;

	public BNGIPCGPDMG oildrumData;

	public DGEBCMHCNAP basicSphereData;

	public DOGEANLKJFG pointLightData;

	public FSceneEditShapeTriggerShapeData triggerShapeData;

	public static FSceneEditObjectData FromProtoData(float mapGridWidth, MBDFFJFGNCI protoData)
	{
		return null;
	}

	public static FSceneEditObjectData FromProtoData(LMPGHJKDOJH protoData)
	{
		return null;
	}
}
