using System.IO;

namespace GCommon;

public class TextReaderExtAdapter : TextReaderExt
{
	private TextReader m_Reader;

	public TextReaderExtAdapter(TextReader r)
	{
	}

	public override string ReadLine()
	{
		return null;
	}
}
