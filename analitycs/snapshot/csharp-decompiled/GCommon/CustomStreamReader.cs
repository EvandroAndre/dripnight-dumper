using System.IO;
using System.Text;
using UnityEngine;

namespace GCommon;

public class CustomStreamReader : StreamReader
{
	public Object ResourceObj;

	public CustomStreamReader(Stream stream)
		: base((Stream)null)
	{
	}

	public CustomStreamReader(Stream stream, Encoding encoding)
		: base((Stream)null)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}
}
