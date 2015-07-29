/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 10/1/2012 2:29:53 PM                                    */
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
public partial class TMSMySMSDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_MySMSDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _mmdMessageId;
	private System.Int64? _mmdLoginId;
	private System.Int64? _mmdSenderId;
	private System.Int64? _mmdReceivedId;
	private System.Int64? _mmdReplyId;
	private System.String _mmdMessageType;
	private System.String _mmdMessageTitle;
	private System.String _mmdMessageSubject;
	private System.String _mmdDescription;
	private System.String _mmdMessageText;
	private System.String _mmdMessageRemarks;
	private System.Int32? _mmdReadStatus;
	private System.DateTime? _mmdSendDate;
	private System.DateTime? _mmdDate;
	private System.String _mmdAddedByType;
	private System.Int32? _mmdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? MMDMessageId
	{
		get
		{
			return _mmdMessageId;
		}
		set
		{
			_mmdMessageId = value;
		}
	}
	
	public System.Int64? MMDLoginId
	{
		get
		{
			return _mmdLoginId;
		}
		set
		{
			_mmdLoginId = value;
		}
	}
	
	public System.Int64? MMDSenderId
	{
		get
		{
			return _mmdSenderId;
		}
		set
		{
			_mmdSenderId = value;
		}
	}
	
	public System.Int64? MMDReceivedId
	{
		get
		{
			return _mmdReceivedId;
		}
		set
		{
			_mmdReceivedId = value;
		}
	}
	
	public System.Int64? MMDReplyId
	{
		get
		{
			return _mmdReplyId;
		}
		set
		{
			_mmdReplyId = value;
		}
	}
	
	public System.String MMDMessageType
	{
		get
		{
			return _mmdMessageType;
		}
		set
		{
			_mmdMessageType = value;
		}
	}
	
	public System.String MMDMessageTitle
	{
		get
		{
			return _mmdMessageTitle;
		}
		set
		{
			_mmdMessageTitle = value;
		}
	}
	
	public System.String MMDMessageSubject
	{
		get
		{
			return _mmdMessageSubject;
		}
		set
		{
			_mmdMessageSubject = value;
		}
	}
	
	public System.String MMDDescription
	{
		get
		{
			return _mmdDescription;
		}
		set
		{
			_mmdDescription = value;
		}
	}
	
	public System.String MMDMessageText
	{
		get
		{
			return _mmdMessageText;
		}
		set
		{
			_mmdMessageText = value;
		}
	}
	
	public System.String MMDMessageRemarks
	{
		get
		{
			return _mmdMessageRemarks;
		}
		set
		{
			_mmdMessageRemarks = value;
		}
	}
	
	public System.Int32? MMDReadStatus
	{
		get
		{
			return _mmdReadStatus;
		}
		set
		{
			_mmdReadStatus = value;
		}
	}
	
	public System.DateTime? MMDSendDate
	{
		get
		{
			return _mmdSendDate;
		}
		set
		{
			_mmdSendDate = value;
		}
	}
	
	public System.DateTime? MMDDate
	{
		get
		{
			return _mmdDate;
		}
		set
		{
			_mmdDate = value;
		}
	}
	
	public System.String MMDAddedByType
	{
		get
		{
			return _mmdAddedByType;
		}
		set
		{
			_mmdAddedByType = value;
		}
	}
	
	public System.Int32? MMDStatus
	{
		get
		{
			return _mmdStatus;
		}
		set
		{
			_mmdStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("MMD_MessageId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("MMD_LoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("MMD_SenderId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("MMD_ReceivedId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("MMD_ReplyId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("MMD_MessageType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("MMD_MessageTitle", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("MMD_MessageSubject", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("MMD_Description", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("MMD_MessageText", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("MMD_MessageRemarks", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("MMD_ReadStatus", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("MMD_SendDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("MMD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("MMD_AddedByType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("MMD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (MMDMessageId == null)
		dr["MMD_MessageId"] = DBNull.Value;
		else
		dr["MMD_MessageId"] = MMDMessageId;
		
		if (MMDLoginId == null)
		dr["MMD_LoginId"] = DBNull.Value;
		else
		dr["MMD_LoginId"] = MMDLoginId;
		
		if (MMDSenderId == null)
		dr["MMD_SenderId"] = DBNull.Value;
		else
		dr["MMD_SenderId"] = MMDSenderId;
		
		if (MMDReceivedId == null)
		dr["MMD_ReceivedId"] = DBNull.Value;
		else
		dr["MMD_ReceivedId"] = MMDReceivedId;
		
		if (MMDReplyId == null)
		dr["MMD_ReplyId"] = DBNull.Value;
		else
		dr["MMD_ReplyId"] = MMDReplyId;
		
		if (MMDMessageType == null)
		dr["MMD_MessageType"] = DBNull.Value;
		else
		dr["MMD_MessageType"] = MMDMessageType;
		
		if (MMDMessageTitle == null)
		dr["MMD_MessageTitle"] = DBNull.Value;
		else
		dr["MMD_MessageTitle"] = MMDMessageTitle;
		
		if (MMDMessageSubject == null)
		dr["MMD_MessageSubject"] = DBNull.Value;
		else
		dr["MMD_MessageSubject"] = MMDMessageSubject;
		
		if (MMDDescription == null)
		dr["MMD_Description"] = DBNull.Value;
		else
		dr["MMD_Description"] = MMDDescription;
		
		if (MMDMessageText == null)
		dr["MMD_MessageText"] = DBNull.Value;
		else
		dr["MMD_MessageText"] = MMDMessageText;
		
		if (MMDMessageRemarks == null)
		dr["MMD_MessageRemarks"] = DBNull.Value;
		else
		dr["MMD_MessageRemarks"] = MMDMessageRemarks;
		
		if (MMDReadStatus == null)
		dr["MMD_ReadStatus"] = DBNull.Value;
		else
		dr["MMD_ReadStatus"] = MMDReadStatus;
		
		if (MMDSendDate == null)
		dr["MMD_SendDate"] = DBNull.Value;
		else
		dr["MMD_SendDate"] = MMDSendDate;
		
		if (MMDDate == null)
		dr["MMD_Date"] = DBNull.Value;
		else
		dr["MMD_Date"] = MMDDate;
		
		if (MMDAddedByType == null)
		dr["MMD_AddedByType"] = DBNull.Value;
		else
		dr["MMD_AddedByType"] = MMDAddedByType;
		
		if (MMDStatus == null)
		dr["MMD_Status"] = DBNull.Value;
		else
		dr["MMD_Status"] = MMDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		MMDMessageId = dr["MMD_MessageId"] != DBNull.Value ? Convert.ToInt64(dr["MMD_MessageId"]) : MMDMessageId = null;
		MMDLoginId = dr["MMD_LoginId"] != DBNull.Value ? Convert.ToInt64(dr["MMD_LoginId"]) : MMDLoginId = null;
		MMDSenderId = dr["MMD_SenderId"] != DBNull.Value ? Convert.ToInt64(dr["MMD_SenderId"]) : MMDSenderId = null;
		MMDReceivedId = dr["MMD_ReceivedId"] != DBNull.Value ? Convert.ToInt64(dr["MMD_ReceivedId"]) : MMDReceivedId = null;
		MMDReplyId = dr["MMD_ReplyId"] != DBNull.Value ? Convert.ToInt64(dr["MMD_ReplyId"]) : MMDReplyId = null;
		MMDMessageType = dr["MMD_MessageType"] != DBNull.Value ? Convert.ToString(dr["MMD_MessageType"]) : MMDMessageType = null;
		MMDMessageTitle = dr["MMD_MessageTitle"] != DBNull.Value ? Convert.ToString(dr["MMD_MessageTitle"]) : MMDMessageTitle = null;
		MMDMessageSubject = dr["MMD_MessageSubject"] != DBNull.Value ? Convert.ToString(dr["MMD_MessageSubject"]) : MMDMessageSubject = null;
		MMDDescription = dr["MMD_Description"] != DBNull.Value ? Convert.ToString(dr["MMD_Description"]) : MMDDescription = null;
		MMDMessageText = dr["MMD_MessageText"] != DBNull.Value ? Convert.ToString(dr["MMD_MessageText"]) : MMDMessageText = null;
		MMDMessageRemarks = dr["MMD_MessageRemarks"] != DBNull.Value ? Convert.ToString(dr["MMD_MessageRemarks"]) : MMDMessageRemarks = null;
		MMDReadStatus = dr["MMD_ReadStatus"] != DBNull.Value ? Convert.ToInt32(dr["MMD_ReadStatus"]) : MMDReadStatus = null;
		MMDSendDate = dr["MMD_SendDate"] != DBNull.Value ? Convert.ToDateTime(dr["MMD_SendDate"]) : MMDSendDate = null;
		MMDDate = dr["MMD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["MMD_Date"]) : MMDDate = null;
		MMDAddedByType = dr["MMD_AddedByType"] != DBNull.Value ? Convert.ToString(dr["MMD_AddedByType"]) : MMDAddedByType = null;
		MMDStatus = dr["MMD_Status"] != DBNull.Value ? Convert.ToInt32(dr["MMD_Status"]) : MMDStatus = null;
	}
	
	public static TMSMySMSDetails[] MapFrom(DataSet ds)
	{
		List<TMSMySMSDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSMySMSDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_MySMSDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_MySMSDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSMySMSDetails instance = new TMSMySMSDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSMySMSDetails Get(System.Int64 mmdMessageId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSMySMSDetails instance;
		
		
		instance = new TMSMySMSDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSMySMSDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, mmdMessageId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSMySMSDetails ID:" + mmdMessageId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? mmdLoginId, System.Int64? mmdSenderId, System.Int64? mmdReceivedId, System.Int64? mmdReplyId, System.String mmdMessageType, System.String mmdMessageTitle, System.String mmdMessageSubject, System.String mmdDescription, System.String mmdMessageText, System.String mmdMessageRemarks, System.Int32? mmdReadStatus, System.DateTime? mmdSendDate, System.DateTime? mmdDate, System.String mmdAddedByType, System.Int32? mmdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSMySMSDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, mmdLoginId, mmdSenderId, mmdReceivedId, mmdReplyId, mmdMessageType, mmdMessageTitle, mmdMessageSubject, mmdDescription, mmdMessageText, mmdMessageRemarks, mmdReadStatus, mmdSendDate, mmdDate, mmdAddedByType, mmdStatus);
		
		if (transaction == null)
		this.MMDMessageId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.MMDMessageId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? mmdLoginId, System.Int64? mmdSenderId, System.Int64? mmdReceivedId, System.Int64? mmdReplyId, System.String mmdMessageType, System.String mmdMessageTitle, System.String mmdMessageSubject, System.String mmdDescription, System.String mmdMessageText, System.String mmdMessageRemarks, System.Int32? mmdReadStatus, System.DateTime? mmdSendDate, System.DateTime? mmdDate, System.String mmdAddedByType, System.Int32? mmdStatus)
	{
		Insert(mmdLoginId, mmdSenderId, mmdReceivedId, mmdReplyId, mmdMessageType, mmdMessageTitle, mmdMessageSubject, mmdDescription, mmdMessageText, mmdMessageRemarks, mmdReadStatus, mmdSendDate, mmdDate, mmdAddedByType, mmdStatus, null);
	}
	/// <summary>
	/// Insert current TMSMySMSDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(MMDLoginId, MMDSenderId, MMDReceivedId, MMDReplyId, MMDMessageType, MMDMessageTitle, MMDMessageSubject, MMDDescription, MMDMessageText, MMDMessageRemarks, MMDReadStatus, MMDSendDate, MMDDate, MMDAddedByType, MMDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSMySMSDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? mmdMessageId, System.Int64? mmdLoginId, System.Int64? mmdSenderId, System.Int64? mmdReceivedId, System.Int64? mmdReplyId, System.String mmdMessageType, System.String mmdMessageTitle, System.String mmdMessageSubject, System.String mmdDescription, System.String mmdMessageText, System.String mmdMessageRemarks, System.Int32? mmdReadStatus, System.DateTime? mmdSendDate, System.DateTime? mmdDate, System.String mmdAddedByType, System.Int32? mmdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSMySMSDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@mmdMessageId"].Value = mmdMessageId;
		dbCommand.Parameters["@mmdLoginId"].Value = mmdLoginId;
		dbCommand.Parameters["@mmdSenderId"].Value = mmdSenderId;
		dbCommand.Parameters["@mmdReceivedId"].Value = mmdReceivedId;
		dbCommand.Parameters["@mmdReplyId"].Value = mmdReplyId;
		dbCommand.Parameters["@mmdMessageType"].Value = mmdMessageType;
		dbCommand.Parameters["@mmdMessageTitle"].Value = mmdMessageTitle;
		dbCommand.Parameters["@mmdMessageSubject"].Value = mmdMessageSubject;
		dbCommand.Parameters["@mmdDescription"].Value = mmdDescription;
		dbCommand.Parameters["@mmdMessageText"].Value = mmdMessageText;
		dbCommand.Parameters["@mmdMessageRemarks"].Value = mmdMessageRemarks;
		dbCommand.Parameters["@mmdReadStatus"].Value = mmdReadStatus;
		dbCommand.Parameters["@mmdSendDate"].Value = mmdSendDate;
		dbCommand.Parameters["@mmdDate"].Value = mmdDate;
		dbCommand.Parameters["@mmdAddedByType"].Value = mmdAddedByType;
		dbCommand.Parameters["@mmdStatus"].Value = mmdStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? mmdMessageId, System.Int64? mmdLoginId, System.Int64? mmdSenderId, System.Int64? mmdReceivedId, System.Int64? mmdReplyId, System.String mmdMessageType, System.String mmdMessageTitle, System.String mmdMessageSubject, System.String mmdDescription, System.String mmdMessageText, System.String mmdMessageRemarks, System.Int32? mmdReadStatus, System.DateTime? mmdSendDate, System.DateTime? mmdDate, System.String mmdAddedByType, System.Int32? mmdStatus)
	{
		Update(mmdMessageId, mmdLoginId, mmdSenderId, mmdReceivedId, mmdReplyId, mmdMessageType, mmdMessageTitle, mmdMessageSubject, mmdDescription, mmdMessageText, mmdMessageRemarks, mmdReadStatus, mmdSendDate, mmdDate, mmdAddedByType, mmdStatus, null);
	}
	
	public static void Update(TMSMySMSDetails tMSMySMSDetails)
	{
		tMSMySMSDetails.Update();
	}
	
	public static void Update(TMSMySMSDetails tMSMySMSDetails, DbTransaction transaction)
	{
		tMSMySMSDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSMySMSDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@mmdMessageId"].SourceColumn = "MMD_MessageId";
		dbCommand.Parameters["@mmdLoginId"].SourceColumn = "MMD_LoginId";
		dbCommand.Parameters["@mmdSenderId"].SourceColumn = "MMD_SenderId";
		dbCommand.Parameters["@mmdReceivedId"].SourceColumn = "MMD_ReceivedId";
		dbCommand.Parameters["@mmdReplyId"].SourceColumn = "MMD_ReplyId";
		dbCommand.Parameters["@mmdMessageType"].SourceColumn = "MMD_MessageType";
		dbCommand.Parameters["@mmdMessageTitle"].SourceColumn = "MMD_MessageTitle";
		dbCommand.Parameters["@mmdMessageSubject"].SourceColumn = "MMD_MessageSubject";
		dbCommand.Parameters["@mmdDescription"].SourceColumn = "MMD_Description";
		dbCommand.Parameters["@mmdMessageText"].SourceColumn = "MMD_MessageText";
		dbCommand.Parameters["@mmdMessageRemarks"].SourceColumn = "MMD_MessageRemarks";
		dbCommand.Parameters["@mmdReadStatus"].SourceColumn = "MMD_ReadStatus";
		dbCommand.Parameters["@mmdSendDate"].SourceColumn = "MMD_SendDate";
		dbCommand.Parameters["@mmdDate"].SourceColumn = "MMD_Date";
		dbCommand.Parameters["@mmdAddedByType"].SourceColumn = "MMD_AddedByType";
		dbCommand.Parameters["@mmdStatus"].SourceColumn = "MMD_Status";
		
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
	public static void Delete(System.Int64? mmdMessageId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSMySMSDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, mmdMessageId);
		
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
	public static void Delete(System.Int64? mmdMessageId)
	{
		Delete(
		mmdMessageId);
	}
	
	/// <summary>
	/// Delete current TMSMySMSDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSMySMSDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, MMDMessageId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.MMDMessageId = null;
	}
	
	/// <summary>
	/// Delete current TMSMySMSDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSMySMSDetails[] Search(System.Int64? mmdMessageId, System.Int64? mmdLoginId, System.Int64? mmdSenderId, System.Int64? mmdReceivedId, System.Int64? mmdReplyId, System.String mmdMessageType, System.String mmdMessageTitle, System.String mmdMessageSubject, System.String mmdDescription, System.String mmdMessageText, System.String mmdMessageRemarks, System.Int32? mmdReadStatus, System.DateTime? mmdSendDate, System.DateTime? mmdDate, System.String mmdAddedByType, System.Int32? mmdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSMySMSDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, mmdMessageId, mmdLoginId, mmdSenderId, mmdReceivedId, mmdReplyId, mmdMessageType, mmdMessageTitle, mmdMessageSubject, mmdDescription, mmdMessageText, mmdMessageRemarks, mmdReadStatus, mmdSendDate, mmdDate, mmdAddedByType, mmdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSMySMSDetails.MapFrom(ds);
	}
	
	
	public static TMSMySMSDetails[] Search(TMSMySMSDetails searchObject)
	{
		return Search ( searchObject.MMDMessageId, searchObject.MMDLoginId, searchObject.MMDSenderId, searchObject.MMDReceivedId, searchObject.MMDReplyId, searchObject.MMDMessageType, searchObject.MMDMessageTitle, searchObject.MMDMessageSubject, searchObject.MMDDescription, searchObject.MMDMessageText, searchObject.MMDMessageRemarks, searchObject.MMDReadStatus, searchObject.MMDSendDate, searchObject.MMDDate, searchObject.MMDAddedByType, searchObject.MMDStatus);
	}
	
	/// <summary>
	/// Returns all TMSMySMSDetails objects.
	/// </summary>
	/// <returns>List of all TMSMySMSDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSMySMSDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

