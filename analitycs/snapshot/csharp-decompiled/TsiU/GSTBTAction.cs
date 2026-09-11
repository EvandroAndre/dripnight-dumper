using COW.GamePlay.UGCRuntime;

namespace TsiU;

public abstract class GSTBTAction : TBTAction, IGSTBTAction
{
	protected bool m_IsOpen;

	protected GSTBTAction(int maxChildCount)
		: base(0)
	{
	}

	public override int Update(TBTWorkingData wData)
	{
		return 0;
	}

	protected virtual void OnOpen(TBTWorkingData wData)
	{
	}

	protected virtual void OnClose(TBTWorkingData wData)
	{
	}

	public void Open(TBTWorkingData wData)
	{
	}

	public void Close(TBTWorkingData wData)
	{
	}
}
