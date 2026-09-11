using System.Collections.Generic;

namespace proto;

public class CSFilterMessageRes
{
	public bool is_dirty;

	public List<string> dirty_words;

	public string filtered_text;
}
