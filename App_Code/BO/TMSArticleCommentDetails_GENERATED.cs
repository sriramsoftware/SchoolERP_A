/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 9/26/2012 9:49:43 AM                                    */
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
public partial class TMSArticleCommentDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_ArticleCommentDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _acdCommentId;
	private System.Int64? _acdArticleId;
	private System.Int64? _acdLoginId;
	private System.String _acdLoginType;
	private System.String _acdCommentText;
	private System.String _acdMessage;
	private System.Int64? _acdReplyId;
	private System.String _acdApprovedStatus;
	private System.Int64? _acdApproveById;
	private System.String _acdApproveByType;
	private System.DateTime? _acdDate;
	private System.Int32? _acdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? ACDCommentId
	{
		get
		{
			return _acdCommentId;
		}
		set
		{
			_acdCommentId = value;
		}
	}
	
	public System.Int64? ACDArticleId
	{
		get
		{
			return _acdArticleId;
		}
		set
		{
			_acdArticleId = value;
		}
	}
	
	public System.Int64? ACDLoginId
	{
		get
		{
			return _acdLoginId;
		}
		set
		{
			_acdLoginId = value;
		}
	}
	
	public System.String ACDLoginType
	{
		get
		{
			return _acdLoginType;
		}
		set
		{
			_acdLoginType = value;
		}
	}
	
	public System.String ACDCommentText
	{
		get
		{
			return _acdCommentText;
		}
		set
		{
			_acdCommentText = value;
		}
	}
	
	public System.String ACDMessage
	{
		get
		{
			return _acdMessage;
		}
		set
		{
			_acdMessage = value;
		}
	}
	
	public System.Int64? ACDReplyId
	{
		get
		{
			return _acdReplyId;
		}
		set
		{
			_acdReplyId = value;
		}
	}
	
	public System.String ACDApprovedStatus
	{
		get
		{
			return _acdApprovedStatus;
		}
		set
		{
			_acdApprovedStatus = value;
		}
	}
	
	public System.Int64? ACDApproveById
	{
		get
		{
			return _acdApproveById;
		}
		set
		{
			_acdApproveById = value;
		}
	}
	
	public System.String ACDApproveByType
	{
		get
		{
			return _acdApproveByType;
		}
		set
		{
			_acdApproveByType = value;
		}
	}
	
	public System.DateTime? ACDDate
	{
		get
		{
			return _acdDate;
		}
		set
		{
			_acdDate = value;
		}
	}
	
	public System.Int32? ACDStatus
	{
		get
		{
			return _acdStatus;
		}
		set
		{
			_acdStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("ACD_CommentId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ACD_ArticleId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ACD_LoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ACD_LoginType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ACD_CommentText", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ACD_Message", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ACD_ReplyId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ACD_ApprovedStatus", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ACD_ApproveById", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ACD_ApproveByType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ACD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("ACD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (ACDCommentId == null)
		dr["ACD_CommentId"] = DBNull.Value;
		else
		dr["ACD_CommentId"] = ACDCommentId;
		
		if (ACDArticleId == null)
		dr["ACD_ArticleId"] = DBNull.Value;
		else
		dr["ACD_ArticleId"] = ACDArticleId;
		
		if (ACDLoginId == null)
		dr["ACD_LoginId"] = DBNull.Value;
		else
		dr["ACD_LoginId"] = ACDLoginId;
		
		if (ACDLoginType == null)
		dr["ACD_LoginType"] = DBNull.Value;
		else
		dr["ACD_LoginType"] = ACDLoginType;
		
		if (ACDCommentText == null)
		dr["ACD_CommentText"] = DBNull.Value;
		else
		dr["ACD_CommentText"] = ACDCommentText;
		
		if (ACDMessage == null)
		dr["ACD_Message"] = DBNull.Value;
		else
		dr["ACD_Message"] = ACDMessage;
		
		if (ACDReplyId == null)
		dr["ACD_ReplyId"] = DBNull.Value;
		else
		dr["ACD_ReplyId"] = ACDReplyId;
		
		if (ACDApprovedStatus == null)
		dr["ACD_ApprovedStatus"] = DBNull.Value;
		else
		dr["ACD_ApprovedStatus"] = ACDApprovedStatus;
		
		if (ACDApproveById == null)
		dr["ACD_ApproveById"] = DBNull.Value;
		else
		dr["ACD_ApproveById"] = ACDApproveById;
		
		if (ACDApproveByType == null)
		dr["ACD_ApproveByType"] = DBNull.Value;
		else
		dr["ACD_ApproveByType"] = ACDApproveByType;
		
		if (ACDDate == null)
		dr["ACD_Date"] = DBNull.Value;
		else
		dr["ACD_Date"] = ACDDate;
		
		if (ACDStatus == null)
		dr["ACD_Status"] = DBNull.Value;
		else
		dr["ACD_Status"] = ACDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		ACDCommentId = dr["ACD_CommentId"] != DBNull.Value ? Convert.ToInt64(dr["ACD_CommentId"]) : ACDCommentId = null;
		ACDArticleId = dr["ACD_ArticleId"] != DBNull.Value ? Convert.ToInt64(dr["ACD_ArticleId"]) : ACDArticleId = null;
		ACDLoginId = dr["ACD_LoginId"] != DBNull.Value ? Convert.ToInt64(dr["ACD_LoginId"]) : ACDLoginId = null;
		ACDLoginType = dr["ACD_LoginType"] != DBNull.Value ? Convert.ToString(dr["ACD_LoginType"]) : ACDLoginType = null;
		ACDCommentText = dr["ACD_CommentText"] != DBNull.Value ? Convert.ToString(dr["ACD_CommentText"]) : ACDCommentText = null;
		ACDMessage = dr["ACD_Message"] != DBNull.Value ? Convert.ToString(dr["ACD_Message"]) : ACDMessage = null;
		ACDReplyId = dr["ACD_ReplyId"] != DBNull.Value ? Convert.ToInt64(dr["ACD_ReplyId"]) : ACDReplyId = null;
		ACDApprovedStatus = dr["ACD_ApprovedStatus"] != DBNull.Value ? Convert.ToString(dr["ACD_ApprovedStatus"]) : ACDApprovedStatus = null;
		ACDApproveById = dr["ACD_ApproveById"] != DBNull.Value ? Convert.ToInt64(dr["ACD_ApproveById"]) : ACDApproveById = null;
		ACDApproveByType = dr["ACD_ApproveByType"] != DBNull.Value ? Convert.ToString(dr["ACD_ApproveByType"]) : ACDApproveByType = null;
		ACDDate = dr["ACD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["ACD_Date"]) : ACDDate = null;
		ACDStatus = dr["ACD_Status"] != DBNull.Value ? Convert.ToInt32(dr["ACD_Status"]) : ACDStatus = null;
	}
	
	public static TMSArticleCommentDetails[] MapFrom(DataSet ds)
	{
		List<TMSArticleCommentDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSArticleCommentDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_ArticleCommentDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_ArticleCommentDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSArticleCommentDetails instance = new TMSArticleCommentDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSArticleCommentDetails Get(System.Int64 acdCommentId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSArticleCommentDetails instance;
		
		
		instance = new TMSArticleCommentDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSArticleCommentDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, acdCommentId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSArticleCommentDetails ID:" + acdCommentId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? acdArticleId, System.Int64? acdLoginId, System.String acdLoginType, System.String acdCommentText, System.String acdMessage, System.Int64? acdReplyId, System.String acdApprovedStatus, System.Int64? acdApproveById, System.String acdApproveByType, System.DateTime? acdDate, System.Int32? acdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSArticleCommentDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, acdArticleId, acdLoginId, acdLoginType, acdCommentText, acdMessage, acdReplyId, acdApprovedStatus, acdApproveById, acdApproveByType, acdDate, acdStatus);
		
		if (transaction == null)
		this.ACDCommentId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.ACDCommentId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? acdArticleId, System.Int64? acdLoginId, System.String acdLoginType, System.String acdCommentText, System.String acdMessage, System.Int64? acdReplyId, System.String acdApprovedStatus, System.Int64? acdApproveById, System.String acdApproveByType, System.DateTime? acdDate, System.Int32? acdStatus)
	{
		Insert(acdArticleId, acdLoginId, acdLoginType, acdCommentText, acdMessage, acdReplyId, acdApprovedStatus, acdApproveById, acdApproveByType, acdDate, acdStatus, null);
	}
	/// <summary>
	/// Insert current TMSArticleCommentDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(ACDArticleId, ACDLoginId, ACDLoginType, ACDCommentText, ACDMessage, ACDReplyId, ACDApprovedStatus, ACDApproveById, ACDApproveByType, ACDDate, ACDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSArticleCommentDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? acdCommentId, System.Int64? acdArticleId, System.Int64? acdLoginId, System.String acdLoginType, System.String acdCommentText, System.String acdMessage, System.Int64? acdReplyId, System.String acdApprovedStatus, System.Int64? acdApproveById, System.String acdApproveByType, System.DateTime? acdDate, System.Int32? acdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSArticleCommentDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@acdCommentId"].Value = acdCommentId;
		dbCommand.Parameters["@acdArticleId"].Value = acdArticleId;
		dbCommand.Parameters["@acdLoginId"].Value = acdLoginId;
		dbCommand.Parameters["@acdLoginType"].Value = acdLoginType;
		dbCommand.Parameters["@acdCommentText"].Value = acdCommentText;
		dbCommand.Parameters["@acdMessage"].Value = acdMessage;
		dbCommand.Parameters["@acdReplyId"].Value = acdReplyId;
		dbCommand.Parameters["@acdApprovedStatus"].Value = acdApprovedStatus;
		dbCommand.Parameters["@acdApproveById"].Value = acdApproveById;
		dbCommand.Parameters["@acdApproveByType"].Value = acdApproveByType;
		dbCommand.Parameters["@acdDate"].Value = acdDate;
		dbCommand.Parameters["@acdStatus"].Value = acdStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? acdCommentId, System.Int64? acdArticleId, System.Int64? acdLoginId, System.String acdLoginType, System.String acdCommentText, System.String acdMessage, System.Int64? acdReplyId, System.String acdApprovedStatus, System.Int64? acdApproveById, System.String acdApproveByType, System.DateTime? acdDate, System.Int32? acdStatus)
	{
		Update(acdCommentId, acdArticleId, acdLoginId, acdLoginType, acdCommentText, acdMessage, acdReplyId, acdApprovedStatus, acdApproveById, acdApproveByType, acdDate, acdStatus, null);
	}
	
	public static void Update(TMSArticleCommentDetails tMSArticleCommentDetails)
	{
		tMSArticleCommentDetails.Update();
	}
	
	public static void Update(TMSArticleCommentDetails tMSArticleCommentDetails, DbTransaction transaction)
	{
		tMSArticleCommentDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSArticleCommentDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@acdCommentId"].SourceColumn = "ACD_CommentId";
		dbCommand.Parameters["@acdArticleId"].SourceColumn = "ACD_ArticleId";
		dbCommand.Parameters["@acdLoginId"].SourceColumn = "ACD_LoginId";
		dbCommand.Parameters["@acdLoginType"].SourceColumn = "ACD_LoginType";
		dbCommand.Parameters["@acdCommentText"].SourceColumn = "ACD_CommentText";
		dbCommand.Parameters["@acdMessage"].SourceColumn = "ACD_Message";
		dbCommand.Parameters["@acdReplyId"].SourceColumn = "ACD_ReplyId";
		dbCommand.Parameters["@acdApprovedStatus"].SourceColumn = "ACD_ApprovedStatus";
		dbCommand.Parameters["@acdApproveById"].SourceColumn = "ACD_ApproveById";
		dbCommand.Parameters["@acdApproveByType"].SourceColumn = "ACD_ApproveByType";
		dbCommand.Parameters["@acdDate"].SourceColumn = "ACD_Date";
		dbCommand.Parameters["@acdStatus"].SourceColumn = "ACD_Status";
		
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
	public static void Delete(System.Int64? acdCommentId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSArticleCommentDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, acdCommentId);
		
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
	public static void Delete(System.Int64? acdCommentId)
	{
		Delete(
		acdCommentId);
	}
	
	/// <summary>
	/// Delete current TMSArticleCommentDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSArticleCommentDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ACDCommentId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.ACDCommentId = null;
	}
	
	/// <summary>
	/// Delete current TMSArticleCommentDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSArticleCommentDetails[] Search(System.Int64? acdCommentId, System.Int64? acdArticleId, System.Int64? acdLoginId, System.String acdLoginType, System.String acdCommentText, System.String acdMessage, System.Int64? acdReplyId, System.String acdApprovedStatus, System.Int64? acdApproveById, System.String acdApproveByType, System.DateTime? acdDate, System.Int32? acdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSArticleCommentDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, acdCommentId, acdArticleId, acdLoginId, acdLoginType, acdCommentText, acdMessage, acdReplyId, acdApprovedStatus, acdApproveById, acdApproveByType, acdDate, acdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSArticleCommentDetails.MapFrom(ds);
	}
	
	
	public static TMSArticleCommentDetails[] Search(TMSArticleCommentDetails searchObject)
	{
		return Search ( searchObject.ACDCommentId, searchObject.ACDArticleId, searchObject.ACDLoginId, searchObject.ACDLoginType, searchObject.ACDCommentText, searchObject.ACDMessage, searchObject.ACDReplyId, searchObject.ACDApprovedStatus, searchObject.ACDApproveById, searchObject.ACDApproveByType, searchObject.ACDDate, searchObject.ACDStatus);
	}
	
	/// <summary>
	/// Returns all TMSArticleCommentDetails objects.
	/// </summary>
	/// <returns>List of all TMSArticleCommentDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSArticleCommentDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

