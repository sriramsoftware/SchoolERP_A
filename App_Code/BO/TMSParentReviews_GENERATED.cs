/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 12/13/2012 6:47:20 PM                                    */
/*                                                                          */
/* www.CodeAuthor.org                                                       */
/****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

[DataObject]
[Serializable]
public partial class TMSParentReviews
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_ParentReviews]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _prReviewsId;
	private System.Int64? _prLoginId;
	private System.Int64? _prSenderId;
	private System.Int64? _prReceivedId;
	private System.Int64? _prReplyId;
	private System.Int64? _prReviewCount;
	private System.String _prReviewType;
	private System.String _prReviewTitle;
	private System.String _prReviewSubject;
	private System.String _prDescription;
	private System.String _prReviewText;
	private System.String _prReviewRemarks;
	private System.Int32? _prReadStatus;
	private System.DateTime? _prSendDate;
	private System.DateTime? _prDate;
	private System.Int32? _prStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? PRReviewsId
	{
		get
		{
			return _prReviewsId;
		}
		set
		{
			_prReviewsId = value;
		}
	}
	
	public System.Int64? PRLoginId
	{
		get
		{
			return _prLoginId;
		}
		set
		{
			_prLoginId = value;
		}
	}
	
	public System.Int64? PRSenderId
	{
		get
		{
			return _prSenderId;
		}
		set
		{
			_prSenderId = value;
		}
	}
	
	public System.Int64? PRReceivedId
	{
		get
		{
			return _prReceivedId;
		}
		set
		{
			_prReceivedId = value;
		}
	}
	
	public System.Int64? PRReplyId
	{
		get
		{
			return _prReplyId;
		}
		set
		{
			_prReplyId = value;
		}
	}
	
	public System.Int64? PRReviewCount
	{
		get
		{
			return _prReviewCount;
		}
		set
		{
			_prReviewCount = value;
		}
	}
	
	public System.String PRReviewType
	{
		get
		{
			return _prReviewType;
		}
		set
		{
			_prReviewType = value;
		}
	}
	
	public System.String PRReviewTitle
	{
		get
		{
			return _prReviewTitle;
		}
		set
		{
			_prReviewTitle = value;
		}
	}
	
	public System.String PRReviewSubject
	{
		get
		{
			return _prReviewSubject;
		}
		set
		{
			_prReviewSubject = value;
		}
	}
	
	public System.String PRDescription
	{
		get
		{
			return _prDescription;
		}
		set
		{
			_prDescription = value;
		}
	}
	
	public System.String PRReviewText
	{
		get
		{
			return _prReviewText;
		}
		set
		{
			_prReviewText = value;
		}
	}
	
	public System.String PRReviewRemarks
	{
		get
		{
			return _prReviewRemarks;
		}
		set
		{
			_prReviewRemarks = value;
		}
	}
	
	public System.Int32? PRReadStatus
	{
		get
		{
			return _prReadStatus;
		}
		set
		{
			_prReadStatus = value;
		}
	}
	
	public System.DateTime? PRSendDate
	{
		get
		{
			return _prSendDate;
		}
		set
		{
			_prSendDate = value;
		}
	}
	
	public System.DateTime? PRDate
	{
		get
		{
			return _prDate;
		}
		set
		{
			_prDate = value;
		}
	}
	
	public System.Int32? PRStatus
	{
		get
		{
			return _prStatus;
		}
		set
		{
			_prStatus = value;
		}
	}
	
	#endregion
	
	
	#region Methods
	
	
	#region Mapping Methods
	
	protected void MapTo(DataSet ds)
	{
		DataRow dr;
		
		
		if (ds == null)
		ds = new DataSet();
		
		if (ds.Tables["TABLE_NAME"] == null)
		ds.Tables.Add(TABLE_NAME);
		
		ds.Tables[TABLE_NAME].Columns.Add("PR_ReviewsId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PR_LoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PR_SenderId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PR_ReceivedId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PR_ReplyId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PR_ReviewCount", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PR_ReviewType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PR_ReviewTitle", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PR_ReviewSubject", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PR_Description", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PR_ReviewText", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PR_ReviewRemarks", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PR_ReadStatus", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("PR_SendDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("PR_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("PR_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (PRReviewsId == null)
		dr["PR_ReviewsId"] = DBNull.Value;
		else
		dr["PR_ReviewsId"] = PRReviewsId;
		
		if (PRLoginId == null)
		dr["PR_LoginId"] = DBNull.Value;
		else
		dr["PR_LoginId"] = PRLoginId;
		
		if (PRSenderId == null)
		dr["PR_SenderId"] = DBNull.Value;
		else
		dr["PR_SenderId"] = PRSenderId;
		
		if (PRReceivedId == null)
		dr["PR_ReceivedId"] = DBNull.Value;
		else
		dr["PR_ReceivedId"] = PRReceivedId;
		
		if (PRReplyId == null)
		dr["PR_ReplyId"] = DBNull.Value;
		else
		dr["PR_ReplyId"] = PRReplyId;
		
		if (PRReviewCount == null)
		dr["PR_ReviewCount"] = DBNull.Value;
		else
		dr["PR_ReviewCount"] = PRReviewCount;
		
		if (PRReviewType == null)
		dr["PR_ReviewType"] = DBNull.Value;
		else
		dr["PR_ReviewType"] = PRReviewType;
		
		if (PRReviewTitle == null)
		dr["PR_ReviewTitle"] = DBNull.Value;
		else
		dr["PR_ReviewTitle"] = PRReviewTitle;
		
		if (PRReviewSubject == null)
		dr["PR_ReviewSubject"] = DBNull.Value;
		else
		dr["PR_ReviewSubject"] = PRReviewSubject;
		
		if (PRDescription == null)
		dr["PR_Description"] = DBNull.Value;
		else
		dr["PR_Description"] = PRDescription;
		
		if (PRReviewText == null)
		dr["PR_ReviewText"] = DBNull.Value;
		else
		dr["PR_ReviewText"] = PRReviewText;
		
		if (PRReviewRemarks == null)
		dr["PR_ReviewRemarks"] = DBNull.Value;
		else
		dr["PR_ReviewRemarks"] = PRReviewRemarks;
		
		if (PRReadStatus == null)
		dr["PR_ReadStatus"] = DBNull.Value;
		else
		dr["PR_ReadStatus"] = PRReadStatus;
		
		if (PRSendDate == null)
		dr["PR_SendDate"] = DBNull.Value;
		else
		dr["PR_SendDate"] = PRSendDate;
		
		if (PRDate == null)
		dr["PR_Date"] = DBNull.Value;
		else
		dr["PR_Date"] = PRDate;
		
		if (PRStatus == null)
		dr["PR_Status"] = DBNull.Value;
		else
		dr["PR_Status"] = PRStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		PRReviewsId = dr["PR_ReviewsId"] != DBNull.Value ? Convert.ToInt64(dr["PR_ReviewsId"]) : PRReviewsId = null;
		PRLoginId = dr["PR_LoginId"] != DBNull.Value ? Convert.ToInt64(dr["PR_LoginId"]) : PRLoginId = null;
		PRSenderId = dr["PR_SenderId"] != DBNull.Value ? Convert.ToInt64(dr["PR_SenderId"]) : PRSenderId = null;
		PRReceivedId = dr["PR_ReceivedId"] != DBNull.Value ? Convert.ToInt64(dr["PR_ReceivedId"]) : PRReceivedId = null;
		PRReplyId = dr["PR_ReplyId"] != DBNull.Value ? Convert.ToInt64(dr["PR_ReplyId"]) : PRReplyId = null;
		PRReviewCount = dr["PR_ReviewCount"] != DBNull.Value ? Convert.ToInt64(dr["PR_ReviewCount"]) : PRReviewCount = null;
		PRReviewType = dr["PR_ReviewType"] != DBNull.Value ? Convert.ToString(dr["PR_ReviewType"]) : PRReviewType = null;
		PRReviewTitle = dr["PR_ReviewTitle"] != DBNull.Value ? Convert.ToString(dr["PR_ReviewTitle"]) : PRReviewTitle = null;
		PRReviewSubject = dr["PR_ReviewSubject"] != DBNull.Value ? Convert.ToString(dr["PR_ReviewSubject"]) : PRReviewSubject = null;
		PRDescription = dr["PR_Description"] != DBNull.Value ? Convert.ToString(dr["PR_Description"]) : PRDescription = null;
		PRReviewText = dr["PR_ReviewText"] != DBNull.Value ? Convert.ToString(dr["PR_ReviewText"]) : PRReviewText = null;
		PRReviewRemarks = dr["PR_ReviewRemarks"] != DBNull.Value ? Convert.ToString(dr["PR_ReviewRemarks"]) : PRReviewRemarks = null;
		PRReadStatus = dr["PR_ReadStatus"] != DBNull.Value ? Convert.ToInt32(dr["PR_ReadStatus"]) : PRReadStatus = null;
		PRSendDate = dr["PR_SendDate"] != DBNull.Value ? Convert.ToDateTime(dr["PR_SendDate"]) : PRSendDate = null;
		PRDate = dr["PR_Date"] != DBNull.Value ? Convert.ToDateTime(dr["PR_Date"]) : PRDate = null;
		PRStatus = dr["PR_Status"] != DBNull.Value ? Convert.ToInt32(dr["PR_Status"]) : PRStatus = null;
	}
	
	public static TMSParentReviews[] MapFrom(DataSet ds)
	{
		List<TMSParentReviews> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSParentReviews>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_ParentReviews] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_ParentReviews] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSParentReviews instance = new TMSParentReviews();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSParentReviews Get(System.Int64 prReviewsId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSParentReviews instance;
		
		
		instance = new TMSParentReviews();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSParentReviews_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, prReviewsId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSParentReviews ID:" + prReviewsId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? prLoginId, System.Int64? prSenderId, System.Int64? prReceivedId, System.Int64? prReplyId, System.Int64? prReviewCount, System.String prReviewType, System.String prReviewTitle, System.String prReviewSubject, System.String prDescription, System.String prReviewText, System.String prReviewRemarks, System.Int32? prReadStatus, System.DateTime? prSendDate, System.DateTime? prDate, System.Int32? prStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSParentReviews_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, prLoginId, prSenderId, prReceivedId, prReplyId, prReviewCount, prReviewType, prReviewTitle, prReviewSubject, prDescription, prReviewText, prReviewRemarks, prReadStatus, prSendDate, prDate, prStatus);
		
		if (transaction == null)
		this.PRReviewsId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.PRReviewsId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? prLoginId, System.Int64? prSenderId, System.Int64? prReceivedId, System.Int64? prReplyId, System.Int64? prReviewCount, System.String prReviewType, System.String prReviewTitle, System.String prReviewSubject, System.String prDescription, System.String prReviewText, System.String prReviewRemarks, System.Int32? prReadStatus, System.DateTime? prSendDate, System.DateTime? prDate, System.Int32? prStatus)
	{
		Insert(prLoginId, prSenderId, prReceivedId, prReplyId, prReviewCount, prReviewType, prReviewTitle, prReviewSubject, prDescription, prReviewText, prReviewRemarks, prReadStatus, prSendDate, prDate, prStatus, null);
	}
	/// <summary>
	/// Insert current TMSParentReviews to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(PRLoginId, PRSenderId, PRReceivedId, PRReplyId, PRReviewCount, PRReviewType, PRReviewTitle, PRReviewSubject, PRDescription, PRReviewText, PRReviewRemarks, PRReadStatus, PRSendDate, PRDate, PRStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSParentReviews to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? prReviewsId, System.Int64? prLoginId, System.Int64? prSenderId, System.Int64? prReceivedId, System.Int64? prReplyId, System.Int64? prReviewCount, System.String prReviewType, System.String prReviewTitle, System.String prReviewSubject, System.String prDescription, System.String prReviewText, System.String prReviewRemarks, System.Int32? prReadStatus, System.DateTime? prSendDate, System.DateTime? prDate, System.Int32? prStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSParentReviews_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@prReviewsId"].Value = prReviewsId;
		dbCommand.Parameters["@prLoginId"].Value = prLoginId;
		dbCommand.Parameters["@prSenderId"].Value = prSenderId;
		dbCommand.Parameters["@prReceivedId"].Value = prReceivedId;
		dbCommand.Parameters["@prReplyId"].Value = prReplyId;
		dbCommand.Parameters["@prReviewCount"].Value = prReviewCount;
		dbCommand.Parameters["@prReviewType"].Value = prReviewType;
		dbCommand.Parameters["@prReviewTitle"].Value = prReviewTitle;
		dbCommand.Parameters["@prReviewSubject"].Value = prReviewSubject;   
		dbCommand.Parameters["@prDescription"].Value = prDescription;
		dbCommand.Parameters["@prReviewText"].Value = prReviewText;
		dbCommand.Parameters["@prReviewRemarks"].Value = prReviewRemarks;
		dbCommand.Parameters["@prReadStatus"].Value = prReadStatus;
		dbCommand.Parameters["@prSendDate"].Value = prSendDate;
		dbCommand.Parameters["@prDate"].Value = prDate;
		dbCommand.Parameters["@prStatus"].Value = prStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? prReviewsId, System.Int64? prLoginId, System.Int64? prSenderId, System.Int64? prReceivedId, System.Int64? prReplyId, System.Int64? prReviewCount, System.String prReviewType, System.String prReviewTitle, System.String prReviewSubject, System.String prDescription, System.String prReviewText, System.String prReviewRemarks, System.Int32? prReadStatus, System.DateTime? prSendDate, System.DateTime? prDate, System.Int32? prStatus)
	{
		Update(prReviewsId, prLoginId, prSenderId, prReceivedId, prReplyId, prReviewCount, prReviewType, prReviewTitle, prReviewSubject, prDescription, prReviewText, prReviewRemarks, prReadStatus, prSendDate, prDate, prStatus, null);
	}
	
	public static void Update(TMSParentReviews tMSParentReviews)
	{
		tMSParentReviews.Update();
	}
	
	public static void Update(TMSParentReviews tMSParentReviews, DbTransaction transaction)
	{
		tMSParentReviews.Update(transaction);
	}
	
	/// <summary>
	/// Updates changes to the database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Update(DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSParentReviews_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@prReviewsId"].SourceColumn = "PR_ReviewsId";
		dbCommand.Parameters["@prLoginId"].SourceColumn = "PR_LoginId";
		dbCommand.Parameters["@prSenderId"].SourceColumn = "PR_SenderId";
		dbCommand.Parameters["@prReceivedId"].SourceColumn = "PR_ReceivedId";
		dbCommand.Parameters["@prReplyId"].SourceColumn = "PR_ReplyId";
		dbCommand.Parameters["@prReviewCount"].SourceColumn = "PR_ReviewCount";
		dbCommand.Parameters["@prReviewType"].SourceColumn = "PR_ReviewType";
		dbCommand.Parameters["@prReviewTitle"].SourceColumn = "PR_ReviewTitle";
		dbCommand.Parameters["@prReviewSubject"].SourceColumn = "PR_ReviewSubject";
		dbCommand.Parameters["@prDescription"].SourceColumn = "PR_Description";
		dbCommand.Parameters["@prReviewText"].SourceColumn = "PR_ReviewText";
		dbCommand.Parameters["@prReviewRemarks"].SourceColumn = "PR_ReviewRemarks";
		dbCommand.Parameters["@prReadStatus"].SourceColumn = "PR_ReadStatus";
		dbCommand.Parameters["@prSendDate"].SourceColumn = "PR_SendDate";
		dbCommand.Parameters["@prDate"].SourceColumn = "PR_Date";
		dbCommand.Parameters["@prStatus"].SourceColumn = "PR_Status";
		
		ds = new DataSet();
		this.MapTo( ds );
		ds.AcceptChanges();
		ds.Tables[0].Rows[0].SetModified();
		if (transaction == null)
		db.UpdateDataSet(ds, TABLE_NAME, null, dbCommand, null, UpdateBehavior.Standard);
		else
		db.UpdateDataSet(ds, TABLE_NAME, null, dbCommand, null, transaction);
		return;
	}
	
	/// <summary>
	/// Updates changes to the database.
	/// </summary>
	public void Update()
	{
		this.Update((DbTransaction)null);
	}
	#endregion
	
	
	#region DELETE
	[DataObjectMethodAttribute(DataObjectMethodType.Delete, false)]
	public static void Delete(System.Int64? prReviewsId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSParentReviews_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, prReviewsId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
	public static void Delete(System.Int64? prReviewsId)
	{
		Delete(
		prReviewsId);
	}
	
	/// <summary>
	/// Delete current TMSParentReviews from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSParentReviews_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, PRReviewsId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.PRReviewsId = null;
	}
	
	/// <summary>
	/// Delete current TMSParentReviews from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSParentReviews[] Search(System.Int64? prReviewsId, System.Int64? prLoginId, System.Int64? prSenderId, System.Int64? prReceivedId, System.Int64? prReplyId, System.Int64? prReviewCount, System.String prReviewType, System.String prReviewTitle, System.String prReviewSubject, System.String prDescription, System.String prReviewText, System.String prReviewRemarks, System.Int32? prReadStatus, System.DateTime? prSendDate, System.DateTime? prDate, System.Int32? prStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSParentReviews_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, prReviewsId, prLoginId, prSenderId, prReceivedId, prReplyId, prReviewCount, prReviewType, prReviewTitle, prReviewSubject, prDescription, prReviewText, prReviewRemarks, prReadStatus, prSendDate, prDate, prStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSParentReviews.MapFrom(ds);
	}
	
	
	public static TMSParentReviews[] Search(TMSParentReviews searchObject)
	{
		return Search ( searchObject.PRReviewsId, searchObject.PRLoginId, searchObject.PRSenderId, searchObject.PRReceivedId, searchObject.PRReplyId, searchObject.PRReviewCount, searchObject.PRReviewType, searchObject.PRReviewTitle, searchObject.PRReviewSubject, searchObject.PRDescription, searchObject.PRReviewText, searchObject.PRReviewRemarks, searchObject.PRReadStatus, searchObject.PRSendDate, searchObject.PRDate, searchObject.PRStatus);
	}
	
	/// <summary>
	/// Returns all TMSParentReviews objects.
	/// </summary>
	/// <returns>List of all TMSParentReviews objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSParentReviews[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

