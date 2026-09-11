using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCTimeLineAlongPathTrack : UGCTimeLineTrackBase
{
	private UGCRuntime m_UGCRuntime;

	private UGCEntityDataStore m_EntityDataStore;

	private UGCPlayableModule m_PlayableModule;

	private UGCLogicEntity m_AlongPathEntity;

	private LFGOCIPJGMP m_AlongPathPlayable;

	private UGCLogicEntity m_Path;

	private float m_Speed;

	private bool m_TangentFacing;

	private int m_Style;

	private bool m_CurIsPlayMode;

	public override bool Init(IUGCTimeLine timeLine, HPKDGEHKENL res)
	{
		return false;
	}

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

	public override void Update()
	{
	}

	private void UpdateElapsedPercentage()
	{
	}

	public override void OnPlay()
	{
	}

	public override void OnPause()
	{
	}

	public bool _003C_003EiFixBaseProxy_Init(IUGCTimeLine P0, HPKDGEHKENL P1)
	{
		return false;
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

	public void _003C_003EiFixBaseProxy_Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPlay()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPause()
	{
	}
}
