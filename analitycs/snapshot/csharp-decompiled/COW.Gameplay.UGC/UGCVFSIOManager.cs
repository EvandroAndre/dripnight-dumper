using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCVFSIOManager : IDisposable
{
	public class AsyncRequestInfo
	{
		private long _003CRequestId_003Ek__BackingField;

		private string _003CFilePath_003Ek__BackingField;

		private long _003CPosition_003Ek__BackingField;

		private int _003CLength_003Ek__BackingField;

		private Action<byte[], int, int, Exception> _003CCallback_003Ek__BackingField;

		private DateTime _003CCreateTime_003Ek__BackingField;

		private byte[] _003CBuffer_003Ek__BackingField;

		private int _003CBufferOffset_003Ek__BackingField;

		private FileStream _003CFileStream_003Ek__BackingField;

		private bool _003CIsCompleted_003Ek__BackingField;

		private byte[] _003CResultData_003Ek__BackingField;

		private int _003CResultOffset_003Ek__BackingField;

		private Exception _003CException_003Ek__BackingField;

		public long RequestId
		{
			get
			{
				return _003CRequestId_003Ek__BackingField;
			}
			set
			{
				_003CRequestId_003Ek__BackingField = value;
			}
		}

		public string FilePath
		{
			get
			{
				return _003CFilePath_003Ek__BackingField;
			}
			set
			{
				_003CFilePath_003Ek__BackingField = value;
			}
		}

		public long Position
		{
			get
			{
				return _003CPosition_003Ek__BackingField;
			}
			set
			{
				_003CPosition_003Ek__BackingField = value;
			}
		}

		public int Length
		{
			get
			{
				return _003CLength_003Ek__BackingField;
			}
			set
			{
				_003CLength_003Ek__BackingField = value;
			}
		}

		public Action<byte[], int, int, Exception> Callback
		{
			get
			{
				return _003CCallback_003Ek__BackingField;
			}
			set
			{
				_003CCallback_003Ek__BackingField = value;
			}
		}

		public DateTime CreateTime
		{
			get
			{
				return _003CCreateTime_003Ek__BackingField;
			}
			set
			{
				_003CCreateTime_003Ek__BackingField = value;
			}
		}

		public byte[] Buffer
		{
			get
			{
				return _003CBuffer_003Ek__BackingField;
			}
			set
			{
				_003CBuffer_003Ek__BackingField = value;
			}
		}

		public int BufferOffset
		{
			get
			{
				return _003CBufferOffset_003Ek__BackingField;
			}
			set
			{
				_003CBufferOffset_003Ek__BackingField = value;
			}
		}

		public FileStream FileStream
		{
			get
			{
				return _003CFileStream_003Ek__BackingField;
			}
			set
			{
				_003CFileStream_003Ek__BackingField = value;
			}
		}

		public bool IsCompleted
		{
			get
			{
				return _003CIsCompleted_003Ek__BackingField;
			}
			set
			{
				_003CIsCompleted_003Ek__BackingField = value;
			}
		}

		public byte[] ResultData
		{
			get
			{
				return _003CResultData_003Ek__BackingField;
			}
			set
			{
				_003CResultData_003Ek__BackingField = value;
			}
		}

		public int ResultOffset
		{
			get
			{
				return _003CResultOffset_003Ek__BackingField;
			}
			set
			{
				_003CResultOffset_003Ek__BackingField = value;
			}
		}

		public Exception Exception
		{
			get
			{
				return _003CException_003Ek__BackingField;
			}
			set
			{
				_003CException_003Ek__BackingField = value;
			}
		}
	}

	private class FileStreamInfo
	{
		private FileStream _003CStream_003Ek__BackingField;

		private DateTime _003CLastAccessTime_003Ek__BackingField;

		private int _003CAccessCount_003Ek__BackingField;

		private FileAccess _003CAccessMode_003Ek__BackingField;

		public Queue<AsyncRequestInfo> PendingRequests;

		private bool _003CIsReading_003Ek__BackingField;

		public readonly object QueueLock;

		public FileStream Stream
		{
			get
			{
				return _003CStream_003Ek__BackingField;
			}
			set
			{
				_003CStream_003Ek__BackingField = value;
			}
		}

		public DateTime LastAccessTime
		{
			get
			{
				return _003CLastAccessTime_003Ek__BackingField;
			}
			set
			{
				_003CLastAccessTime_003Ek__BackingField = value;
			}
		}

		public int AccessCount
		{
			get
			{
				return _003CAccessCount_003Ek__BackingField;
			}
			set
			{
				_003CAccessCount_003Ek__BackingField = value;
			}
		}

		public FileAccess AccessMode
		{
			get
			{
				return _003CAccessMode_003Ek__BackingField;
			}
			set
			{
				_003CAccessMode_003Ek__BackingField = value;
			}
		}

		public bool IsReading
		{
			get
			{
				return _003CIsReading_003Ek__BackingField;
			}
			set
			{
				_003CIsReading_003Ek__BackingField = value;
			}
		}
	}

	public class VFSIOManagerStats
	{
		private int _003COpenStreamCount_003Ek__BackingField;

		private int _003CMaxOpenStreams_003Ek__BackingField;

		private long _003CCacheSize_003Ek__BackingField;

		private long _003CMaxCacheSize_003Ek__BackingField;

		private int _003CCachedItemsCount_003Ek__BackingField;

		private int _003CAsyncRequestCount_003Ek__BackingField;

		private int _003CPendingCallbackCount_003Ek__BackingField;

		private int _003CPendingQueueRequests_003Ek__BackingField;

		private int _003CActiveReadingStreams_003Ek__BackingField;

		public int OpenStreamCount
		{
			get
			{
				return _003COpenStreamCount_003Ek__BackingField;
			}
			set
			{
				_003COpenStreamCount_003Ek__BackingField = value;
			}
		}

		public int MaxOpenStreams
		{
			get
			{
				return _003CMaxOpenStreams_003Ek__BackingField;
			}
			set
			{
				_003CMaxOpenStreams_003Ek__BackingField = value;
			}
		}

		public long CacheSize
		{
			get
			{
				return _003CCacheSize_003Ek__BackingField;
			}
			set
			{
				_003CCacheSize_003Ek__BackingField = value;
			}
		}

		public long MaxCacheSize
		{
			get
			{
				return _003CMaxCacheSize_003Ek__BackingField;
			}
			set
			{
				_003CMaxCacheSize_003Ek__BackingField = value;
			}
		}

		public int CachedItemsCount
		{
			get
			{
				return _003CCachedItemsCount_003Ek__BackingField;
			}
			set
			{
				_003CCachedItemsCount_003Ek__BackingField = value;
			}
		}

		public int AsyncRequestCount
		{
			get
			{
				return _003CAsyncRequestCount_003Ek__BackingField;
			}
			set
			{
				_003CAsyncRequestCount_003Ek__BackingField = value;
			}
		}

		public int PendingCallbackCount
		{
			get
			{
				return _003CPendingCallbackCount_003Ek__BackingField;
			}
			set
			{
				_003CPendingCallbackCount_003Ek__BackingField = value;
			}
		}

		public int PendingQueueRequests
		{
			get
			{
				return _003CPendingQueueRequests_003Ek__BackingField;
			}
			set
			{
				_003CPendingQueueRequests_003Ek__BackingField = value;
			}
		}

		public int ActiveReadingStreams
		{
			get
			{
				return _003CActiveReadingStreams_003Ek__BackingField;
			}
			set
			{
				_003CActiveReadingStreams_003Ek__BackingField = value;
			}
		}
	}

	private sealed class _003C_003Ec__DisplayClass38_0
	{
		public UGCVFSIOManager _003C_003E4__this;

		public AsyncRequestInfo requestInfo;

		internal void _003CStartAsyncRead_003Eb__0(IAsyncResult asyncResult)
		{
		}
	}

	private static UGCVFSIOManager _instance;

	private static GameObject _fileMono;

	private readonly Dictionary<string, FileStreamInfo> _fileStreams;

	private readonly Queue<string> _fileStreamQueue;

	private readonly object _lockObject;

	private readonly int _maxOpenStreams;

	private readonly int _maxCacheSize;

	private long _currentCacheSize;

	private bool _disposed;

	private readonly Dictionary<long, AsyncRequestInfo> _asyncRequests;

	private readonly object _asyncRequestLock;

	private long _nextRequestId;

	private List<AsyncRequestInfo> _completedRequestsList;

	private List<AsyncRequestInfo> _swapBufferList;

	private readonly object _completedRequestsLock;

	public bool IsAsyncRead;

	public static UGCVFSIOManager Instance => null;

	public bool IsDisposed => false;

	public static void Clean()
	{
	}

	public static void Initialize(int maxOpenStreams = 10, int maxCacheSizeMB = 100, bool isAsyncRead = true)
	{
	}

	public static void Release()
	{
	}

	private UGCVFSIOManager(int maxOpenStreams = 10, int maxCacheSizeMB = 100, bool isAsyncRead = true)
	{
	}

	public void Update()
	{
	}

	public void ReadResourceAsync(string filePath, long position, int length, byte[] buffer, int bufferOffset, Action<byte[], int, int, Exception> callback)
	{
	}

	public void ReadResourceAsync(string filePath, long position, int length, Action<byte[], int, int, Exception> callback)
	{
	}

	public byte[] ReadResource(string filePath, long position, int length, out int offset)
	{
		offset = default(int);
		return null;
	}

	public bool WriteResource(string filePath, long position, byte[] data, int offsetData = 0, int lengthData = -1)
	{
		return false;
	}

	public void ManageMemoryUsage()
	{
	}

	private void CleanupExpiredAsyncRequests()
	{
	}

	public int GetAsyncRequestCount()
	{
		return 0;
	}

	public bool CancelAsyncRequest(long requestId)
	{
		return false;
	}

	public VFSIOManagerStats GetStats()
	{
		return null;
	}

	private FileStream GetOrCreateFileStream(string filePath, bool needWrite = false)
	{
		return null;
	}

	private void CloseFileStream(string filePath)
	{
	}

	public void CloseFile(string filePath)
	{
	}

	public bool CloseAndOverwriteFile(string srcFilePath, string overwriteFilePath)
	{
		return false;
	}

	private long GenerateRequestId()
	{
		return 0L;
	}

	private void StartAsyncRead(AsyncRequestInfo requestInfo)
	{
	}

	private void HandleAsyncReadError(AsyncRequestInfo requestInfo, Exception ex)
	{
	}

	private void ProcessNextRequestInQueue(string filePath)
	{
	}

	private void HandleAsyncReadComplete(long requestId, IAsyncResult asyncResult)
	{
	}

	public void Dispose()
	{
	}
}
