namespace COW.Gameplay.UGC.BlockEdit;

public class TagSerializeContent
{
	public int tag;

	public bool Serialize<T>(IBlockSerializer<T> serializer, T serializedData) where T : class
	{
		return false;
	}
}
