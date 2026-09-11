using System.IO;

namespace GCommon;

public class TextReaderExt : TextReader
{
	public virtual string ReadLine(bool aquire)
	{
		return null;
	}

	public virtual void SkipLine()
	{
	}

	public virtual void ReadLine(MutableString mutableStr)
	{
	}
}
