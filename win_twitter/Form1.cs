using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Jayrock.Json;
using System.Web;

namespace TwitterSearch
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		#region Handlers
		protected virtual void HandleSearchClicked(object sender, EventArgs e)
		{
			try 
			{
                if (VerifyQuery())
                {
                    if (textBox1.Text != mLastQuery)
                    {
                        CurrentPage = 1;
                    }

                    /*
                    mCurrentKVP = new KeyValuePair<string, int>(
                        textBox1.Text,
                        CurrentPage);
                    if (mPreviousSearches.ContainsKey(mCurrentKVP))
                    {
                        mCurrentResults = mPreviousSearches[mCurrentKVP];
                    }
                    else
                    {
                        mCurrentResults = GetResults(textBox1.Text);
                        mPreviousSearches[mCurrentKVP] = mCurrentResults;
                    }
                     */
                    mCurrentResults = GetResults(textBox1.Text); 


                    mLastQuery = mCurrentKVP.Key;
                    PopulateGrid();
                    mPgBox.Enabled = true;
                    mGoToPageBtn.Enabled = true;
                    mExportBtn.Enabled = true;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("An unexpected error has occurred." +
                    ex.ToString());
            }
		}


        protected virtual bool VerifyQuery()
        {
            if (
                mBeforeDate.Enabled && mAfterDate.Enabled && 
                mBeforeDate.Value <= mAfterDate.Value
                )
            {
                MessageBox.Show("Date range is not valid.");
                return false; 
            }
            return true; 
        }

		private void HandleExport(object sender, EventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.DefaultExt = "csv";

			dialog.Filter = "CSV file (*.csv)|";


			if (dialog.ShowDialog(this) == DialogResult.OK)
			{
				try
				{
					using (System.IO.StreamWriter file = new StreamWriter(dialog.FileName))
					{
						file.WriteLine("Search query: " + mLastQuery);
						file.WriteLine("Page: " + CurrentPage.ToString());
						file.WriteLine("URL used: " + mCurrentURL);
						file.WriteLine("Date of search: " + DateTime.Now.ToString());
						file.WriteLine("");
						file.WriteLine("");
						file.WriteLine("Tweet,Date,Username");
						foreach (SearchResult result in mCurrentResults)
						{
							file.WriteLine(String.Join(",",
								new String[] {
								Csv.Escape(result.Text),
								Csv.Escape(result.Date), 
								Csv.Escape(result.UserName)
							}
								));
						}
					}

				}
				catch (IOException) { }
			}
		}

        private void HandleBeforeCheckChanged(object sender, EventArgs e)
        {
            mBeforeDate.Enabled = mTweetsBeforeChk.Checked;
        }

        private void HandleAfterCheckChanged(object sender, EventArgs e)
        {
            mAfterDate.Enabled = mTweetsAfterChk.Checked;
        }
		#endregion

		#region Get Results
		private List<SearchResult> GetResults(string queryWord)
		{
			List<SearchResult> results = new List<SearchResult>();

			string text = CreateConnectionAndGetResult(queryWord);

			JsonTextReader reader = new JsonTextReader(new StringReader(text));
			InitializeLoop(reader);
			while (reader.Read())
			{
				// At this point we should be at the user ID. 
				SearchResult result = new SearchResult();
				result.UserID = reader.Text;

				// Now read the rest of the object.
				while (ParseJSON(reader, result))
				{
					if (!reader.Read())
						break;
				}
				// We are finished with this object. Add it to the list.
				results.Add(result);
			}

			return results; 
		}

		private string CreateConnectionAndGetResult(string queryWord)
		{
            mCurrentURL = @"http://search.twitter.com/search.json?q=" +
                HttpUtility.UrlEncode(queryWord) +
                "&rpp=100" + 
				"&page=" + CurrentPage.ToString();

            if (mBeforeDate.Enabled)
            {
                mCurrentURL += "&until=" +
                    String.Join("-",
                    new string[] {
                    mBeforeDate.Value.Year.ToString(),
                    CleanDate(mBeforeDate.Value.Month),
                    CleanDate(mBeforeDate.Value.Day)
                    });
            }

            if (mAfterDate.Enabled)
            {
                mCurrentURL += "&since=" +
                    String.Join("-",
                    new string[] {
                    mAfterDate.Value.Year.ToString(),
                    CleanDate(mAfterDate.Value.Month),
                    CleanDate(mAfterDate.Value.Day)
                    });
            }


			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(mCurrentURL);
			httpWebRequest.Method = WebRequestMethods.Http.Get;
			httpWebRequest.Accept = "application/json";
			WebResponse response = (HttpWebResponse)httpWebRequest.GetResponse();

			string text = "";
			using (StreamReader sr = new StreamReader(response.GetResponseStream()))
			{
				text = sr.ReadToEnd();
			}
			return text;
		}

        protected string CleanDate(int pIn)
        {
            if (pIn < 10)
            {
                return "0" + pIn.ToString();
            }
            else
                return pIn.ToString();
        }

		#region JSON Loop
		private void InitializeLoop(JsonTextReader reader)
		{
			while (reader.Read())
			{
				if (BeginningOfResultFound(reader))
					break;
			}
		}

		/// <summary>
		/// If this method returns true, we are still using the same object.
		/// </summary>
		/// <returns></returns>
		private bool ParseJSON(JsonTextReader reader, SearchResult result)
		{
			if (BeginningOfResultFound(reader))
				return false; 
			else if ( TryParseField(reader,"profile_image_url"))
			{
				result.ProfileURL = reader.Text; 
			}
			else if (TryParseField(reader, "created_at"))
			{
				result.Date = reader.Text; 
			}
			else if (TryParseField(reader, "from_user"))
			{
				result.UserName = reader.Text; 
			}
			else if (TryParseField(reader, "id_str"))
			{
				result.ID = reader.Text; 
			}
			else if (TryParseField(reader, "text"))
			{
				result.Text = reader.Text; 
			}
			return true; 
		}

		private bool TryParseField(JsonTextReader reader, string pTwitterObjName)
		{
			if (reader.Text != null && reader.Text == pTwitterObjName)
			{
				reader.Read();
				return true; 
			}
			return false; 
		}

		private bool BeginningOfResultFound(JsonTextReader reader)
		{
			if (reader.Text != null
				&&
				reader.Text == "from_user_id_str")
			{
				return true;
			}
			else
				return false;
		}
		#endregion

		#endregion

		#region Grid Population
		protected void PopulateGrid()
		{
			dataGridView1.Rows.Clear(); 
			foreach (SearchResult result in mCurrentResults)
			{
				dataGridView1.Rows.Add(
					result.Text,
					result.Date,
					result.UserName
					);
			}
		}
		#endregion

		#region Members / Properties
		List<SearchResult> mCurrentResults = new List<SearchResult>();

		KeyValuePair<string, int> mCurrentKVP;

		string mCurrentURL = ""; 

		string mLastQuery = ""; 

		int CurrentPage
		{
			get
			{
				return Int16.Parse(mPgBox.Value.ToString());
			}
			set
			{
				mPgBox.Value = value; 
			}
		}

		/// <summary>
		/// Previous searches, indexed by query & page #. 
		/// </summary>
		Dictionary<
			KeyValuePair<string,int>, 
			List<SearchResult>
			> mPreviousSearches 
			= new Dictionary<KeyValuePair<string,int>, List<SearchResult>>(); 
		

		#endregion

	}
}
