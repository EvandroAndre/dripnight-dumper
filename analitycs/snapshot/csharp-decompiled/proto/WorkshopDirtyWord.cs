using System.Collections.Generic;

namespace proto;

public class WorkshopDirtyWord
{
	public string str_id;

	public string block_id;

	public EWorkshop.WordFilterType word_filter_type;

	public List<string> dirty_words;

	public List<string> ban_reasons;

	public string model_result;

	public List<WorkshopDirtyWordDetail> dirty_word_list;

	public uint[] toxic_idx;

	public List<string> toxic_reasons;
}
