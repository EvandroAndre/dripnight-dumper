using System.Collections.Generic;
using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCTimeLineEvetTrack : UGCTimelineEntityTrack
{
	private enum EParamsExtendType
	{
		EParamsExtendType_None,
		EParamsExtendType_TrackID
	}

	private string m_TraceActorUGCEntityID;

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

	public override void OnEnd()
	{
	}

	protected override void OnKeyFrameEnter(GHKGGCEMAKO keyFrameData)
	{
	}

	private void DispatchEvent(UGCVarValueDataV2 eventKeyFrameData)
	{
	}

	private bool GetEventParams(UGCVarValueDataV2 eventKeyFrameData, ref UGCLogicEntity receiverEntity, ref int eventType, ref int targetSide, ref List<object> arg)
	{
		return false;
	}

	public new bool _003C_003EiFixBaseProxy_Init(IUGCTimeLine P0, HPKDGEHKENL P1)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_Destroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	public void _003C_003EiFixBaseProxy_OnEnd()
	{
	}

	public void _003C_003EiFixBaseProxy_OnKeyFrameEnter(GHKGGCEMAKO P0)
	{
	}
}
