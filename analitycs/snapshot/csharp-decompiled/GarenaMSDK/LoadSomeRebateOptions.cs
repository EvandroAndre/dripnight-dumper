using System;

namespace GarenaMSDK;

internal class LoadSomeRebateOptions : SDKIAPTaskInstance
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<long, string> _003C_003E9__6_0;

		internal string _003CIdentifySelf_003Eb__6_0(long id)
		{
			return null;
		}
	}

	public long[] RebateIds;

	private SDKIAP.RebateOption[] _RebateOptions;

	public Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.RebateOption[]> OnDone;

	public override SDKIAPTask Task => SDKIAPTask.None;

	public LoadSomeRebateOptions(SDKIAPTaskInfo info)
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

	private void OnLoadedRebateOptions(SDKIAP.RebateOption[] rebateOptions, ErrorCode errorCode, string errorMessage)
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

	private void _003CSucceed_003Eb__11_0(LoadSomeRebateOptions i)
	{
	}

	private void _003CFail_003Eb__12_0(LoadSomeRebateOptions i)
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
