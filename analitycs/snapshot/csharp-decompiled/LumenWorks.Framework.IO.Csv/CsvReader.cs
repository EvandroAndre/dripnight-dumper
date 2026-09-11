using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace LumenWorks.Framework.IO.Csv;

public class CsvReader : IEnumerable<string[]>, IEnumerable, IDisposable, IIndexString
{
	private enum DataReaderValidations
	{
		None,
		IsInitialized,
		IsNotClosed
	}

	public struct RecordEnumerator(CsvReader reader) : IEnumerator<string[]>, IEnumerator, IDisposable
	{
		private CsvReader _reader = null;

		private string[] _current = null;

		private long _currentRecordIndex = 0L;

		public string[] Current => null;

		object IEnumerator.Current => null;

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}

		public void Dispose()
		{
		}
	}

	public static readonly int DefaultBufferSize;

	public const char DefaultDelimiter = ',';

	public const char DefaultQuote = '"';

	public const char DefaultEscape = '"';

	public const char DefaultComment = '#';

	private static readonly StringComparer _fieldHeaderComparer;

	private TextReader _reader;

	private int _bufferSize;

	private char _comment;

	private char _escape;

	private char _delimiter;

	private char _quote;

	private ValueTrimmingOptions _trimmingOptions;

	private bool _hasHeaders;

	private ParseErrorAction _defaultParseErrorAction;

	private MissingFieldAction _missingFieldAction;

	private bool _supportsMultiline;

	private bool _skipEmptyLines;

	private bool _initialized;

	private string[] _fieldHeaders;

	private Dictionary<string, int> _fieldHeaderIndexes;

	private long _currentRecordIndex;

	private int _nextFieldStart;

	private int _nextFieldIndex;

	private string[] _fields;

	private int _fieldCount;

	private char[] _buffer;

	private int _bufferLength;

	private bool _eof;

	private bool _eol;

	private bool _firstRecordInCache;

	private bool _missingFieldFlag;

	private bool _parseErrorFlag;

	private Type _csvParseType;

	private EventHandler<ParseErrorEventArgs> m_ParseError;

	private string _003CDefaultHeaderName_003Ek__BackingField;

	private bool _isDisposed;

	private readonly object _lock;

	private EventHandler m_Disposed;

	public char Comment => '\0';

	public char Escape => '\0';

	public char Delimiter => '\0';

	public char Quote => '\0';

	public bool HasHeaders => false;

	public ValueTrimmingOptions TrimmingOption => ValueTrimmingOptions.None;

	public int BufferSize => 0;

	public ParseErrorAction DefaultParseErrorAction
	{
		get
		{
			return ParseErrorAction.RaiseEvent;
		}
		set
		{
		}
	}

	public MissingFieldAction MissingFieldAction
	{
		get
		{
			return MissingFieldAction.ParseError;
		}
		set
		{
		}
	}

	public bool SupportsMultiline
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool SkipEmptyLines
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string DefaultHeaderName
	{
		get
		{
			return _003CDefaultHeaderName_003Ek__BackingField;
		}
		set
		{
			_003CDefaultHeaderName_003Ek__BackingField = value;
		}
	}

	public int FieldCount => 0;

	public virtual bool EndOfStream => false;

	public virtual long CurrentRecordIndex => 0L;

	public bool MissingFieldFlag => false;

	public bool ParseErrorFlag => false;

	// C# has no syntax for parameterized property 'Item'.
	public string get_Item(int record, string field)
	{
		return null;
	}

	// C# has no syntax for parameterized property 'Item'.
	public string get_Item(int record, int field)
	{
		return null;
	}

	// C# has no syntax for parameterized property 'Item'.
	public string get_Item(string field)
	{
		return null;
	}

	// C# has no syntax for parameterized property 'Item'.
	public virtual string get_Item(int field)
	{
		return null;
	}

	public bool IsDisposed => false;

	public event EventHandler<ParseErrorEventArgs> ParseError
	{
		add
		{
		}
		remove
		{
		}
	}

	public event EventHandler Disposed
	{
		add
		{
		}
		remove
		{
		}
	}

	public CsvReader(TextReader reader, bool hasHeaders, Type csvParseType = null)
	{
	}

	public CsvReader(TextReader reader, bool hasHeaders, int bufferSize, Type csvParseType = null)
	{
	}

	public CsvReader(TextReader reader, bool hasHeaders, char delimiter, Type csvParseType = null)
	{
	}

	public CsvReader(TextReader reader, bool hasHeaders, char delimiter, int bufferSize, Type csvParseType = null)
	{
	}

	public CsvReader(TextReader reader, bool hasHeaders, char delimiter, char quote, char escape, char comment, ValueTrimmingOptions trimmingOptions, Type csvParseType = null)
	{
	}

	public CsvReader(TextReader reader, bool hasHeaders, char delimiter, char quote, char escape, char comment, ValueTrimmingOptions trimmingOptions, int bufferSize, Type csvParseType = null)
	{
	}

	protected virtual void OnParseError(ParseErrorEventArgs e)
	{
	}

	public string[] GetFieldHeaders()
	{
		return null;
	}

	private void EnsureInitialize()
	{
	}

	public int GetFieldIndex(string header)
	{
		return 0;
	}

	public void CopyCurrentRecordTo(string[] array)
	{
	}

	public void CopyCurrentRecordTo(string[] array, int index)
	{
	}

	public string GetCurrentRawData()
	{
		return null;
	}

	private bool IsWhiteSpace(char c)
	{
		return false;
	}

	public virtual bool MoveTo(long record)
	{
		return false;
	}

	private bool ParseNewLine(ref int pos)
	{
		return false;
	}

	private bool IsNewLine(int pos)
	{
		return false;
	}

	private bool ReadBuffer()
	{
		return false;
	}

	private string ReadField(int field, bool initializing, bool discardValue)
	{
		return null;
	}

	public bool ReadNextRecord()
	{
		return false;
	}

	protected virtual bool ReadNextRecord(bool onlyReadHeaders, bool skipToNextLine)
	{
		return false;
	}

	private bool SkipEmptyAndCommentedLines(ref int pos)
	{
		return false;
	}

	private void DoSkipEmptyAndCommentedLines(ref int pos)
	{
	}

	private bool SkipWhiteSpaces(ref int pos)
	{
		return false;
	}

	private bool SkipToNextLine(ref int pos)
	{
		return false;
	}

	private void HandleParseError(MalformedCsvException error, ref int pos)
	{
	}

	private string GetExceptionMessage(string info)
	{
		return null;
	}

	private string GetCSVParseType()
	{
		return null;
	}

	private string HandleMissingField(string value, int fieldIndex, ref int currentPosition)
	{
		return null;
	}

	public RecordEnumerator GetEnumerator()
	{
		return default(RecordEnumerator);
	}

	IEnumerator<string[]> IEnumerable<string[]>.GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	protected virtual void OnDisposed(EventArgs e)
	{
	}

	protected void CheckDisposed()
	{
	}

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	~CsvReader()
	{
	}
}
