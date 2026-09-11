using System.Collections.Generic;
using GCommon;

namespace COW;

public class CommunityWebsiteData : CSVBaseData
{
	private const string REGION_DEFAULT = "default";

	private const string LANGUAGE_DEFAULT = "default";

	private static Dictionary<string, Dictionary<string, CommunityWebsiteData>> _Data;

	private string _003CRegion_003Ek__BackingField;

	private string _003CLanguageAbbr_003Ek__BackingField;

	private string _003CFacebookURL_003Ek__BackingField;

	private string _003COfficialURL_003Ek__BackingField;

	private string _003CGER_TermsOfService_003Ek__BackingField;

	private string _003CGER_HelpAndSupport_003Ek__BackingField;

	public string Inslwebsite;

	private int _003CID_003Ek__BackingField;

	private bool _003CExternalForFacebook_003Ek__BackingField;

	private bool _003CExternalForOfficial_003Ek__BackingField;

	private bool _003CShowFacebook_003Ek__BackingField;

	private bool _003CShowOfficial_003Ek__BackingField;

	public bool ExternalForIns;

	public bool ShowIns;

	public string Region
	{
		get
		{
			return _003CRegion_003Ek__BackingField;
		}
		private set
		{
			_003CRegion_003Ek__BackingField = value;
		}
	}

	public string LanguageAbbr
	{
		get
		{
			return _003CLanguageAbbr_003Ek__BackingField;
		}
		private set
		{
			_003CLanguageAbbr_003Ek__BackingField = value;
		}
	}

	public string FacebookURL
	{
		get
		{
			return _003CFacebookURL_003Ek__BackingField;
		}
		private set
		{
			_003CFacebookURL_003Ek__BackingField = value;
		}
	}

	public string OfficialURL
	{
		get
		{
			return _003COfficialURL_003Ek__BackingField;
		}
		private set
		{
			_003COfficialURL_003Ek__BackingField = value;
		}
	}

	public string GER_TermsOfService
	{
		get
		{
			return _003CGER_TermsOfService_003Ek__BackingField;
		}
		private set
		{
			_003CGER_TermsOfService_003Ek__BackingField = value;
		}
	}

	public string GER_HelpAndSupport
	{
		get
		{
			return _003CGER_HelpAndSupport_003Ek__BackingField;
		}
		private set
		{
			_003CGER_HelpAndSupport_003Ek__BackingField = value;
		}
	}

	public int ID
	{
		get
		{
			return _003CID_003Ek__BackingField;
		}
		private set
		{
			_003CID_003Ek__BackingField = value;
		}
	}

	public bool ExternalForFacebook
	{
		get
		{
			return _003CExternalForFacebook_003Ek__BackingField;
		}
		private set
		{
			_003CExternalForFacebook_003Ek__BackingField = value;
		}
	}

	public bool ExternalForOfficial
	{
		get
		{
			return _003CExternalForOfficial_003Ek__BackingField;
		}
		private set
		{
			_003CExternalForOfficial_003Ek__BackingField = value;
		}
	}

	public bool ShowFacebook
	{
		get
		{
			return _003CShowFacebook_003Ek__BackingField;
		}
		private set
		{
			_003CShowFacebook_003Ek__BackingField = value;
		}
	}

	public bool ShowOfficial
	{
		get
		{
			return _003CShowOfficial_003Ek__BackingField;
		}
		private set
		{
			_003CShowOfficial_003Ek__BackingField = value;
		}
	}

	public static CommunityWebsiteData Get(string region, string language)
	{
		return null;
	}

	public static void Clear()
	{
	}

	private static Dictionary<string, CommunityWebsiteData> Get(string region)
	{
		return null;
	}

	private static CommunityWebsiteData Get(string language, Dictionary<string, CommunityWebsiteData> data)
	{
		return null;
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
