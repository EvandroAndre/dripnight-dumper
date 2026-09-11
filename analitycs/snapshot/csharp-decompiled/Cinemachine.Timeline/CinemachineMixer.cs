using UnityEngine.Playables;

namespace Cinemachine.Timeline;

internal sealed class CinemachineMixer : PlayableBehaviour
{
	private struct ClipInfo
	{
		public ICinemachineCamera vcam;

		public float weight;

		public double localTime;

		public double duration;
	}

	private CinemachineBrain mBrain;

	private int mBrainOverrideId;

	private bool mPlaying;

	private float mLastOverrideFrame;

	public override void OnPlayableDestroy(Playable playable)
	{
	}

	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	private float GetDeltaTime(float deltaTime)
	{
		return 0f;
	}
}
