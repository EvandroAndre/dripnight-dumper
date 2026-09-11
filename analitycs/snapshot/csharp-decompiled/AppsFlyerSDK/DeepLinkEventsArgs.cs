using System;
using System.Collections.Generic;

namespace AppsFlyerSDK;

public class DeepLinkEventsArgs : EventArgs
{
	public Dictionary<string, object> deepLink;

	private readonly DeepLinkStatus _003Cstatus_003Ek__BackingField;

	private readonly DeepLinkError _003Cerror_003Ek__BackingField;

	public DeepLinkStatus status => _003Cstatus_003Ek__BackingField;

	public DeepLinkError error => _003Cerror_003Ek__BackingField;

	public string getMatchType()
	{
		return null;
	}

	public string getDeepLinkValue()
	{
		return null;
	}

	public string getClickHttpReferrer()
	{
		return null;
	}

	public string getMediaSource()
	{
		return null;
	}

	public string getCampaign()
	{
		return null;
	}

	public string getCampaignId()
	{
		return null;
	}

	public string getAfSub1()
	{
		return null;
	}

	public string getAfSub2()
	{
		return null;
	}

	public string getAfSub3()
	{
		return null;
	}

	public string getAfSub4()
	{
		return null;
	}

	public string getAfSub5()
	{
		return null;
	}

	public bool isDeferred()
	{
		return false;
	}

	public Dictionary<string, object> getDeepLinkDictionary()
	{
		return null;
	}

	public DeepLinkEventsArgs(string str)
	{
	}

	private string getDeepLinkParameter(string name)
	{
		return null;
	}
}
