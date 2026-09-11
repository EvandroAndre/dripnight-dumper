using System;

namespace COW.Gameplay.UGC;

public class UGCVFSBinarySerializer : IDisposable
{
	private byte[] _data;

	private int _position;

	private bool _isReading;

	private bool _disposed;

	public int Position
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Length => 0;

	public bool IsReading => false;

	public bool IsWriting => false;

	public bool EndOfData => false;

	public UGCVFSBinarySerializer(byte[] data, int startPosition = 0)
	{
	}

	public UGCVFSBinarySerializer(int initialCapacity = 1024)
	{
	}

	public void SetData(byte[] data, bool isReading, int startPosition = 0)
	{
	}

	public void SerializeInt64(ref long value)
	{
	}

	public void SerializeUInt64(ref ulong value)
	{
	}

	public void SerializeInt32(ref int value)
	{
	}

	public void SerializeUInt32(ref uint value)
	{
	}

	public void SerializeInt16(ref short value)
	{
	}

	public void SerializeUInt16(ref ushort value)
	{
	}

	public void SerializeByte(ref byte value)
	{
	}

	public void SerializeSByte(ref sbyte value)
	{
	}

	public void SerializeBoolean(ref bool value)
	{
	}

	public void SerializeSingle(ref float value)
	{
	}

	public void SerializeDouble(ref double value)
	{
	}

	public int SerializeString(ref string value, int length = 0)
	{
		return 0;
	}

	public int SerializeStringFixedLength(ref string value, int fixedLength)
	{
		return 0;
	}

	public void SerializeBytes(ref byte[] value, int length = 0)
	{
	}

	public byte[] GetData()
	{
		return null;
	}

	public byte[] GetBuffer()
	{
		return null;
	}

	public void Skip(int count)
	{
	}

	private void CheckDisposed()
	{
	}

	private void CheckBounds(int bytesToRead)
	{
	}

	private void EnsureCapacity(int additionalBytes)
	{
	}

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}
}
