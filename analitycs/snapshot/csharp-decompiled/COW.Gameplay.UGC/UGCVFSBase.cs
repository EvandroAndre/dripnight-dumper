using System;
using System.Collections.Generic;

namespace COW.Gameplay.UGC;

public abstract class UGCVFSBase : IDisposable
{
	protected UGCVFSHeader _header;

	protected bool _isHeaderDirty;

	protected List<UGCVFSIndexChunk> _indexChunks;

	protected Dictionary<string, UGCVFSFileBaseInfo> _resourceIndex;

	protected bool _disposed;

	protected readonly object _lockObject;

	protected bool _writeEnabled;

	protected Dictionary<string, UGCVFSFileBaseInfo> _dirtyResources;

	protected List<UGCVFSIndexChunk> _dirtyIndexChunks;

	protected UGCVFSBinarySerializer _serializer;

	private bool _003CIsLoaded_003Ek__BackingField;

	public bool IsLoaded
	{
		get
		{
			return _003CIsLoaded_003Ek__BackingField;
		}
		protected set
		{
			_003CIsLoaded_003Ek__BackingField = value;
		}
	}

	public int ResourceCount => 0;

	public bool WriteEnabled => false;

	public int DirtyResourceCount => 0;

	protected abstract string GetDataIdentifier();

	protected abstract void ReadHeader();

	protected abstract UGCVFSIndexChunk ReadIndexChunk(long position);

	protected abstract bool WriteDataToFile(long position, byte[] data, int offsetData = 0, int lengthData = -1);

	protected abstract long GetEndOfFilePosition();

	protected abstract bool WriteVFSHeader();

	public virtual void ReadResourceAsync(string resourceUUID, Action<byte[], Exception> callback)
	{
	}

	public virtual byte[] ReadResource(string resourceUUID)
	{
		return null;
	}

	public virtual bool DeleteResource(string resourceUUID)
	{
		return false;
	}

	public virtual bool ModifyResourcePath(string resourceUUID, string newPath)
	{
		return false;
	}

	public virtual List<string> GetAllResourceUUIDs()
	{
		return null;
	}

	public virtual Dictionary<string, UGCVFSFileBaseInfo> GetAllResourceInfo()
	{
		return null;
	}

	public virtual bool ResourceExists(string resourceUUID)
	{
		return false;
	}

	public virtual UGCVFSFileBaseInfo GetResourceInfo(string resourceUUID)
	{
		return null;
	}

	public virtual string GetResourcePathByUUID(string resourceUUID)
	{
		return null;
	}

	public virtual UGCVFSFileBaseInfo GetResourceByUUID(string resourceUUID)
	{
		return null;
	}

	public virtual string GetResourceUUIDByPath(string resourcePath)
	{
		return null;
	}

	public virtual void EnableWrite()
	{
	}

	public virtual string NewResource(string resourcePath, uint resourceType, byte[] data, bool compress = false)
	{
		return null;
	}

	public virtual bool ModifyResource(string resourceUUID, byte[] newData, bool compress = false)
	{
		return false;
	}

	protected abstract void ReadResourceDataAsync(UGCVFSFileBaseInfo resourceInfo, Action<byte[], Exception> callback);

	protected abstract byte[] ReadResourceData(UGCVFSFileBaseInfo resourceInfo);

	protected bool IsValidVFSFile()
	{
		return false;
	}

	protected void ReadIndexChunks()
	{
	}

	protected void BuildResourceIndex()
	{
	}

	protected byte[] CompressData(byte[] inputBytes)
	{
		return null;
	}

	protected byte[] DecompressData(byte[] compressedData, int offset, int length, int unzipSize)
	{
		return null;
	}

	protected UGCVFSHeader ReadVFSHeader(byte[] data)
	{
		return null;
	}

	protected UGCVFSChunkHeader ReadIndexChunkHeader(byte[] data, int offset)
	{
		return null;
	}

	protected byte[] getWriteBuffer(uint needSpace)
	{
		return null;
	}

	public virtual void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}
}
