using System;
using System.Collections.Generic;
using proto;

namespace COW;

public class ActivityGroupDesc
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<ClientActivityDesc> _003C_003E9__44_0;

		internal int _003C_002Ector_003Eb__44_0(ClientActivityDesc a, ClientActivityDesc b)
		{
			return 0;
		}
	}

	public uint group_id;

	public string act_title;

	public string act_text;

	public uint act_style;

	public string image_url;

	public string image_url_for_lobby;

	public string image_url_for_top_up;

	public uint activity_type;

	public uint activity_id;

	public uint sort_id;

	public uint is_process_show;

	public uint act_tag;

	public uint go_pos;

	public ulong show_time;

	public ulong start_time;

	public ulong end_time;

	public uint cdt_value;

	public string cfg_starttime;

	public string cfg_endtime;

	public uint table_type;

	public EActivity.SubType sub_type;

	public ulong[] hint_reset_times;

	public AwardDesc award_model;

	public List<ClientActivityDesc> activityList;

	public uint recharge_show;

	public bool is_stay_after_finished;

	public bool is_hide_end_time;

	public long show_end_time;

	public uint show_end_time_style;

	public long real_end_time;

	private Dictionary<uint, List<ClientActivityDesc>> _003CThirdTabDict_003Ek__BackingField;

	public bool awarded;

	public bool IsActivityOpenByFriendReunion;

	public Dictionary<uint, List<ClientActivityDesc>> ThirdTabDict
	{
		get
		{
			return _003CThirdTabDict_003Ek__BackingField;
		}
		private set
		{
			_003CThirdTabDict_003Ek__BackingField = value;
		}
	}

	public bool AwardedAndHide => false;

	public bool IsFriendReunionActivity => false;

	public bool IsFriendReunionActivityBigEvent => false;

	public bool IsActivityOpen => false;

	public ActivityGroupDesc(List<ClientActivityDesc> actList)
	{
	}
}
