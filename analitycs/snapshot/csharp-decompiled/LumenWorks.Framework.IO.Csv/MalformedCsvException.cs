using System;
using System.Runtime.Serialization;

namespace LumenWorks.Framework.IO.Csv;

[Serializable]
public class MalformedCsvException : Exception
{
	private string _message;

	private string _rawData;

	private int _currentFieldIndex;

	private long _currentRecordIndex;

	private int _currentPosition;

	public string RawData => null;

	public int CurrentPosition => 0;

	public long CurrentRecordIndex => 0L;

	public int CurrentFieldIndex => 0;

	public override string Message => null;

	public MalformedCsvException()
	{
	}

	public MalformedCsvException(string message)
	{
	}

	public MalformedCsvException(string message, Exception innerException)
	{
	}

	public MalformedCsvException(string rawData, int currentPosition, long currentRecordIndex, int currentFieldIndex, string csvParseType)
	{
	}

	public MalformedCsvException(string rawData, int currentPosition, long currentRecordIndex, int currentFieldIndex, Exception innerException, string csvParseType)
	{
	}

	protected MalformedCsvException(SerializationInfo info, StreamingContext context)
	{
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}
}
