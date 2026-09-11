using System;
using System.Collections.Generic;
using COW.GamePlay;
using COW.GamePlay.UGCRuntime;
using UnityEngine;
using message;

namespace COW.Gameplay.UGC;

public static class UGCTimelineEditorHelper
{
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public Action<bool, UGCTimelineEditorKeyBase> createdCall;

		public MHHOHPCLMFB trackType;

		public float Time;

		internal void _003CCreateKeyClipData_003Eb__0(SceneEditObjectBase sceneObj)
		{
		}

		internal void _003CCreateKeyClipData_003Eb__1(UIUGCNPCAnimStateClipSelectorController.CIIEIJOHNAG result)
		{
		}

		internal void _003CCreateKeyClipData_003Eb__3(SceneEditObjectBase sceneObj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass10_1
	{
		public Dictionary<string, MutableValue> coverMap;

		public int itemType;

		public int itemID;

		public int uiAvatarType;

		public _003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals1;

		internal void _003CCreateKeyClipData_003Eb__2(bool succ, UGCResAnimationClip resObj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public float Time;

		public Action<bool, UGCTimelineEditorKeyBase> createdCall;

		internal void _003CCreateAudioKeyClip_003Eb__0(string resourceName, int itemID)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass11_1
	{
		public string resourceName;

		public int itemID;

		public _003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals1;

		public Predicate<FCAJEKECGME> _003C_003E9__2;

		internal void _003CCreateAudioKeyClip_003Eb__1(uint tid, bool ret, UnityEngine.Object ffRes)
		{
		}

		internal bool _003CCreateAudioKeyClip_003Eb__2(FCAJEKECGME x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public int itemID;

		internal bool _003CGetAnimationClipName_003Eb__0(UIModelUGCResourceSelect.AvatarEditorItemData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public int itemID;

		internal bool _003CGetAvatarEditorItemData_003Eb__0(UIModelUGCResourceSelect.AvatarEditorItemData x)
		{
			return false;
		}
	}

	private static UGCTimelineEditorContext m_TimelineEditorContext;

	public static UGCTimelineEditorTrack CreateTrack(MHHOHPCLMFB trackType)
	{
		return null;
	}

	public static UGCTimelineEditorTrackBaseWarp CreateTrackWarp(MHHOHPCLMFB TrackType)
	{
		return null;
	}

	private static UGCTimelineEditorKeyBase CreateKeyFrame(MHHOHPCLMFB TrackType)
	{
		return null;
	}

	public static UGCTimelineEditorKeyBase CreateKeyFrame(MHHOHPCLMFB TrackType, GHKGGCEMAKO frameData)
	{
		return null;
	}

	public static UGCTimelineEditorKeyBase CreateKeyFrame(MHHOHPCLMFB TrackType, float time)
	{
		return null;
	}

	public static UGCTimelineEditorKeyBase CreateKeyFrame(MHHOHPCLMFB TrackType, CCHOFCIGDHH eKeyframe, GHKGGCEMAKO rKeyframe)
	{
		return null;
	}

	public static bool TryCreateTrackData(MHHOHPCLMFB TrackType, string TrackName, int TrackID, out IUGCTimelineEditorTrack track)
	{
		track = null;
		return false;
	}

	public static IUGCTimelineEditorTrack CreateTrackData(HPKDGEHKENL trackData, NCFFELGEBLB editorTrackData)
	{
		return null;
	}

	public static bool TryGetBindTrackByTypeName(string typeName, out UGCTimelineEditTracksConfig cfg)
	{
		cfg = null;
		return false;
	}

	public static UGCTimelineEditTracksConfig GetTrackConfig(MHHOHPCLMFB trackType)
	{
		return null;
	}

	public static void CreateKeyClipData(IUGCTimelineEditorTrackBaseWarp trackWarp, float Time, Action<bool, UGCTimelineEditorKeyBase> createdCall)
	{
	}

	public static void CreateAudioKeyClip(IUGCTimelineEditorTrackBaseWarp trackWarp, float Time, Action<bool, UGCTimelineEditorKeyBase> createdCall)
	{
	}

	public static GHKGGCEMAKO CreateKeyClipData(MHHOHPCLMFB trackType, float Time, float Duration, Dictionary<string, MutableValue> coverMap = null)
	{
		return null;
	}

	public static GHKGGCEMAKO CreateMultiValueKeyFrameData(MHHOHPCLMFB trackType, float Time, float Duration, Dictionary<string, MutableValue> coverMap = null)
	{
		return null;
	}

	public static GHKGGCEMAKO CreateKeyFrameData(float Time, float Duration, UGCVarValueDataV2 Value)
	{
		return null;
	}

	public static string GetAnimationClipName(int itemType, int itemID, int uiAvatarType)
	{
		return null;
	}

	public static UIModelUGCResourceSelect.AvatarEditorItemData GetAvatarEditorItemData(int itemType, int itemID, int uiAvatarType)
	{
		return null;
	}

	public static int GetNPCAvatarType(string entityID)
	{
		return 0;
	}

	public static void TryEmoteIDToResUID(int avatarType, int itemType, int itemId, ref string resourceName)
	{
	}

	public static float GetValidTime(float time, float duration)
	{
		return 0f;
	}

	public static float GetValidDuration(float time, float duration)
	{
		return 0f;
	}

	public static string BuildAnimationClipParams(int avatarType, int itemType, int itemId)
	{
		return null;
	}

	public static bool TryParseAnimationClipParams(string value, out int itemType, out int avatarType, out int itemId)
	{
		itemType = default(int);
		avatarType = default(int);
		itemId = default(int);
		return false;
	}

	public static UGCVarValueDataV2 GetOrCreateMapValue(IJHPDKODECM mapValue, string key)
	{
		return null;
	}

	public static UGCVarValueDataV2 GetMapValue(IJHPDKODECM mapValue, string key)
	{
		return null;
	}

	public static string QuaternionToString(Quaternion qua)
	{
		return null;
	}

	public static string Vector3ToString(Vector3 v3)
	{
		return null;
	}

	public static Vector3 StringToVector3(string str)
	{
		return default(Vector3);
	}

	public static Quaternion StringToQuaternion(string str)
	{
		return default(Quaternion);
	}

	public static string Vector2ToString(Vector2 vec)
	{
		return null;
	}

	public static Vector2 StringToVector2(string value)
	{
		return default(Vector2);
	}

	public static string GetAttributeEntityValue(UGCSimpleValue newValue, long index)
	{
		return null;
	}

	public static List<UGCVarValueDataV2> CreateAttributeValueList(List<FDGCNDLOKME> paramsData)
	{
		return null;
	}

	public static UGCVarValueDataV2 CreateAttributeValue(MHJLOKOOGNB type, MutableValue value)
	{
		return null;
	}

	public static string GetVarDataValue(UGCVarValueDataV2 data, string type)
	{
		return null;
	}

	public static bool SetArgumentValue(string type, UGCVarValueDataV2 dataWarp, MutableValue value)
	{
		return false;
	}

	public static UGCVarValueDataV2 GetArgumentVarData(UGCTimelineEditorKeyClip keyFrameData, string argumentName)
	{
		return null;
	}

	public static void AddOrUpdatePositionKeyFrame(UGCTimelineEditorEntityTrackWarp track, float time, Vector3 value, bool refreshPreview = true)
	{
	}

	public static void AddOrUpdateRatationKeyFrame(UGCTimelineEditorEntityTrackWarp track, float time, Vector3 value, bool refreshPreview = true)
	{
	}

	public static void AddOrUpdateScaleKeyFrame(UGCTimelineEditorEntityTrackWarp track, float time, Vector3 value, bool refreshPreview = true)
	{
	}

	private static void AddOrUpdateVector3KeyFrame(UGCTimelineEditorEntityTrackWarp track, int PropID, string propertyName, float time, Vector3 value, bool refreshPreview = true)
	{
	}

	public static bool CheckTimeEquals(float a, float b)
	{
		return false;
	}

	public static bool CheckTimeGreaterOrEquals(float a, float b)
	{
		return false;
	}

	public static bool CheckTimeLessOrEquals(float a, float b)
	{
		return false;
	}

	public static void SortPairedKeyframesByTime(List<GHKGGCEMAKO> runtimeKeyFrames, List<CCHOFCIGDHH> editorKeyFrames)
	{
	}

	public static void ShowWarningTip(long errorCode)
	{
	}

	public static string GetWarningTipText(UGCTimelineEditorErrorCode code)
	{
		return null;
	}

	public static void Serialized()
	{
	}

	public static void ShowTimelineRuleTip(int tipId = 1)
	{
	}

	public static UGCTimelineEditorContext CurrentTimelineEditorContext()
	{
		return null;
	}

	public static void CreateTimeline(CAIDHLFFJDP asset, PAEHKPKMJKN timelineData)
	{
	}

	public static void DestroyTimeline()
	{
	}
}
