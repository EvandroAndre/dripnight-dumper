namespace GCommon.Loc;

internal interface IdLoader
{
	void Load(byte[] bytes, LocData dst, bool needOverwrite);
}
