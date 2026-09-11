using System;
using message;

namespace COW.Gameplay.UGC;

public class UGCTimelineEditorKeyClipTrack : UGCTimelineEditorTrack
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<UGCTimelineEditorKeyBase> _003C_003E9__4_0;

		public static Comparison<GHKGGCEMAKO> _003C_003E9__5_0;

		public static Comparison<CCHOFCIGDHH> _003C_003E9__5_1;

		internal int _003CRefreshTrackTime_003Eb__4_0(UGCTimelineEditorKeyBase a, UGCTimelineEditorKeyBase b)
		{
			return 0;
		}

		internal int _003CDeserialize_003Eb__5_0(GHKGGCEMAKO a, GHKGGCEMAKO b)
		{
			return 0;
		}

		internal int _003CDeserialize_003Eb__5_1(CCHOFCIGDHH a, CCHOFCIGDHH b)
		{
			return 0;
		}
	}

	public const string TRACK_ARGUMENT_NAME = "ArgumentName";

	public string ArgumentName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override void RefreshTrackTime()
	{
	}

	public override void Deserialize()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshTrackTime()
	{
	}

	public void _003C_003EiFixBaseProxy_Deserialize()
	{
	}
}
