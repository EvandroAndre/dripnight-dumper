using message;

namespace GCommon;

public class ReplicationDataPool
{
	protected ReplicationData[] m_Datas;

	protected int m_MaxVarCount;

	protected object[] m_Handlers;

	public ReplicationDataPool(int maxVarCount)
	{
	}

	public void AppendSize(int appendSize)
	{
	}

	public void Clear()
	{
	}

	public void SyncReplicationMsg(DHIEKICKHPN entityMsg)
	{
	}

	public void SyncReplicationData(FastBinaryReader reader)
	{
	}

	private bool CheckVarID(uint varID)
	{
		return false;
	}

	private bool CheckExistence(uint varID)
	{
		return false;
	}

	public bool AddData(uint varID, sbyte initValue, DataChangedHanlder<sbyte> onChange = null)
	{
		return false;
	}

	public bool AddData(uint varID, byte initValue, DataChangedHanlder<byte> onChange = null)
	{
		return false;
	}

	public bool AddData(uint varID, short initValue, DataChangedHanlder<short> onChange = null)
	{
		return false;
	}

	public bool AddData(uint varID, ushort initValue, DataChangedHanlder<ushort> onChange = null)
	{
		return false;
	}

	public bool AddData(uint varID, int initValue, DataChangedHanlder<int> onChange = null)
	{
		return false;
	}

	public bool AddData(uint varID, uint initValue, DataChangedHanlder<uint> onChange = null)
	{
		return false;
	}

	public bool AddData(uint varID, long initValue, DataChangedHanlder<long> onChange = null)
	{
		return false;
	}

	public bool AddData(uint varID, ulong initValue, DataChangedHanlder<ulong> onChange = null)
	{
		return false;
	}

	public bool AddData(uint varID, float initValue, DataChangedHanlder<float> onChange = null)
	{
		return false;
	}

	public bool AddData(uint varID, bool initValue, DataChangedHanlder<bool> onChange = null)
	{
		return false;
	}

	public void RegisterDataChangedHandlerInt8(uint varID, DataChangedHanlder<sbyte> onChange)
	{
	}

	public void RegisterDataChangedHandlerUInt8(uint varID, DataChangedHanlder<byte> onChange)
	{
	}

	public void RegisterDataChangedHandlerInt16(uint varID, DataChangedHanlder<short> onChange)
	{
	}

	public void RegisterDataChangedHandlerUInt16(uint varID, DataChangedHanlder<ushort> onChange)
	{
	}

	public void RegisterDataChangedHandlerInt32(uint varID, DataChangedHanlder<int> onChange)
	{
	}

	public void RegisterDataChangedHandlerUInt32(uint varID, DataChangedHanlder<uint> onChange)
	{
	}

	public void RegisterDataChangedHandlerInt64(uint varID, DataChangedHanlder<long> onChange)
	{
	}

	public void RegisterDataChangedHandlerUInt64(uint varID, DataChangedHanlder<ulong> onChange)
	{
	}

	public void RegisterDataChangedHandlerFloat32(uint varID, DataChangedHanlder<float> onChange)
	{
	}

	public void RegisterDataChangedHandlerBool(uint varID, DataChangedHanlder<bool> onChange)
	{
	}

	public sbyte GetDataInt8(uint varID)
	{
		return 0;
	}

	public byte GetDataUInt8(uint varID)
	{
		return 0;
	}

	public short GetDataInt16(uint varID)
	{
		return 0;
	}

	public ushort GetDataUInt16(uint varID)
	{
		return 0;
	}

	public int GetDataInt32(uint varID)
	{
		return 0;
	}

	public uint GetDataUInt32(uint varID)
	{
		return 0u;
	}

	public long GetDataInt64(uint varID)
	{
		return 0L;
	}

	public ulong GetDataUInt64(uint varID)
	{
		return 0uL;
	}

	public bool GetDataBool(uint varID)
	{
		return false;
	}

	public float GetDataFloat32(uint varID)
	{
		return 0f;
	}

	public bool SetData(uint varID, byte newValue)
	{
		return false;
	}

	public bool SetData(uint varID, sbyte newValue)
	{
		return false;
	}

	public bool SetData(uint varID, short newValue)
	{
		return false;
	}

	public bool SetData(uint varID, ushort newValue)
	{
		return false;
	}

	public bool SetData(uint varID, int newValue)
	{
		return false;
	}

	public bool SetData(uint varID, uint newValue)
	{
		return false;
	}

	public bool SetData(uint varID, long newValue)
	{
		return false;
	}

	public bool SetData(uint varID, ulong newValue)
	{
		return false;
	}

	public bool SetData(uint varID, bool newValue)
	{
		return false;
	}

	public bool SetData(uint varID, float newValue)
	{
		return false;
	}
}
