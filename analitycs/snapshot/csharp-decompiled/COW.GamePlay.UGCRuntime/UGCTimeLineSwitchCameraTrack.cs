using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCTimeLineSwitchCameraTrack : UGCTimeLineTrackBase
{
	private UGCLogicEntity m_CameraEntity;

	private UGCLogicEntity m_DefaultCameraEntity;

	public override bool IsDisable
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public override void OnStart()
	{
	}

	private void ReadKeyFrameDataParameter(GHKGGCEMAKO keyFrameData)
	{
	}

	private void SwitchCamera(UGCLogicEntity basicCamera)
	{
	}

	protected override void OnKeyFrameEnter(GHKGGCEMAKO keyFrameData)
	{
	}

	protected override void OnKeyFrameLeave(GHKGGCEMAKO keyFrameData)
	{
	}

	public override void Destroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	public void _003C_003EiFixBaseProxy_OnKeyFrameEnter(GHKGGCEMAKO P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnKeyFrameLeave(GHKGGCEMAKO P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Destroy()
	{
	}

	public bool _003C_003EiFixBaseProxy_get_IsDisable()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_set_IsDisable(bool P0)
	{
	}
}
