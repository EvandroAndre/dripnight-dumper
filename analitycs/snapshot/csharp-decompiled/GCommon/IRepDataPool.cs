using message;

namespace GCommon;

public interface IRepDataPool
{
	bool AddData(uint varID, sbyte initValue, DataChangedHanlder<sbyte> onChange = null);

	bool AddData(uint varID, byte initValue, DataChangedHanlder<byte> onChange = null);

	bool AddData(uint varID, short initValue, DataChangedHanlder<short> onChange = null);

	bool AddData(uint varID, ushort initValue, DataChangedHanlder<ushort> onChange = null);

	bool AddData(uint varID, int initValue, DataChangedHanlder<int> onChange = null);

	bool AddData(uint varID, uint initValue, DataChangedHanlder<uint> onChange = null);

	bool AddData(uint varID, long initValue, DataChangedHanlder<long> onChange = null);

	bool AddData(uint varID, ulong initValue, DataChangedHanlder<ulong> onChange = null);

	bool AddData(uint varID, float initValue, DataChangedHanlder<float> onChange = null);

	bool AddData(uint varID, bool initValue, DataChangedHanlder<bool> onChange = null);

	sbyte GetDataInt8(uint varID);

	byte GetDataUInt8(uint varID);

	short GetDataInt16(uint varID);

	ushort GetDataUInt16(uint varID);

	int GetDataInt32(uint varID);

	uint GetDataUInt32(uint varID);

	long GetDataInt64(uint varID);

	ulong GetDataUInt64(uint varID);

	bool GetDataBool(uint varID);

	float GetDataFloat32(uint varID);

	bool SetData(uint varID, byte newValue);

	bool SetData(uint varID, sbyte newValue);

	bool SetData(uint varID, short newValue);

	bool SetData(uint varID, ushort newValue);

	bool SetData(uint varID, int newValue);

	bool SetData(uint varID, uint newValue);

	bool SetData(uint varID, long newValue);

	bool SetData(uint varID, ulong newValue);

	bool SetData(uint varID, bool newValue);

	bool SetData(uint varID, float newValue);

	void SyncReplicationMsg(DHIEKICKHPN entityMsg);

	void SyncReplicationData(FastBinaryReader reader);

	void Clear();
}
