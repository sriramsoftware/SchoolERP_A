/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 8/27/2012 11:31:53 AM                                    */
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
public partial class TMSComplaintDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_ComplaintDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _cdComplaintId;
	private System.Int64? _cdSenderId;
	private System.Int64? _cdReceivedId;
	private System.Int64? _cdReplyID;
	private System.String _cdComplaintFor;
	private System.String _cdSubject;
	private System.String _cdDescription;
	private System.Int64? _cdStudentID;
	private System.String _cdSentTo;
	private System.String _cdExtra1;
	private System.String _cdExtra2;
	private System.DateTime? _cdDate;
	private System.Int32? _cdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? CDComplaintId
	{
		get
		{
			return _cdComplaintId;
		}
		set
		{
			_cdComplaintId = value;
		}
	}
	
	public System.Int64? CDSenderId
	{
		get
		{
			return _cdSenderId;
		}
		set
		{
			_cdSenderId = value;
		}
	}
	
	public System.Int64? CDReceivedId
	{
		get
		{
			return _cdReceivedId;
		}
		set
		{
			_cdReceivedId = value;
		}
	}
	
	public System.Int64? CDReplyID
	{
		get
		{
			return _cdReplyID;
		}
		set
		{
			_cdReplyID = value;
		}
	}
	
	public System.String CDComplaintFor
	{
		get
		{
			return _cdComplaintFor;
		}
		set
		{
			_cdComplaintFor = value;
		}
	}
	
	public System.String CDSubject
	{
		get
		{
			return _cdSubject;
		}
		set
		{
			_cdSubject = value;
		}
	}
	
	public System.String CDDescription
	{
		get
		{
			return _cdDescription;
		}
		set
		{
			_cdDescription = value;
		}
	}
	
	public System.Int64? CDStudentID
	{
		get
		{
			return _cdStudentID;
		}
		set
		{
			_cdStudentID = value;
		}
	}
	
	public System.String CDSentTo
	{
		get
		{
			return _cdSentTo;
		}
		set
		{
			_cdSentTo = value;
		}
	}
	
	public System.String CDExtra1
	{
		get
		{
			return _cdExtra1;
		}
		set
		{
			_cdExtra1 = value;
		}
	}
	
	public System.String CDExtra2
	{
		get
		{
			return _cdExtra2;
		}
		set
		{
			_cdExtra2 = value;
		}
	}
	
	public System.DateTime? CDDate
	{
		get
		{
			return _cdDate;
		}
		set
		{
			_cdDate = value;
		}
	}
	
	public System.Int32? CDStatus
	{
		get
		{
			return _cdStatus;
		}
		set
		{
			_cdStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("CD_ComplaintId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("CD_SenderId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("CD_ReceivedId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("CD_ReplyID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("CD_ComplaintFor", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("CD_Subject", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("CD_Description", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("CD_StudentID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("CD_SentTo", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("CD_Extra1", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("CD_Extra2", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("CD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("CD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (CDComplaintId == null)
		dr["CD_ComplaintId"] = DBNull.Value;
		else
		dr["CD_ComplaintId"] = CDComplaintId;
		
		if (CDSenderId == null)
		dr["CD_SenderId"] = DBNull.Value;
		else
		dr["CD_SenderId"] = CDSenderId;
		
		if (CDReceivedId == null)
		dr["CD_ReceivedId"] = DBNull.Value;
		else
		dr["CD_ReceivedId"] = CDReceivedId;
		
		if (CDReplyID == null)
		dr["CD_ReplyID"] = DBNull.Value;
		else
		dr["CD_ReplyID"] = CDReplyID;
		
		if (CDComplaintFor == null)
		dr["CD_ComplaintFor"] = DBNull.Value;
		else
		dr["CD_ComplaintFor"] = CDComplaintFor;
		
		if (CDSubject == null)
		dr["CD_Subject"] = DBNull.Value;
		else
		dr["CD_Subject"] = CDSubject;
		
		if (CDDescription == null)
		dr["CD_Description"] = DBNull.Value;
		else
		dr["CD_Description"] = CDDescription;
		
		if (CDStudentID == null)
		dr["CD_StudentID"] = DBNull.Value;
		else
		dr["CD_StudentID"] = CDStudentID;
		
		if (CDSentTo == null)
		dr["CD_SentTo"] = DBNull.Value;
		else
		dr["CD_SentTo"] = CDSentTo;
		
		if (CDExtra1 == null)
		dr["CD_Extra1"] = DBNull.Value;
		else
		dr["CD_Extra1"] = CDExtra1;
		
		if (CDExtra2 == null)
		dr["CD_Extra2"] = DBNull.Value;
		else
		dr["CD_Extra2"] = CDExtra2;
		
		if (CDDate == null)
		dr["CD_Date"] = DBNull.Value;
		else
		dr["CD_Date"] = CDDate;
		
		if (CDStatus == null)
		dr["CD_Status"] = DBNull.Value;
		else
		dr["CD_Status"] = CDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		CDComplaintId = dr["CD_ComplaintId"] != DBNull.Value ? Convert.ToInt64(dr["CD_ComplaintId"]) : CDComplaintId = null;
		CDSenderId = dr["CD_SenderId"] != DBNull.Value ? Convert.ToInt64(dr["CD_SenderId"]) : CDSenderId = null;
		CDReceivedId = dr["CD_ReceivedId"] != DBNull.Value ? Convert.ToInt64(dr["CD_ReceivedId"]) : CDReceivedId = null;
		CDReplyID = dr["CD_ReplyID"] != DBNull.Value ? Convert.ToInt64(dr["CD_ReplyID"]) : CDReplyID = null;
		CDComplaintFor = dr["CD_ComplaintFor"] != DBNull.Value ? Convert.ToString(dr["CD_ComplaintFor"]) : CDComplaintFor = null;
		CDSubject = dr["CD_Subject"] != DBNull.Value ? Convert.ToString(dr["CD_Subject"]) : CDSubject = null;
		CDDescription = dr["CD_Description"] != DBNull.Value ? Convert.ToString(dr["CD_Description"]) : CDDescription = null;
		CDStudentID = dr["CD_StudentID"] != DBNull.Value ? Convert.ToInt64(dr["CD_StudentID"]) : CDStudentID = null;
		CDSentTo = dr["CD_SentTo"] != DBNull.Value ? Convert.ToString(dr["CD_SentTo"]) : CDSentTo = null;
		CDExtra1 = dr["CD_Extra1"] != DBNull.Value ? Convert.ToString(dr["CD_Extra1"]) : CDExtra1 = null;
		CDExtra2 = dr["CD_Extra2"] != DBNull.Value ? Convert.ToString(dr["CD_Extra2"]) : CDExtra2 = null;
		CDDate = dr["CD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["CD_Date"]) : CDDate = null;
		CDStatus = dr["CD_Status"] != DBNull.Value ? Convert.ToInt32(dr["CD_Status"]) : CDStatus = null;
	}
	
	public static TMSComplaintDetails[] MapFrom(DataSet ds)
	{
		List<TMSComplaintDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSComplaintDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_ComplaintDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_ComplaintDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSComplaintDetails instance = new TMSComplaintDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSComplaintDetails Get(System.Int64 cdComplaintId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSComplaintDetails instance;
		
		
		instance = new TMSComplaintDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSComplaintDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, cdComplaintId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSComplaintDetails ID:" + cdComplaintId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? cdSenderId, System.Int64? cdReceivedId, System.Int64? cdReplyID, System.String cdComplaintFor, System.String cdSubject, System.String cdDescription, System.Int64? cdStudentID, System.String cdSentTo, System.String cdExtra1, System.String cdExtra2, System.DateTime? cdDate, System.Int32? cdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSComplaintDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, cdSenderId, cdReceivedId, cdReplyID, cdComplaintFor, cdSubject, cdDescription, cdStudentID, cdSentTo, cdExtra1, cdExtra2, cdDate, cdStatus);
		
		if (transaction == null)
		this.CDComplaintId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.CDComplaintId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? cdSenderId, System.Int64? cdReceivedId, System.Int64? cdReplyID, System.String cdComplaintFor, System.String cdSubject, System.String cdDescription, System.Int64? cdStudentID, System.String cdSentTo, System.String cdExtra1, System.String cdExtra2, System.DateTime? cdDate, System.Int32? cdStatus)
	{
		Insert(cdSenderId, cdReceivedId, cdReplyID, cdComplaintFor, cdSubject, cdDescription, cdStudentID, cdSentTo, cdExtra1, cdExtra2, cdDate, cdStatus, null);
	}
	/// <summary>
	/// Insert current TMSComplaintDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(CDSenderId, CDReceivedId, CDReplyID, CDComplaintFor, CDSubject, CDDescription, CDStudentID, CDSentTo, CDExtra1, CDExtra2, CDDate, CDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSComplaintDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? cdComplaintId, System.Int64? cdSenderId, System.Int64? cdReceivedId, System.Int64? cdReplyID, System.String cdComplaintFor, System.String cdSubject, System.String cdDescription, System.Int64? cdStudentID, System.String cdSentTo, System.String cdExtra1, System.String cdExtra2, System.DateTime? cdDate, System.Int32? cdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSComplaintDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@cdComplaintId"].Value = cdComplaintId;
		dbCommand.Parameters["@cdSenderId"].Value = cdSenderId;
		dbCommand.Parameters["@cdReceivedId"].Value = cdReceivedId;
		dbCommand.Parameters["@cdReplyID"].Value = cdReplyID;
		dbCommand.Parameters["@cdComplaintFor"].Value = cdComplaintFor;
		dbCommand.Parameters["@cdSubject"].Value = cdSubject;
		dbCommand.Parameters["@cdDescription"].Value = cdDescription;
		dbCommand.Parameters["@cdStudentID"].Value = cdStudentID;
		dbCommand.Parameters["@cdSentTo"].Value = cdSentTo;
		dbCommand.Parameters["@cdExtra1"].Value = cdExtra1;
		dbCommand.Parameters["@cdExtra2"].Value = cdExtra2;
		dbCommand.Parameters["@cdDate"].Value = cdDate;
		dbCommand.Parameters["@cdStatus"].Value = cdStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? cdComplaintId, System.Int64? cdSenderId, System.Int64? cdReceivedId, System.Int64? cdReplyID, System.String cdComplaintFor, System.String cdSubject, System.String cdDescription, System.Int64? cdStudentID, System.String cdSentTo, System.String cdExtra1, System.String cdExtra2, System.DateTime? cdDate, System.Int32? cdStatus)
	{
		Update(cdComplaintId, cdSenderId, cdReceivedId, cdReplyID, cdComplaintFor, cdSubject, cdDescription, cdStudentID, cdSentTo, cdExtra1, cdExtra2, cdDate, cdStatus, null);
	}
	
	public static void Update(TMSComplaintDetails tMSComplaintDetails)
	{
		tMSComplaintDetails.Update();
	}
	
	public static void Update(TMSComplaintDetails tMSComplaintDetails, DbTransaction transaction)
	{
		tMSComplaintDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSComplaintDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@cdComplaintId"].SourceColumn = "CD_ComplaintId";
		dbCommand.Parameters["@cdSenderId"].SourceColumn = "CD_SenderId";
		dbCommand.Parameters["@cdReceivedId"].SourceColumn = "CD_ReceivedId";
		dbCommand.Parameters["@cdReplyID"].SourceColumn = "CD_ReplyID";
		dbCommand.Parameters["@cdComplaintFor"].SourceColumn = "CD_ComplaintFor";
		dbCommand.Parameters["@cdSubject"].SourceColumn = "CD_Subject";
		dbCommand.Parameters["@cdDescription"].SourceColumn = "CD_Description";
		dbCommand.Parameters["@cdStudentID"].SourceColumn = "CD_StudentID";
		dbCommand.Parameters["@cdSentTo"].SourceColumn = "CD_SentTo";
		dbCommand.Parameters["@cdExtra1"].SourceColumn = "CD_Extra1";
		dbCommand.Parameters["@cdExtra2"].SourceColumn = "CD_Extra2";
		dbCommand.Parameters["@cdDate"].SourceColumn = "CD_Date";
		dbCommand.Parameters["@cdStatus"].SourceColumn = "CD_Status";
		
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
	public static void Delete(System.Int64? cdComplaintId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSComplaintDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, cdComplaintId);
		
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
	public static void Delete(System.Int64? cdComplaintId)
	{
		Delete(
		cdComplaintId);
	}
	
	/// <summary>
	/// Delete current TMSComplaintDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSComplaintDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, CDComplaintId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.CDComplaintId = null;
	}
	
	/// <summary>
	/// Delete current TMSComplaintDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSComplaintDetails[] Search(System.Int64? cdComplaintId, System.Int64? cdSenderId, System.Int64? cdReceivedId, System.Int64? cdReplyID, System.String cdComplaintFor, System.String cdSubject, System.String cdDescription, System.Int64? cdStudentID, System.String cdSentTo, System.String cdExtra1, System.String cdExtra2, System.DateTime? cdDate, System.Int32? cdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSComplaintDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, cdComplaintId, cdSenderId, cdReceivedId, cdReplyID, cdComplaintFor, cdSubject, cdDescription, cdStudentID, cdSentTo, cdExtra1, cdExtra2, cdDate, cdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSComplaintDetails.MapFrom(ds);
	}
	
	
	public static TMSComplaintDetails[] Search(TMSComplaintDetails searchObject)
	{
		return Search ( searchObject.CDComplaintId, searchObject.CDSenderId, searchObject.CDReceivedId, searchObject.CDReplyID, searchObject.CDComplaintFor, searchObject.CDSubject, searchObject.CDDescription, searchObject.CDStudentID, searchObject.CDSentTo, searchObject.CDExtra1, searchObject.CDExtra2, searchObject.CDDate, searchObject.CDStatus);
	}
	
	/// <summary>
	/// Returns all TMSComplaintDetails objects.
	/// </summary>
	/// <returns>List of all TMSComplaintDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSComplaintDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

