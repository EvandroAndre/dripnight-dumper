namespace proto;

public class CSGetBackpackReq
{
	public uint item_type;

	public bool is_login;

	public string language;

	public bool need_weapon_skin_custom;

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
