namespace COW.Gameplay.UGC;

public class UGCRSP_PersonalInfoResInner
{
	private ulong _003Cbuy_count_003Ek__BackingField;

	private ulong _003Clike_count_003Ek__BackingField;

	private uint _003Cpublished_count_003Ek__BackingField;

	public ulong buy_count
	{
		get
		{
			return _003Cbuy_count_003Ek__BackingField;
		}
		set
		{
			_003Cbuy_count_003Ek__BackingField = value;
		}
	}

	public ulong like_count
	{
		get
		{
			return _003Clike_count_003Ek__BackingField;
		}
		set
		{
			_003Clike_count_003Ek__BackingField = value;
		}
	}

	public uint published_count
	{
		get
		{
			return _003Cpublished_count_003Ek__BackingField;
		}
		set
		{
			_003Cpublished_count_003Ek__BackingField = value;
		}
	}
}
