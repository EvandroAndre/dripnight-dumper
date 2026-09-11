namespace COW.Gameplay.UGC;

public class UGCVFSFileBaseInfo
{
	public string _UUID;

	public uint Type;

	public UGCVFSFileFlags Flags;

	public long Position;

	public uint Length;

	public int UnZipLength;

	public uint SpaceLength;

	public string _Path;

	public UGCVFSIndexChunk CacheOwnerChunk;

	public uint CacheUUIDBytes;

	public uint CachePathBytes;

	private byte[] _003CData_003Ek__BackingField;

	public string UUID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string Path
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static int PathMaxLength => 0;

	public uint NeedSpace => 0u;

	public byte[] Data
	{
		get
		{
			return _003CData_003Ek__BackingField;
		}
		set
		{
			_003CData_003Ek__BackingField = value;
		}
	}

	public bool IsDeleted
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsCompressed => false;

	public void CopyFrom(UGCVFSFileBaseInfo other)
	{
	}

	public void RefreshUUIDPathBytes()
	{
	}

	public void Serialize(UGCVFSBinarySerializer serializer)
	{
	}
}
