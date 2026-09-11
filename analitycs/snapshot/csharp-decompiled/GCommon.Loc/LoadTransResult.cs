namespace GCommon.Loc;

public class LoadTransResult
{
	public bool For32bitOnly;

	public int MaxChars;

	public int MaxBytes;

	public int OffsetBegin;

	public ushort[] TransSize;

	public uint[] TransSizeOffsets;

	public LoadTransResult(int cnt, bool allocSize)
	{
	}
}
