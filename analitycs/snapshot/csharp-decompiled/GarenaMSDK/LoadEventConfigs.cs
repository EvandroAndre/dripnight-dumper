using System;

namespace GarenaMSDK;

internal class LoadEventConfigs : SDKIAPTaskInstance
{
	public bool ActiveOnly;

	private SDKIAP.LoadEventConfigsResult _Result;

	public Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.LoadEventConfigsResult> OnDone;

	public override SDKIAPTask Task => SDKIAPTask.None;

	public LoadEventConfigs(SDKIAPTaskInfo info)
		: base(null)
	{
	}

	internal override string IdentifySelf()
	{
		return null;
	}

	public override bool IsDuplicateOf(SDKIAPTaskInstance peer)
	{
		return false;
	}

	public override bool CanFinishWith(SDKIAPTaskInstance peer)
	{
		return false;
	}

	protected override void Start()
	{
	}

	private void OnLoadedEventConfigs(SDKIAP.LoadEventConfigsResult result)
	{
	}

	protected override void Succeed()
	{
	}

	protected override void Fail()
	{
	}

	protected override void Destroy()
	{
	}

	private void _003CSucceed_003Eb__11_0(LoadEventConfigs i)
	{
	}

	private void _003CFail_003Eb__12_0(LoadEventConfigs i)
	{
	}

	public SDKIAPTask _003C_003EiFixBaseProxy_get_Task()
	{
		return SDKIAPTask.None;
	}

	public string _003C_003EiFixBaseProxy_IdentifySelf()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_IsDuplicateOf(SDKIAPTaskInstance P0)
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_CanFinishWith(SDKIAPTaskInstance P0)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_Start()
	{
	}

	public void _003C_003EiFixBaseProxy_Succeed()
	{
	}

	public void _003C_003EiFixBaseProxy_Fail()
	{
	}

	public void _003C_003EiFixBaseProxy_Destroy()
	{
	}
}
