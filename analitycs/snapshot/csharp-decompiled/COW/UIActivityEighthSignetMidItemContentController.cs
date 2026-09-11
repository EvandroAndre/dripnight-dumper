using GCommon;

namespace COW;

public class UIActivityEighthSignetMidItemContentController : UIActivityEighthSignetItemContentController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool NeedShowFirstUIFX()
	{
		return false;
	}

	protected override uint GetCDNContentBgType()
	{
		return 0u;
	}

	protected override uint GetCDNMaskBgType()
	{
		return 0u;
	}

	protected override uint GetCDNContentCompleteBgType()
	{
		return 0u;
	}

	public bool _003C_003EiFixBaseProxy_NeedShowFirstUIFX()
	{
		return false;
	}

	public uint _003C_003EiFixBaseProxy_GetCDNContentBgType()
	{
		return 0u;
	}

	public uint _003C_003EiFixBaseProxy_GetCDNMaskBgType()
	{
		return 0u;
	}

	public uint _003C_003EiFixBaseProxy_GetCDNContentCompleteBgType()
	{
		return 0u;
	}
}
