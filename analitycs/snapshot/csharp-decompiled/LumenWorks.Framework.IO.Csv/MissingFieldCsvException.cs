using System;
using System.Runtime.Serialization;

namespace LumenWorks.Framework.IO.Csv;

[Serializable]
public class MissingFieldCsvException : MalformedCsvException
{
	public MissingFieldCsvException()
	{
	}

	public MissingFieldCsvException(string message)
	{
	}

	public MissingFieldCsvException(string message, Exception innerException)
	{
	}

	public MissingFieldCsvException(string rawData, int currentPosition, long currentRecordIndex, int currentFieldIndex, string csvParseType)
	{
	}

	public MissingFieldCsvException(string rawData, int currentPosition, long currentRecordIndex, int currentFieldIndex, Exception innerException, string csvParseType)
	{
	}

	protected MissingFieldCsvException(SerializationInfo info, StreamingContext context)
	{
	}
}
