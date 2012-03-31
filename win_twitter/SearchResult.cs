using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterSearch
{
	/// <summary>
	/// The following represents the data object for 
	/// the fields I am interested in tracking. 
	/// </summary>
	public class SearchResult
	{
		//id_str
		public string ID; 

		//maps to from_user_id_str
		public string UserID;

		//profile_image_url
		public string ProfileURL; 

		//from_user
		public string UserName;

		//created_at
		public string Date;

		//text
		public string Text; 
	}
}
