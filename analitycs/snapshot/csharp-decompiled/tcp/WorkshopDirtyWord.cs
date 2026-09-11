using System.Collections.Generic;

namespace tcp;

public class WorkshopDirtyWord
{
	public string str_id;

	public string block_id;

	public uint word_filter_type;

	public List<string> dirty_words;

	public List<string> ban_reasons;

	public uint[] toxic_idx;

	public List<string> toxic_reasons;
}
