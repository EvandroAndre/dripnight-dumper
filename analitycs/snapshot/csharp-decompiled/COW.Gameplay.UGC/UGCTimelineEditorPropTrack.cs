using message;

namespace COW.Gameplay.UGC;

public class UGCTimelineEditorPropTrack : UGCTimelineEditorKeyFrameTrack
{
	protected UGCVarValueDataV2 m_PropID;

	public int PropID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public override void Create(MHHOHPCLMFB trackType, string PropertyName, int TrackID)
	{
	}

	public override void Deserialize()
	{
	}

	public void _003C_003EiFixBaseProxy_Create(MHHOHPCLMFB P0, string P1, int P2)
	{
	}

	public new void _003C_003EiFixBaseProxy_Deserialize()
	{
	}
}
