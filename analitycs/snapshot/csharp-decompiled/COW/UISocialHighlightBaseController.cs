using System.Collections.Generic;
using GCommon;
using proto;
using tcp;

namespace COW;

public abstract class UISocialHighlightBaseController : UIBaseController
{
	protected SocialHighlightData m_Data;

	public void SetViewData(List<tcp.SocialHighLight> socialhighlights, EMatch.MatchMode matchMode)
	{
	}

	public void SetViewData(List<proto.SocialHighLight> socialhighlights, EMatch.MatchMode matchMode)
	{
	}

	public void SetViewData(proto.SocialHighLight highlight)
	{
	}

	public void SetViewData(tcp.SocialHighLight highlight)
	{
	}

	protected virtual void OnSetViewData(proto.SocialHighLight highlight)
	{
	}

	protected virtual void OnSetViewData(tcp.SocialHighLight highlight)
	{
	}
}
