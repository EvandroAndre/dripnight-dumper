using System.Collections.Generic;

namespace proto;

public class CSSetSparkCustomInfoReq
{
	public uint temper;

	public uint[] appearance_item_ids;

	public bool show_spark_in_lobby;

	public bool show_collab_spark;

	public uint appearance_stage;

	public List<SparkStageAppearance> stage_appearance_items;

	public bool is_first_choose_temper;

	public bool is_system_choose_temper;

	public uint color_id;
}
