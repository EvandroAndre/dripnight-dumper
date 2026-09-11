using GCommon;
using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCTimeLineAudioTrack : UGCTimeLineTrackBase
{
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public UGCTimeLineAudioTrack _003C_003E4__this;

		public string requestedRes;

		public GHKGGCEMAKO keyFrameAtRequest;

		internal void _003CPlayAudio_003Eb__0(AudioResource obj)
		{
		}
	}

	private AudioResource m_Cur2DEngineResource;

	private string m_AudioResource;

	private float m_Speed;

	private float m_Volume;

	private TimelineClipLoopType m_LoopType;

	private bool m_PlayAudioIng;

	public override void Destroy()
	{
	}

	private void ReadKeyFrameDataParameter(GHKGGCEMAKO keyFrameData)
	{
	}

	protected override void OnKeyFrameEnter(GHKGGCEMAKO keyFrameData)
	{
	}

	protected override void OnKeyFrameLeave(GHKGGCEMAKO keyFrameData)
	{
	}

	public override float GetEndTime()
	{
		return 0f;
	}

	public override void OnEnd()
	{
	}

	private void PlayAudio()
	{
	}

	private void StopCurAudio()
	{
	}

	public override void Update()
	{
	}

	public override void OnPlay()
	{
	}

	public override void OnPause()
	{
	}

	public override void UpdateCurKeyFrame()
	{
	}

	public void _003C_003EiFixBaseProxy_Destroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnKeyFrameEnter(GHKGGCEMAKO P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnKeyFrameLeave(GHKGGCEMAKO P0)
	{
	}

	public float _003C_003EiFixBaseProxy_GetEndTime()
	{
		return 0f;
	}

	public void _003C_003EiFixBaseProxy_OnEnd()
	{
	}

	public void _003C_003EiFixBaseProxy_Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPlay()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPause()
	{
	}

	public void _003C_003EiFixBaseProxy_UpdateCurKeyFrame()
	{
	}
}
