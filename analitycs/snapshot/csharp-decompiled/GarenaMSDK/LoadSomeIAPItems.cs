using System;

namespace GarenaMSDK;

internal class LoadSomeIAPItems : SDKIAPTaskInstance
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<int, string> _003C_003E9__8_0;

		public static Converter<long, string> _003C_003E9__8_1;

		internal string _003CIdentifySelf_003Eb__8_0(int id)
		{
			return null;
		}

		internal string _003CIdentifySelf_003Eb__8_1(long id)
		{
			return null;
		}
	}

	public bool Localized;

	public int[] ItemIds;

	public long[] RebateIds;

	public SDKIAP.IAPItem[] _Products;

	public Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.IAPItem[]> OnDone;

	public override SDKIAPTask Task => SDKIAPTask.None;

	public LoadSomeIAPItems(SDKIAPTaskInfo info)
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

	private void OnLoadedIAPItems(SDKIAP.IAPItem[] items, ErrorCode errorCode, string errorMessage)
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

	private void _003CSucceed_003Eb__13_0(LoadSomeIAPItems i)
	{
	}

	private void _003CFail_003Eb__14_0(LoadSomeIAPItems i)
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
