namespace GCommon;

public struct Duotricemary
{
	private const string CHARS = "0123456789ABCDEFGHJKLMNPQRTUVWXY";

	private string m_StringValue = null;

	private ulong? m_IntValue = null;

	public string StringValue
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ulong? IntValue
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Duotricemary(string stringValue)
	{
	}

	public Duotricemary(ulong intValue)
	{
	}

	public static Duotricemary FromString(string stringValue)
	{
		return default(Duotricemary);
	}

	public static Duotricemary FromInt(uint intValue)
	{
		return default(Duotricemary);
	}

	public ulong ToInt()
	{
		return 0uL;
	}

	private ulong ToInt(string stringValue)
	{
		return 0uL;
	}

	private string ToDuotricemaryString(ulong intValue)
	{
		return null;
	}

	public static implicit operator Duotricemary(ulong value)
	{
		return default(Duotricemary);
	}

	public static implicit operator Duotricemary(string value)
	{
		return default(Duotricemary);
	}

	public static Duotricemary operator +(Duotricemary d, ulong value)
	{
		return default(Duotricemary);
	}

	public static Duotricemary operator -(Duotricemary d, ulong value)
	{
		return default(Duotricemary);
	}

	public override string ToString()
	{
		return null;
	}
}
