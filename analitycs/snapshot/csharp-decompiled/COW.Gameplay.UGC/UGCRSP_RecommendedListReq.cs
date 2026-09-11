namespace COW.Gameplay.UGC;

public class UGCRSP_RecommendedListReq
{
	private uint _003Ctype_id_003Ek__BackingField;

	private uint _003Cevent_id_003Ek__BackingField;

	public uint type_id
	{
		get
		{
			return _003Ctype_id_003Ek__BackingField;
		}
		set
		{
			_003Ctype_id_003Ek__BackingField = value;
		}
	}

	public uint event_id
	{
		get
		{
			return _003Cevent_id_003Ek__BackingField;
		}
		set
		{
			_003Cevent_id_003Ek__BackingField = value;
		}
	}
}
