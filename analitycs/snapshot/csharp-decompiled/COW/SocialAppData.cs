using GCommon;

namespace COW;

public class SocialAppData : CSVBaseData
{
	public string RegionName;

	public bool FacebookShareMatchResult;

	public bool FacebookInviteFriend;

	public bool FacebookGroupInvite;

	public bool LineShareMatchResult;

	public bool LineInviteFriend;

	public bool LineGroupInvite;

	public bool WhatsAppShareMatchResult;

	public bool WhatsAppInviteFriend;

	public bool WhatsAppGroupInvite;

	public bool InstagramShareMatchResult;

	public bool InstagramInviteFriend;

	public bool InstagramGroupInvite;

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
