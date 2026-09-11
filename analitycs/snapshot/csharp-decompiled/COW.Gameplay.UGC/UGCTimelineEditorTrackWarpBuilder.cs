using System;
using COW.GamePlay;
using UnityEngine;
using message;

namespace COW.Gameplay.UGC;

public static class UGCTimelineEditorTrackWarpBuilder
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<string, int> _003C_003E9__1_0;

		internal void _003CCreateAudioTrackWarpFromResourceSelect_003Eb__1_0(string resourceName, int itemID)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass1_0
	{
		public string resourceName;

		public int itemID;

		public Predicate<FCAJEKECGME> _003C_003E9__2;

		internal void _003CCreateAudioTrackWarpFromResourceSelect_003Eb__1(uint tid, bool ret, UnityEngine.Object ffRes)
		{
		}

		internal bool _003CCreateAudioTrackWarpFromResourceSelect_003Eb__2(FCAJEKECGME x)
		{
			return false;
		}
	}

	public static void CreateEntityTrackWarp(SceneEditObjectBase target)
	{
	}

	public static void CreateAudioTrackWarpFromResourceSelect()
	{
	}

	public static void CreateNoEntityTrackWarp(MHHOHPCLMFB trackType)
	{
	}

	public static bool TryCreatePropertyTrackWarp(string entityID, int propID, string name, float startTime, float endTime, out UGCTimelineEditorTrackBaseWarp warp)
	{
		warp = null;
		return false;
	}

	public static bool TryCreateSubTrackWarp(MHHOHPCLMFB TrackType, string entityID, string name, string trackValue, float startTime, float endTime, out UGCTimelineEditorTrackBaseWarp warp)
	{
		warp = null;
		return false;
	}

	public static UGCTimelineEditorKeyBase DeserializeKeyClip(MHHOHPCLMFB TrackType, CCHOFCIGDHH eKeyframe, GHKGGCEMAKO rKeyframe = null)
	{
		return null;
	}
}
