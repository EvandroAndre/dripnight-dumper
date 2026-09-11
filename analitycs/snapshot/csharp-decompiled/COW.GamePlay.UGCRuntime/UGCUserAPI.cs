using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using COW.Gameplay.UGC;
using UnityEngine;

namespace COW.GamePlay.UGCRuntime;

public static class UGCUserAPI
{
	private enum PlayerBehaviorType
	{
		PlayerBehaviorType_Movement = 1,
		PlayerBehaviorType_Sprint,
		PlayerBehaviorType_Attack,
		PlayerBehaviorType_Jump,
		PlayerBehaviorType_Climb,
		PlayerBehaviorType_GetOnAsDriver,
		PlayerBehaviorType_GetOnAsPassenger,
		PlayerBehaviorType_GetOffVehicle,
		PlayerBehaviorType_Driving
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<object, string> _003C_003E9__86_0;

		public static Converter<object, string> _003C_003E9__295_0;

		public static Converter<object, string> _003C_003E9__324_0;

		internal string _003CUGCAPICustomUserEventLog_003Eb__86_0(object obj)
		{
			return null;
		}

		internal string _003CUGCAPISetPersonaObserver_003Eb__295_0(object personaID)
		{
			return null;
		}

		internal string _003CUGCAPIStringJoin_003Eb__324_0(object obj)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass109_0
	{
		public int argIndex;

		internal string _003CConvertGoFormatToCSharp_003Eb__0(Match match)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public string[] cKeys;

		public int i;

		public object[] values;

		internal void _003CUGCAPIAddUserEventLogMapForClient_003Eb__0(object key, object value)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass255_0
	{
		public IUGCDatabaseModule databaseModule;

		public UGCDatabaseOperationRequest req;

		public StackContext stackContext;

		public string errorCode;

		public string result;

		internal bool _003CUGCAPIReadLocalDBSheetColumnValue_003Eb__0()
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass256_0
	{
		public IUGCDatabaseModule databaseModule;

		public UGCDatabaseOperationRequest req;

		public StackContext stackContext;

		public string errorCode;

		public string result;

		internal bool _003CUGCAPIReadLocalDBSheetValue_003Eb__0()
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass292_0
	{
		public MaterialPropertyBlock propertyBlock;

		public string propertyName;

		internal void _003CSetMaterialPropertyValue_003Eb__0(bool succ, bool isReloaded, Texture2D tex)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass40_0
	{
		public StackContext stackContext;

		public string state;

		public string progress;

		public string errorCode;

		public bool finished;

		internal void _003CUGCAPICheckMapResourceDownloaded_003Eb__0(int stateValue, int progressValue, int statusCodeValue)
		{
		}

		internal bool _003CUGCAPICheckMapResourceDownloaded_003Eb__1()
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass44_0
	{
		public bool hasDone;

		public StackContext stackContext;

		public string errorCode;

		internal void _003CUGCAPIClearMemory_003Eb__0(LLMResponse resp)
		{
		}

		internal bool _003CUGCAPIClearMemory_003Eb__1()
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public string[] cKeys;

		public int i;

		public object[] values;

		internal void _003CUGCAPIAddGameEventLogMapForClient_003Eb__0(object key, object value)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass66_0
	{
		public Vector3 spawnPostion;

		internal bool _003CUGCAPICreateLevelObject_003Eb__0(int id, string ugcEntityID, long ugcComponentTypeID, UGCEntityDataStore ds)
		{
			return false;
		}
	}

	public const int C_SOUNDENTITY_PAUSE = 1;

	public const int C_SOUNDENTITY_REPLAY = 2;

	public const int C_SOUNDENTITY_UNPAUSE = 3;

	private static System.Random rnd;

	public static EUGCFuncState UGCAPIAbs(object value, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIAcos(float degree, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIAddComponent(UGCLogicEntity target, long typeID, string isSuc, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIAddForce(object physicalObject, Vector3 force, int forceMode, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIAddForceAtPosition(UGCLogicEntity rigidbodyObject, Vector3 force, Vector3 position, int forceMode, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIAddGameEventLogMapForClient(SimpleMap dictionary, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIAddItem(int itemID, int count, string entityList, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIAddOrRemoveCustomCameraCullingMask(UGCLogicEntity basicCamera, int visibilityLayer, bool isInCullingMask, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIAddScript(UGCLogicEntity entity, string scriptID, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIAddTag(UGCLogicEntity targetEntity, string customTag, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIAddTorque(UGCLogicEntity rigidbodyObject, Vector3 torque, int forceMode, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIAddUserEventLogMapForClient(SimpleMap dictionary, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIAllLevelObjs(long targetLevelObjectTypeID, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIAllPlayers(StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIAllTeams(StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIAsin(float degree, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIAssert(bool assert, string tips, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIAtan(float degree, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIAtan2(float y, float x, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIAxisAngleToQuaternion(Vector3 axis, float angle, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIBitwiseCommon(int left, int right, int operation, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIBitwiseIntToList(int value, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIBitwiseListToInt(List<object> bitArray, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIBitwiseNot(int value, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIBoxCast(Vector3 halfExtents, Vector3 position, Vector3 rotation, Vector3 direction, float maxDistance, List<object> layerMaskList, bool includeTrigger, string hitEntitysName, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIBoxOverlap(Vector3 halfExtents, Vector3 position, Vector3 rotation, List<object> layerMaskList, bool includeTrigger, string hitEntitysName, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIBroadcastCustomEvent(long eventID, int targetSide, List<object> eventParams, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static bool Dispatch2Server(UGCRuntime ugcRuntime, string entityID, long eventType, object[] args)
	{
		return false;
	}

	public static EUGCFuncState UGCAPIBuyPremiumCommodity_Client(string itemCode, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIBuyPremiumCommodity_ClientV2(string itemCode, int count, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICameraMultiRaycast(Vector2 startPosition, float distance, List<object> layerMask, bool includeTrigger, string hitEntities, string hitPoints, string hitDistances, string hitNormals, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICameraSingleRaycast(Vector2 startPosition, float distance, List<object> layerMask, bool includeTrigger, string hitEntity, string hitPosition, string hitDistance, string hitNormal, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICameraTouchRay(Vector2 position, string worldPosition, string rayDirection, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICapsuleCast(float radius, float height, Vector3 position, Vector3 rotation, Vector3 direction, float maxDistance, List<object> layerMaskList, bool includeTrigger, string hitEntitysName, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICapsuleOverlap(float radius, float height, Vector3 position, Vector3 rotation, List<object> layerMaskList, bool includeTrigger, string hitEntitysName, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICaptureScreenshot(string fileName, string statusCodeVarName, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICCTMoveV2(UGCLogicEntity entity, Vector3 movement, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICCTTeleport(UGCLogicEntity entity, Vector3 targetPosition, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICeil(float value, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIChangeAvatarPart(UGCLogicEntity avatarAbleEntity, string partName, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICheckMapResourceDownloaded(string mapCode, string state, string progress, string errorCode, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIClamp(object value, object min, object max, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIClearAllChildren(UGCLogicEntity parent, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIClearMaterialProperty(UGCLogicEntity target, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIClearMemory(string errorCode, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICloneEntity(string entityVarName, UGCLogicEntity entityToClone, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static bool IsCloneableAndSupportTRS(UGCLogicEntity entityToClone)
	{
		return false;
	}

	private static UGCLogicEntity _UGCAPICloneEntityInternal(List<UGCEntityRepDataItem> refRedirectionRepItems, List<UGCLogicEntity> manualAwakeEntities, Dictionary<string, string> prefab2instanceMapping, UGCLogicEntity entityToClone, StackContext stackContext)
	{
		return null;
	}

	private static void _FixEntityRefRedirection(List<UGCEntityRepDataItem> refRedirectionRepItems, Dictionary<string, string> prefab2instanceMapping, UGCRuntime ugcRuntime)
	{
	}

	private static void _ManualAwake(List<UGCLogicEntity> instances)
	{
	}

	public static EUGCFuncState UGCAPIColorGet(int r, int g, int b, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIColorGetChannel(int value, string colorR, string colorG, string colorB, string colorA, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICos(float degree, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICreateAlongPathMotion(UGCLogicEntity targetEntity, UGCLogicEntity path, int style, float speed, bool tangentFacing, string entityVarName, bool autoPlay, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICreateBasicCamera(string entityVarName, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static bool CheckLocalPlayer(UGCLogicEntity ownerPlayer)
	{
		return false;
	}

	public static EUGCFuncState UGCAPICreateCustomHudClient(string entityVarName, int hudID, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICreateCustomHudClientV2(string entityVarName, string hudAssetID, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICreateCustomHudWidget(string entityVarName, int widgetType, UGCLogicEntity hudEntity, UGCLogicEntity parentWidget, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICreateEffectEntityClient(string entityVarName, string effectType, int loopType, bool autoPlay, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICreateEffectEntityNew(string entityVarName, UGCLogicEntity ownerPlayer, string effectType, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICreateEffectEntityV2(string entityVarName, UGCLogicEntity ownerPlayer, string effectType, int loopType, bool autoPlay, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICreateEntity(string createdEntity, long typeID, UGCLogicEntity owner, int attribute, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICreateEntityFromPrefab(string entityVarName, string targetPrefabID, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICreateInternalHudClient(string entityVarName, long hudType, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	private static UGCLogicEntity CreateInternalHudEntity(UGCRuntime runtime, long hudType)
	{
		return null;
	}

	public static EUGCFuncState UGCAPICreateLevelObject(string entityVarName, Vector3 spawnPostion, int itemID, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICreateLineRenderEntity(string entityVarName, List<object> points, string material, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICreateMapBitEntity(string entityVarName, UGCLogicEntity ownerPlayer, UGCLogicEntity targetEntity, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICreateMapIconEntity(string entityVarName, UGCLogicEntity ownerPlayer, string iconType, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICreatePlayableLookAt(UGCLogicEntity hostEntity, UGCLogicEntity targetEntity, Vector3 offset, int coordinateType, string entityVarName, bool autoPlay, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICreatePlayablePosFollow(UGCLogicEntity hostEntity, UGCLogicEntity targetEntity, Vector3 offset, int coordinateType, string entityVarName, bool autoPlay, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICreatePlayableTrajectory(UGCLogicEntity targetEntity, Vector3 initialVelocity, Vector3 acceleration, float maxDisplacement, string entityVarName, bool autoPlay, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICreateProjectileTrajectory(string entityVarName, Vector3 startPosition, Vector3 initialVelocity, string material, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICreateRandomSeed(int seed, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICreateSelfRelative(UGCLogicEntity targetEntity, long propID, object delta, List<object> controlPoints, int style, float duration, string entityVarName, bool autoPlay, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICreateSelfRelativeFrame(UGCLogicEntity targetEntity, long propID, object delta, bool isSwitch, string entityVarName, bool autoPlay, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICreateSkeletonPartLookAtController(string entityVarName, UGCLogicEntity controlBone, UGCLogicEntity lookAt, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICreateSoundEntityClient(string entityVarName, string soundType, int loopType, bool autoPlay, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICreateSoundEntityV2(string entityVarName, UGCLogicEntity ownerPlayer, string soundType, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICreateTimeLine(string resID, bool autoPlay, string entityVarName, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICreateTimestampLocString(int timestamp, int style, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICreateTrainingBot(string entityVarName, Vector3 position, int moveMode, Vector3 dir, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICreateTweenV2(UGCLogicEntity targetEntity, long propID, object srcVal, object destVal, int style, List<object> controlPoints, float duration, string entityVarName, bool autoPlay, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICreateUGCDamageNum(string value, int fontSize, int fontColor, int timeOfStay, UGCLogicEntity target, Vector3 offset, Vector2 randomRange, bool doTween, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICurveEvaluate(List<object> curve, float time, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPICustomUserEventLog(UGCLogicEntity player, List<object> keys, List<object> values, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIDeleteLocalDBSheetValue(string sheetName, string accountId, string key, string workshopCode, string errorCode, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIDestroyItem(int itemID, int count, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIDisableAvatarPart(UGCLogicEntity avatarAbleEntity, string partName, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIDispatchCustomEvent(long eventID, UGCLogicEntity targetEntity, List<object> eventParams, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIDispatchCustomEventV2(long eventID, UGCLogicEntity targetEntity, bool crossPlatform, List<object> eventParams, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIDispatchCustomEventV3(long eventID, UGCLogicEntity target, int targetSide, List<object> eventParams, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIDispatchCustomEventV4(long eventID, UGCLogicEntity target, int targetSide, List<object> eventParams, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIDownloadMapResource(string mapCode, string errorCode, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIEnableAvatarPart(UGCLogicEntity avatarAbleEntity, string partName, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIEndCurrentPhase(StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIEnterVehicle(UGCLogicEntity vehicle, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIEularAngleToVector3(Vector3 value, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIEulerAngleToQuaternion(Vector3 value, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIExistScript(UGCLogicEntity entity, string scriptID, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIExitVehicle(StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIExponentiation(object leftValue, object rightValue, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIFeedbackToPersonaContent(string responseID, bool likeOrDislike, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIFilterEntities(object has, object not, object any, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	private static void AddTypeOrListType(List<long> result, object value)
	{
	}

	public static EUGCFuncState UGCAPIFindEntityByID(string entityID, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIFloor(float value, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIFormatStr(string content, List<object> paramArray, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	private static string ConvertGoFormatToCSharp(string goFormat)
	{
		return null;
	}

	public static EUGCFuncState UGCAPIGetAppearanceMaterial(UGCLogicEntity avatarAbleEntity, string group, string part, int slotOneBase, string outMaterial, string outSuccess, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetBlackBoard(UGCLogicEntity bTree, string bBKey, string bBValue, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetBoundingBox(UGCLogicEntity target, string center, string size, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetBTreeNodeParam(UGCLogicEntity node, string key, string value, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetChildByIndex(UGCLogicEntity parent, int index, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetChildByName(UGCLogicEntity parent, string entityName, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetChildren(UGCLogicEntity parent, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetClientRegion(StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetCurrentCamera(UGCLogicEntity player, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetCurrentNewCameraForClinet(StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetCustomCameraCullingMask(UGCLogicEntity basicCamera, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetCustomPlayerState(UGCLogicEntity customPlayerEntity, string isSuccessVarName, string stateVarName, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetDefaultUIPosition(int target, string enable, string position, string size, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetFriends(StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetGlobalEntity(StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetGlobalSleepThreshold(StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetGyroscopeGravity(StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetGyroscopeOrientation(StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetGyroscopeRotationRate(StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetGyroscopeRotationUnbiased(StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetLoadedScenes(StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetLocalAimDirection(StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetLocalLanguage(StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetLocalTimestamp(StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetLocalTimestampMs(StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetMicrophoneVolume(string volume, string status, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetMountPoint(UGCLogicEntity target, string name, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetParent(UGCLogicEntity child, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetPlayerMiniMap(UGCLogicEntity player, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetPremiumExpireDate_Client(string result, string status, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetRenderQuality(StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetRenderResolution(StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetReplicationData(UGCLogicEntity targetEntity, long propertyIndex, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetResultFromCurve(long propType, object srcValue, object destVal, List<object> curve, float time, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetScreenTouchCount(StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetSleepThreshold(UGCLogicEntity rigidbodyObject, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetTouchInfo(int index, string position, string delta, string duration, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetType(object variable, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetTypeName(object variable, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetUserAcceleration(StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetWidgetFromCustomHud(UGCLogicEntity ownerPlayer, UGCLogicEntity hudEntity, int widgetID, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIGetWidgetFromCustomHudByString(UGCLogicEntity ownerPlayer, UGCLogicEntity hudEntity, string widgetPathOrName, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIHasComponent(UGCLogicEntity target, long typeID, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIHasTag(UGCLogicEntity targetEntity, string customTag, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIInstantiatePrefab(string entityVarName, string targetPrefabID, bool async, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIIntToFloat(int value, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIIsEntityInsideBox(UGCLogicEntity entity, Vector3 centerPos, float length, float width, float height, Vector3 eulerAngles, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIIsEntityInsideCylinder(UGCLogicEntity entity, Vector3 centerPos, float radius, float height, Vector3 eulerAngles, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static Tuple2<Vector3, bool> UGCAPIGetEntityPosition(UGCLogicEntity entity)
	{
		return default(Tuple2<Vector3, bool>);
	}

	public static EUGCFuncState UGCAPIIsEntityInsideSector(UGCLogicEntity entity, Vector3 centerPos, float radius, float cutRadius, float height, float angle, Vector3 eulerAngles, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static Vector3 ProjectOnPlane(Vector3 vec, Vector3 planeNormal)
	{
		return default(Vector3);
	}

	public static EUGCFuncState UGCAPIIsEntityInsideSphere(UGCLogicEntity entity, Vector3 centerPos, float radius, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIIsFriend(UGCLogicEntity player, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIIsNil(object obj, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIIsPremium_Client(string status, string result, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIIsSleeping(UGCLogicEntity rigidbodyObject, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIIsSubClassOf(object variable, long compareType, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPILerp(float valueA, float valueB, float valueT, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPILerpVector3(Vector3 a, Vector3 b, float ratio, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIListAppend(List<object> listValue, object elementValue, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIListAppendRange(List<object> listValue, List<object> contentList, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIListClear(List<object> listValue, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIListClone(List<object> listValue, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIListContains(List<object> listValue, object elementValue, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIListFindMax(List<object> value, string result, string resultValue, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIListFindMin(List<object> value, string result, string resultValue, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIListGetElement(List<object> listValue, int index, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIListIndexOf(List<object> listValue, object elementValue, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIListInsert(List<object> listValue, int index, object elementValue, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIListIsEqual(List<object> leftValue, List<object> rightValue, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	private static bool CompareArray(List<object> leftArray, List<object> rightArray)
	{
		return false;
	}

	public static EUGCFuncState UGCAPIListLastIndexOf(List<object> listValue, object elementValue, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIListLength(List<object> listValue, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIListRemove(List<object> listValue, object elementValue, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIListRemoveAt(List<object> listValue, int index, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIListReverse(List<object> listValue, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIListSetElement(List<object> listValue, int index, object elementValue, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIListShuffle(List<object> listValue, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	private static void ListShuffle(List<object> list)
	{
	}

	public static EUGCFuncState UGCAPILocalObserver(StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPILocalPlayer(StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPILog(object baseValue, object realNumber, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPILogarithm(object value, object baseValue, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPILookRotation(Vector3 forward, Vector3 upward, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIMapClear(SimpleMap mapValue, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIMapContainKey(SimpleMap mapValue, object key, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIMapGetAllKeys(SimpleMap mapValue, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIMapGetLength(SimpleMap mapValue, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIMapGetValue(SimpleMap mapValue, object key, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIMapRemoveValue(SimpleMap mapValue, object key, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIMapSetValue(SimpleMap mapValue, object key, object value, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIMax(object value1, object value2, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIMin(object value1, object value2, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIMovePosition(UGCLogicEntity rigidbodyObject, Vector3 position, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIMoveRotation(UGCLogicEntity rigidbodyObject, Quaternion rotation, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIMultiplyQuaternion(Quaternion left, Quaternion right, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIMultiRaycast(Vector3 startPos, Vector3 direction, float distance, List<object> layerMaskList, bool includeTrigger, string hitEntityName, string hitPositionName, string hitDistanceName, string hitNormalName, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPINegate(object value, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPINewList(int length, int capacity, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPINewMap(StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPINewTweenCurveV2(List<object> controlPoints, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPINewVector(float x, float y, float z, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPINewVector2(float x, float y, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPINext(object value, int min, int max, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPINot(bool value, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPINotifyIconAnimation(string icon, int color, Vector2 scale, Vector2 startPosition, Vector2 startRange, Vector2 endPosition, Vector2 endRange, float speed, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPINotifyShowTips(UGCLogicEntity player, object text, int color, int duration, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPINumToString(object value, string format, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIOpenPremiumCenter_Client(string status, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIOpenPremiumStore_Client(StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIPasteComponent(UGCLogicEntity source, UGCLogicEntity target, long componentType, string isSuc, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIPauseGame(StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIPausePlayable(object playableEntities, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIPauseSoundEntityV2(object soundEntity, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIPlayAnimationByController(UGCLogicEntity animationControllerAble, string stateName, float playSpeed, int overrideLoopMode, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIPlayCharacterAnimationClip(UGCLogicEntity player, string clipID, bool isLooping, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIPlayCharacterAnimationClipOverride(UGCLogicEntity player, string clipID, bool isLooping, bool overrideGamePlayControl, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIPlayOneShotSound(string resource, float volume, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIPlayOneShotSoundV2(string resource, float speed, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIPlayPlayable(object playableEntities, bool reset, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIPlayStoredVoiceFromPersona(long chatID, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIPrintError(object context, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIPrintString(object context, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIPrintWarning(object context, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIQuaternionAngle(Quaternion left, Quaternion right, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIQuaternionDot(Quaternion left, Quaternion right, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIQuaternionFromToRotation(Vector3 from, Vector3 to, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIQuaternionInverse(Quaternion value, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIQuaternionRotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIQuaternionToAxisAngle(Quaternion value, string axis, string angle, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIQuaternionToEulerAngle(Quaternion value, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIQuitGameClient(bool needConfirm, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIRandomFloat(float minValue, float maxValue, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIRandomInt(int minValue, int maxValue, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIReadCSVDataAll(string uUIDCSV, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIReadCSVDataCell(string uUIDCSV, int row, int col, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIReadCSVDataCellByRowAndColName(string uUIDCSV, int row, string colName, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIReadCSVDataCol(string uUIDCSV, int col, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIReadCSVDataColIntByName(string uUIDCSV, string colName, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIReadCSVDataRow(string uUIDCSV, int row, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIReadCSVDataRowByKey(string uUIDCSV, int col, object targetValue, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIReadLocalDBSheetColumnValue(string sheetName, string accountId, string key, int columnIndex, string result, string workshopCode, string errorCode, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIReadLocalDBSheetValue(string sheetName, string accountId, string key, string result, string workshopCode, string errorCode, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIRemoveComponent(UGCLogicEntity target, long typeID, string isSuc, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIRemoveCustomHud(UGCLogicEntity hudEntity, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIRemoveEntity(UGCLogicEntity entity, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIRemoveInternalHud(UGCLogicEntity entity, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIRemoveScript(UGCLogicEntity entity, string scriptID, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIRemoveTag(UGCLogicEntity targetEntity, string customTag, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIResetAppearanceMaterial(UGCLogicEntity avatarAbleEntity, string group, string part, int slotOneBase, string outSuccess, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIResetAppearanceMaterialGroup(UGCLogicEntity avatarAbleEntity, string group, string outSuccess, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIResetPlayable(object playableEntities, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIResumeGame(StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIResumeSoundEntityV2(object soundEntity, bool isReplay, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIRevive(StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIRollbackPersonaMemory(string chatID, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIRotateVector(Vector3 value, Quaternion RotateVector, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIRound(float value, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIScreenToWorldPoint(Vector2 screenPosition, float depth, string worldPosition, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISetActive(UGCLogicEntity targetEntity, bool active, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISetAppearanceMaterial(UGCLogicEntity avatarAbleEntity, string group, string part, int slotOneBase, string materialResUUID, string outSuccess, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISetBlackBoard(UGCLogicEntity bTree, string bBKey, object bBValue, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISetBodyPartTrackWeight(UGCLogicEntity animationControllerAble, string trackName, float weight, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISetCCTForward(UGCLogicEntity entity, Vector3 forward, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISetCustomCameraCullingMask(UGCLogicEntity basicCamera, List<object> cullingMask, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISetCustomPlayerState(UGCLogicEntity customPlayerEntity, int state, string isSuccessVarName, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISetDistanceVolumes(List<object> distanceList, List<object> volumeList, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISetFollowEntity(UGCLogicEntity targetEntity, UGCLogicEntity followEntity, Vector3 offset, int coordinateType, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISetFSMNextPhase(int phaseIndex, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISetGlobalSleepThreshold(float threshold, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISetHudWidgetParent(object parent, UGCLogicEntity child, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISetInvincibility(int duration, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISetLevelObjHighLight(UGCLogicEntity targetEntity, bool status, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISetLevelObjOutlineEffect(UGCLogicEntity target, float width, int color, float alpha, bool status, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISetLocalPlayerForward(Vector3 forward, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISetLocalPlayerMoveStatus(bool status, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISetLocalPlayerPositon(Vector3 position, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISetMaterialProperty(UGCLogicEntity target, string propertyName, object propertyValue, string success, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	private static bool SetMaterialPropertyValue(MaterialPropertyBlock propertyBlock, string propertyName, object propertyValue)
	{
		return false;
	}

	public static EUGCFuncState UGCAPISetParentClient(object parent, UGCLogicEntity child, bool worldPositionStays, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static bool UGCAPISetParentInternal(UGCLogicEntity child, UGCLogicEntity parent, bool keepWorldPosition, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static EUGCFuncState UGCAPISetPersonaObserver(string target, List<object> observers, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	private static string UGCAPIGetLocalPlayerBehaviorEntityID(StackContext stackContext, out Player localPlayer)
	{
		localPlayer = null;
		return null;
	}

	public static EUGCFuncState UGCAPISetPlayerBehaviorStatus(UGCLogicEntity player, int playerBehaviorType, int playerBehaviorStatus, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISetPlayerCanFreeQuit(UGCLogicEntity playerEntity, bool canFreeQuit, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISetPlayerHubSwitch(UGCLogicEntity player, int playerHudSwitchType, int switchValue, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISetReplicationData(UGCLogicEntity targetEntity, long propertyIndex, IUGCValue propertyValue, int arithmeticType, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISetSleepThreshold(UGCLogicEntity rigidbodyObject, float threshold, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISetTimeLineTrackActor(UGCLogicEntity timeLineEntity, int trackId, UGCLogicEntity actorEntity, string errorCode, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISetWatchEntity(UGCLogicEntity targetEntity, UGCLogicEntity watchEntity, Vector3 offset, int coordinateType, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISin(float degree, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISingleCapsuleCast(float radius, float height, Vector3 position, Vector3 rotation, Vector3 direction, float maxDistance, List<object> layerMaskList, bool includeTrigger, string hitEntityName, string hitPositionName, string hitDistanceName, string hitNormalName, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISingleRaycast(Vector3 position, Vector3 forward, float distance, List<object> layerMaskList, bool includeTrigger, string hitEntityName, string hitPositionName, string hitDistanceName, string hitNormalName, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static bool UGCAPIConvertListToLayerMask(List<object> layerMaskList, out int layerMask)
	{
		layerMask = default(int);
		return false;
	}

	public static List<object> HitList2EntityList(Collider[] hitList, int hitCount, UGCRuntime runtime)
	{
		return null;
	}

	public static List<object> HitList2EntityList(RaycastHit[] hitList, int hitCount, UGCRuntime runtime)
	{
		return null;
	}

	public static EUGCFuncState UGCAPISleep(UGCLogicEntity rigidbodyObject, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISlerpQuaternion(Quaternion a, Quaternion b, float ratio, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISlerpVector3(Vector3 a, Vector3 b, float ratio, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISphereCast(float radius, Vector3 position, Vector3 direction, float maxDistance, List<object> layerMaskList, bool includeTrigger, string hitEntitysName, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISphereOverlap(float radius, Vector3 position, int layerMask, bool includeTrigger, string hitEntitysName, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISplitString(string srcValue, string sepStr, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	private static List<object> SplitByEmptyDelimiter(string input)
	{
		return null;
	}

	public static EUGCFuncState UGCAPISqrt(float value, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIStopAnimationByController(UGCLogicEntity animationControllerAble, string stateName, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIStrFind(string srcValue, string findValue, int startIndex, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIString2Float(string value, string floatValue, string ok, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIString2Int(string value, string intValue, string ok, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIStringFindAt(string srcValue, List<object> indexList, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIStringJoin(List<object> strElems, string sepStr, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIStringLower(string srcValue, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIStringStrip(string srcValue, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIStringUpper(string srcValue, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIStrLen(string str, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIStrReplace(string srcValue, string oldValue, string newValue, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIStrSub(string srcValue, int startIndex, int length, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISwitchNewCameraForClinet(UGCLogicEntity basicCamera, int cameraTransitionType, float transitionTime, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISwitchPresetCharacterType(UGCLogicEntity player, string dataID, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISwitchWeapon(int slot, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISystemMessageToPersona(string target, string content, bool shouldReply, string chatIDVarName, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISystemMessageToPersonaStream(string target, string content, bool shouldReply, string chatID, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPISystemMessageToPersonaVoice(string target, string content, bool autoPlay, string chatID, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPITakeDamage(UGCLogicEntity damageTaker, UGCLogicEntity damageMaker, int damageType, int damageValue, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPITan(float degree, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPITimestampMsToLocalString(long timestampMs, int style, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIToString(object targetValue, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPITypeIs(object variable, long compareType, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIUpdateContextToPersona(string target, string context, string requestIDVarName, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIUserMessageToPersona(string target, string content, string chatIDVarName, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIUserMessageToPersonaStream(string target, string content, string chatID, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIUserMessageToPersonaVoice(string target, string content, bool autoPlay, string chatID, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIVector2Add(Vector2 vector2Left, Vector2 vector2Right, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIVector2Angle(Vector2 vector2Left, Vector2 vector2Right, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIVector2Distance(Vector2 vector2Left, Vector2 vector2Right, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIVector2Dot(Vector2 vector2Left, Vector2 vector2Right, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIVector2GetX(Vector2 vector2, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIVector2GetY(Vector2 vector2, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIVector2Magnitude(Vector2 vector2, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIVector2Normalize(Vector2 vector2, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIVector2Reflect(Vector2 direction, Vector2 normal, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIVector2Scale(Vector2 vector2Left, float scale, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIVector2SetX(Vector2 vector, float x, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIVector2SetXClient(Vector2 vector, float x, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIVector2SetY(Vector2 vector, float y, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIVector2SetYClient(Vector2 vector, float y, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIVector2Sub(Vector2 vector2Left, Vector2 vector2Right, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIVector2ToVector3(Vector2 vector2, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIVector3Projection(Vector3 valueA, Vector3 valueB, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIVector3Reflect(Vector3 direction, Vector3 normal, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIVector3ToEulerAngles(Vector3 vector, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIVector3ToVector2(Vector3 vector3, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIVectorAdd(Vector3 vectorLeft, Vector3 vectorRight, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIVectorAngel(Vector3 vectorLeft, Vector3 vectorRight, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIVectorCross(Vector3 vectorLeft, Vector3 vectorRight, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIVectorDistance(Vector3 vectorLeft, Vector3 vectorRight, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIVectorDot(Vector3 vectorLeft, Vector3 vectorRight, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIVectorGetX(Vector3 vector, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIVectorGetY(Vector3 vector, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIVectorGetZ(Vector3 vector, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIVectorMul(Vector3 vectorLeft, float scale, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIVectorNormalize(Vector3 vector, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIVectorSetXClient(Vector3 vector, float x, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIVectorSetYClient(Vector3 vector, float y, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIVectorSetZClient(Vector3 vector, float z, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIVectorSize(Vector3 vector, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIVectorSub(Vector3 vectorLeft, Vector3 vectorRight, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIVibrateDevice(StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIWakeup(UGCLogicEntity rigidbodyObject, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIWorldToScreenPoint(Vector3 worldPosition, string inScreen, string inScreenPosition, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}

	public static EUGCFuncState UGCAPIWriteLocalDBSheetValue(string sheetName, string accountId, string key, object value, string workshopCode, string errorCode, StackContext stackContext)
	{
		return EUGCFuncState.Unknown;
	}
}
