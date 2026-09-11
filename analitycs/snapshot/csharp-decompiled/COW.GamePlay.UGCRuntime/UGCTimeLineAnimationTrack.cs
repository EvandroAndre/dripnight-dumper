using COW.Gameplay.UGC;
using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCTimeLineAnimationTrack : UGCTimeLineTrackBase
{
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public UGCTimeLineAnimationTrack _003C_003E4__this;

		public UGCAnimationControllerComplex finalController;

		internal void _003CCreateDynamicState_003Eb__0(bool succ, UGCResAnimationClip resObj)
		{
		}
	}

	private UGCRuntime m_UGCRuntime;

	private UGCEntityDataStore m_EntityDataStore;

	private UGCAnimationModule m_AnimationModule;

	private UGCAnimationControllerEntity m_AnimationControllerEntity;

	private UGCAnimationControllerComplex.DynamicClipInfo m_curDynamicClipInfo;

	private string m_CurAnimationClipResUID;

	private TimelineClipLoopType m_ClipLoopType;

	private UGCAnimationControllerComplex.StatePlayInfo m_CurStatePlayInfo;

	private bool m_CurIsPlayMode;

	public override bool Init(IUGCTimeLine timeLine, HPKDGEHKENL res)
	{
		return false;
	}

	public override void Destroy()
	{
	}

	public override void OnStart()
	{
	}

	public override float GetEndTime()
	{
		return 0f;
	}

	public override void OnEnd()
	{
	}

	private void ReadKeyFrameDataParameter(GHKGGCEMAKO keyFrameData)
	{
	}

	protected override void OnKeyFrameEnter(GHKGGCEMAKO keyFrameData)
	{
	}

	private void CreateDynamicState()
	{
	}

	private void RemoveDynamicState()
	{
	}

	protected override void OnKeyFrameLeave(GHKGGCEMAKO keyFrameData)
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

	public bool _003C_003EiFixBaseProxy_Init(IUGCTimeLine P0, HPKDGEHKENL P1)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_Destroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	public float _003C_003EiFixBaseProxy_GetEndTime()
	{
		return 0f;
	}

	public void _003C_003EiFixBaseProxy_OnEnd()
	{
	}

	public void _003C_003EiFixBaseProxy_OnKeyFrameEnter(GHKGGCEMAKO P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnKeyFrameLeave(GHKGGCEMAKO P0)
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
