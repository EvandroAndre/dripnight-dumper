using GCommon;

namespace COW;

internal class UIHudMatchEndShowTime_HippoCrisisController : UIHudMatchEndShowTimeController
{
	private uint m_DelayCallId;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void CreateView()
	{
	}

	protected override void FillMatchResultInfo(bool win, int rank = 0)
	{
	}

	protected override bool NeedPlayGameEndSound()
	{
		return false;
	}

	protected override void SendGameEnd()
	{
	}

	private void RealSendGameEnd()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_CreateView()
	{
	}

	public void _003C_003EiFixBaseProxy_FillMatchResultInfo(bool P0, int P1)
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedPlayGameEndSound()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_SendGameEnd()
	{
	}
}
