using GCommon;

namespace COW.GamePlay;

internal class AINCFKPBCDI : LoadingProcess
{
	private bool HINHALDINDD;

	public override bool IsMainProcess()
	{
		return false;
	}

	protected override void OnStartProcess()
	{
	}

	protected override EProcessStatus OnUpdateProcess()
	{
		return EProcessStatus.NotStarted;
	}

	public bool _003C_003EiFixBaseProxy_IsMainProcess()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnStartProcess()
	{
	}

	public EProcessStatus _003C_003EiFixBaseProxy_OnUpdateProcess()
	{
		return EProcessStatus.NotStarted;
	}
}
