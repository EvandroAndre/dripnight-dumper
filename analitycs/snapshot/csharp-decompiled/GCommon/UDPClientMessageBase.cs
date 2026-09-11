using System;
using System.Collections.Generic;
using System.Reflection;

namespace GCommon;

public class UDPClientMessageBase : IClientMessageSerializer
{
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public Type type;

		internal UDPClientMessageBase _003CUnSerializeMessage_003Eb__1()
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_1
	{
		public ConstructorInfo ctor;

		internal UDPClientMessageBase _003CUnSerializeMessage_003Eb__0()
		{
			return null;
		}
	}

	private static Dictionary<Type, Queue<UDPClientMessageBase>> CachedMessage;

	private static Dictionary<Type, Func<UDPClientMessageBase>> ConstructorCache;

	public const uint USER_MESSAGE_ID_START = 100u;

	private bool m_GetFromPool;

	public bool GetFromPool
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static Dictionary<Type, Queue<UDPClientMessageBase>> GetMessagePool()
	{
		return null;
	}

	public static UDPClientMessageBase UnSerializeMessage(FastBinaryReader reader, Type type)
	{
		return null;
	}

	public static void ReturnToCache(UDPClientMessageBase msg)
	{
	}

	protected void WriteString(FastBinaryWriter writer, string value)
	{
	}

	protected string ReadString(FastBinaryReader reader)
	{
		return null;
	}

	protected sbyte ReadSByte(FastBinaryReader reader)
	{
		return 0;
	}

	protected short ReadInt16(FastBinaryReader reader)
	{
		return 0;
	}

	protected int ReadInt32(FastBinaryReader reader)
	{
		return 0;
	}

	protected long ReadInt64(FastBinaryReader reader)
	{
		return 0L;
	}

	protected byte ReadByte(FastBinaryReader reader)
	{
		return 0;
	}

	protected ushort ReadUInt16(FastBinaryReader reader)
	{
		return 0;
	}

	protected uint ReadUInt32(FastBinaryReader reader)
	{
		return 0u;
	}

	protected ulong ReadUInt64(FastBinaryReader reader)
	{
		return 0uL;
	}

	protected float ReadSingle(FastBinaryReader reader)
	{
		return 0f;
	}

	protected bool ReadBoolean(FastBinaryReader reader)
	{
		return false;
	}

	public virtual void Serialize(FastBinaryWriter writer)
	{
	}

	public virtual void UnSerialize(FastBinaryReader reader)
	{
	}

	public virtual bool CanCache()
	{
		return false;
	}

	public virtual void Recycle()
	{
	}
}
