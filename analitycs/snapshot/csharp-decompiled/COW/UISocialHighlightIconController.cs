using GCommon;
using proto;
using tcp;

namespace COW;

public class UISocialHighlightIconController : UISocialHighlightBaseController
{
	private UISocialHighlightIconView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnSetViewData(proto.SocialHighLight highlight)
	{
	}

	protected override void OnSetViewData(tcp.SocialHighLight highlight)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSetViewData(proto.SocialHighLight P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnSetViewData(tcp.SocialHighLight P0)
	{
	}
}
