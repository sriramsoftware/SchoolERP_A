/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 5/24/2012 2:53:46 PM                                    */
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
public partial class TMSAttachmentDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_AttachmentDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _atdAttachmentId;
	private System.Int64? _atdAdmissionId;
	private System.String _atdFileName;
	private System.String _atdFileType;
	private System.DateTime? _atdDate;
	private System.Int32? _atdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? ATDAttachmentId
	{
		get
		{
			return _atdAttachmentId;
		}
		set
		{
			_atdAttachmentId = value;
		}
	}
	
	public System.Int64? ATDAdmissionId
	{
		get
		{
			return _atdAdmissionId;
		}
		set
		{
			_atdAdmissionId = value;
		}
	}
	
	public System.String ATDFileName
	{
		get
		{
			return _atdFileName;
		}
		set
		{
			_atdFileName = value;
		}
	}
	
	public System.String ATDFileType
	{
		get
		{
			return _atdFileType;
		}
		set
		{
			_atdFileType = value;
		}
	}
	
	public System.DateTime? ATDDate
	{
		get
		{
			return _atdDate;
		}
		set
		{
			_atdDate = value;
		}
	}
	
	public System.Int32? ATDStatus
	{
		get
		{
			return _atdStatus;
		}
		set
		{
			_atdStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("ATD_AttachmentId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ATD_AdmissionId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ATD_FileName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ATD_FileType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ATD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("ATD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (ATDAttachmentId == null)
		dr["ATD_AttachmentId"] = DBNull.Value;
		else
		dr["ATD_AttachmentId"] = ATDAttachmentId;
		
		if (ATDAdmissionId == null)
		dr["ATD_AdmissionId"] = DBNull.Value;
		else
		dr["ATD_AdmissionId"] = ATDAdmissionId;
		
		if (ATDFileName == null)
		dr["ATD_FileName"] = DBNull.Value;
		else
		dr["ATD_FileName"] = ATDFileName;
		
		if (ATDFileType == null)
		dr["ATD_FileType"] = DBNull.Value;
		else
		dr["ATD_FileType"] = ATDFileType;
		
		if (ATDDate == null)
		dr["ATD_Date"] = DBNull.Value;
		else
		dr["ATD_Date"] = ATDDate;
		
		if (ATDStatus == null)
		dr["ATD_Status"] = DBNull.Value;
		else
		dr["ATD_Status"] = ATDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		ATDAttachmentId = dr["ATD_AttachmentId"] != DBNull.Value ? Convert.ToInt64(dr["ATD_AttachmentId"]) : ATDAttachmentId = null;
		ATDAdmissionId = dr["ATD_AdmissionId"] != DBNull.Value ? Convert.ToInt64(dr["ATD_AdmissionId"]) : ATDAdmissionId = null;
		ATDFileName = dr["ATD_FileName"] != DBNull.Value ? Convert.ToString(dr["ATD_FileName"]) : ATDFileName = null;
		ATDFileType = dr["ATD_FileType"] != DBNull.Value ? Convert.ToString(dr["ATD_FileType"]) : ATDFileType = null;
		ATDDate = dr["ATD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["ATD_Date"]) : ATDDate = null;
		ATDStatus = dr["ATD_Status"] != DBNull.Value ? Convert.ToInt32(dr["ATD_Status"]) : ATDStatus = null;
	}
	
	public static TMSAttachmentDetails[] MapFrom(DataSet ds)
	{
		List<TMSAttachmentDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSAttachmentDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_AttachmentDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_AttachmentDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSAttachmentDetails instance = new TMSAttachmentDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSAttachmentDetails Get(System.Int64 atdAttachmentId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSAttachmentDetails instance;
		
		
		instance = new TMSAttachmentDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAttachmentDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, atdAttachmentId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSAttachmentDetails ID:" + atdAttachmentId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? atdAdmissionId, System.String atdFileName, System.String atdFileType, System.DateTime? atdDate, System.Int32? atdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAttachmentDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, atdAdmissionId, atdFileName, atdFileType, atdDate, atdStatus);
		
		if (transaction == null)
		this.ATDAttachmentId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.ATDAttachmentId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? atdAdmissionId, System.String atdFileName, System.String atdFileType, System.DateTime? atdDate, System.Int32? atdStatus)
	{
		Insert(atdAdmissionId, atdFileName, atdFileType, atdDate, atdStatus, null);
	}
	/// <summary>
	/// Insert current TMSAttachmentDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(ATDAdmissionId, ATDFileName, ATDFileType, ATDDate, ATDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSAttachmentDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? atdAttachmentId, System.Int64? atdAdmissionId, System.String atdFileName, System.String atdFileType, System.DateTime? atdDate, System.Int32? atdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAttachmentDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@atdAttachmentId"].Value = atdAttachmentId;
		dbCommand.Parameters["@atdAdmissionId"].Value = atdAdmissionId;
		dbCommand.Parameters["@atdFileName"].Value = atdFileName;
		dbCommand.Parameters["@atdFileType"].Value = atdFileType;
		dbCommand.Parameters["@atdDate"].Value = atdDate;
		dbCommand.Parameters["@atdStatus"].Value = atdStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? atdAttachmentId, System.Int64? atdAdmissionId, System.String atdFileName, System.String atdFileType, System.DateTime? atdDate, System.Int32? atdStatus)
	{
		Update(atdAttachmentId, atdAdmissionId, atdFileName, atdFileType, atdDate, atdStatus, null);
	}
	
	public static void Update(TMSAttachmentDetails tMSAttachmentDetails)
	{
		tMSAttachmentDetails.Update();
	}
	
	public static void Update(TMSAttachmentDetails tMSAttachmentDetails, DbTransaction transaction)
	{
		tMSAttachmentDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSAttachmentDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@atdAttachmentId"].SourceColumn = "ATD_AttachmentId";
		dbCommand.Parameters["@atdAdmissionId"].SourceColumn = "ATD_AdmissionId";
		dbCommand.Parameters["@atdFileName"].SourceColumn = "ATD_FileName";
		dbCommand.Parameters["@atdFileType"].SourceColumn = "ATD_FileType";
		dbCommand.Parameters["@atdDate"].SourceColumn = "ATD_Date";
		dbCommand.Parameters["@atdStatus"].SourceColumn = "ATD_Status";
		
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
	public static void Delete(System.Int64? atdAttachmentId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAttachmentDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, atdAttachmentId);
		
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
	public static void Delete(System.Int64? atdAttachmentId)
	{
		Delete(
		atdAttachmentId);
	}
	
	/// <summary>
	/// Delete current TMSAttachmentDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAttachmentDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ATDAttachmentId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.ATDAttachmentId = null;
	}
	
	/// <summary>
	/// Delete current TMSAttachmentDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSAttachmentDetails[] Search(System.Int64? atdAttachmentId, System.Int64? atdAdmissionId, System.String atdFileName, System.String atdFileType, System.DateTime? atdDate, System.Int32? atdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAttachmentDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, atdAttachmentId, atdAdmissionId, atdFileName, atdFileType, atdDate, atdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSAttachmentDetails.MapFrom(ds);
	}
	
	
	public static TMSAttachmentDetails[] Search(TMSAttachmentDetails searchObject)
	{
		return Search ( searchObject.ATDAttachmentId, searchObject.ATDAdmissionId, searchObject.ATDFileName, searchObject.ATDFileType, searchObject.ATDDate, searchObject.ATDStatus);
	}
	
	/// <summary>
	/// Returns all TMSAttachmentDetails objects.
	/// </summary>
	/// <returns>List of all TMSAttachmentDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSAttachmentDetails[] Search()
	{
		return Search ( null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

