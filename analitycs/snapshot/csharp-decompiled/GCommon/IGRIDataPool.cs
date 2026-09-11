namespace GCommon;

public interface IGRIDataPool : IRepDataPool
{
	void AppendSize(int appendSize);

	void RegisterDataChangedHandlerInt8(uint varID, DataChangedHanlder<sbyte> onChange);

	void RegisterDataChangedHandlerUInt8(uint varID, DataChangedHanlder<byte> onChange);

	void RegisterDataChangedHandlerInt16(uint varID, DataChangedHanlder<short> onChange);

	void RegisterDataChangedHandlerUInt16(uint varID, DataChangedHanlder<ushort> onChange);

	void RegisterDataChangedHandlerInt32(uint varID, DataChangedHanlder<int> onChange);

	void RegisterDataChangedHandlerUInt32(uint varID, DataChangedHanlder<uint> onChange);

	void RegisterDataChangedHandlerInt64(uint varID, DataChangedHanlder<long> onChange);

	void RegisterDataChangedHandlerUInt64(uint varID, DataChangedHanlder<ulong> onChange);

	void RegisterDataChangedHandlerFloat32(uint varID, DataChangedHanlder<float> onChange);

	void RegisterDataChangedHandlerBool(uint varID, DataChangedHanlder<bool> onChange);
}
