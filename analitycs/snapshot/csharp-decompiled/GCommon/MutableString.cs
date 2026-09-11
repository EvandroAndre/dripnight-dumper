using System.Text;

namespace GCommon;

public class MutableString
{
	public static bool FallbackToSb;

	public static bool FallbackToEncodingGetString;

	public static bool FallbackToEncodingGetStringIfNotCompleted;

	private string m_str;

	private int m_Cap;

	private int m_Length;

	private StringBuilder m_sb;

	private unsafe int* p_length;

	private unsafe char* p_chars;

	// C# has no syntax for parameterized property 'Item'.
	public char get_Item(int i)
	{
		return '\0';
	}

	public void set_Item(int i, char value)
	{
	}

	public int Length
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Capacity => 0;

	public MutableString(int cap, bool fallback = false, bool canFallback = true)
	{
	}

	public unsafe char* GetPChars()
	{
		return null;
	}

	public void Clear()
	{
	}

	public override string ToString()
	{
		return null;
	}

	private void UpdateStrLength()
	{
	}

	public string AquireString()
	{
		return null;
	}

	public void EnsureSpace(int additionalCnt)
	{
	}

	protected void SetCap(int cap)
	{
	}

	public void Append(char c)
	{
	}

	public unsafe void Append(char* cs, int charCount)
	{
	}

	public void Append(byte[] cs, int startIndex, int charCount)
	{
	}

	public unsafe void Append(byte* cs, int charCount)
	{
	}

	public unsafe void Append(byte* cs, int startIndex, int charCount)
	{
	}

	public void Append(string s)
	{
	}

	public void Append(string s, int startIndex, int charCount)
	{
	}

	public void Append(byte[] bs, int start, int count, Encoding encoding)
	{
	}

	public void Append(int num)
	{
	}

	public void Append(float valueF, int accuracy = 2)
	{
	}

	public void AppendMinOrSec(int min)
	{
	}

	public void AppendMinAndSec(int min, int sec)
	{
	}

	public static void SetLabelText(UILabel label, MutableString s)
	{
	}
}
