using System.IO;
using Unity.Collections;

namespace GCommon;

public class NativeReadStream : Stream
{
	private unsafe readonly byte* _dataPtr;

	private readonly long _length;

	private long _position;

	public override bool CanRead => false;

	public override bool CanSeek => false;

	public override bool CanWrite => false;

	public override long Length => 0L;

	public override long Position
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public NativeReadStream(NativeArray<byte> nativeArray)
	{
	}

	public unsafe byte* GetBufferPtr()
	{
		return null;
	}

	public override int ReadByte()
	{
		return 0;
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		return 0;
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		return 0L;
	}

	public override void SetLength(long value)
	{
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
	}

	public override void Flush()
	{
	}
}
