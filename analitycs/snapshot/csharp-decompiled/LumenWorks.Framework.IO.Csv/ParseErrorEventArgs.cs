using System;

namespace LumenWorks.Framework.IO.Csv;

public class ParseErrorEventArgs : EventArgs
{
	private MalformedCsvException _error;

	private ParseErrorAction _action;

	public MalformedCsvException Error => null;

	public ParseErrorAction Action
	{
		get
		{
			return ParseErrorAction.RaiseEvent;
		}
		set
		{
		}
	}

	public ParseErrorEventArgs(MalformedCsvException error, ParseErrorAction defaultAction)
	{
	}
}
