using System;

namespace GCommon;

public class ParseCSVException : Exception
{
	public ParseCSVException(long lineNumber, string message, Exception innerException)
	{
	}

	private static string FormatMessage(long lineNumber, string message)
	{
		return null;
	}
}
