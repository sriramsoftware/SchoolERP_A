/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 6/12/2012 1:00:20 PM                                    */
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
public partial class TMSSubjectDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_SubjectDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _sdSubjectId;
	private System.String _sdSubjectName;
	private System.DateTime? _sdDate;
	private System.Int32? _sdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? SDSubjectId
	{
		get
		{
			return _sdSubjectId;
		}
		set
		{
			_sdSubjectId = value;
		}
	}
	
	public System.String SDSubjectName
	{
		get
		{
			return _sdSubjectName;
		}
		set
		{
			_sdSubjectName = value;
		}
	}
	
	public System.DateTime? SDDate
	{
		get
		{
			return _sdDate;
		}
		set
		{
			_sdDate = value;
		}
	}
	
	public System.Int32? SDStatus
	{
		get
		{
			return _sdStatus;
		}
		set
		{
			_sdStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("SD_SubjectId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SD_SubjectName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("SD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (SDSubjectId == null)
		dr["SD_SubjectId"] = DBNull.Value;
		else
		dr["SD_SubjectId"] = SDSubjectId;
		
		if (SDSubjectName == null)
		dr["SD_SubjectName"] = DBNull.Value;
		else
		dr["SD_SubjectName"] = SDSubjectName;
		
		if (SDDate == null)
		dr["SD_Date"] = DBNull.Value;
		else
		dr["SD_Date"] = SDDate;
		
		if (SDStatus == null)
		dr["SD_Status"] = DBNull.Value;
		else
		dr["SD_Status"] = SDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		SDSubjectId = dr["SD_SubjectId"] != DBNull.Value ? Convert.ToInt64(dr["SD_SubjectId"]) : SDSubjectId = null;
		SDSubjectName = dr["SD_SubjectName"] != DBNull.Value ? Convert.ToString(dr["SD_SubjectName"]) : SDSubjectName = null;
		SDDate = dr["SD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["SD_Date"]) : SDDate = null;
		SDStatus = dr["SD_Status"] != DBNull.Value ? Convert.ToInt32(dr["SD_Status"]) : SDStatus = null;
	}
	
	public static TMSSubjectDetails[] MapFrom(DataSet ds)
	{
		List<TMSSubjectDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSSubjectDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_SubjectDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_SubjectDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSSubjectDetails instance = new TMSSubjectDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSSubjectDetails Get(System.Int64 sdSubjectId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSSubjectDetails instance;
		
		
		instance = new TMSSubjectDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSubjectDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, sdSubjectId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
        if (ds == null || ds.Tables[0].Rows.Count == 0) //throw new ApplicationException("Could not get TMSSubjectDetails ID:" + sdSubjectId.ToString()+ " from Database.");
            // Return results.
            return null;
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String sdSubjectName, System.DateTime? sdDate, System.Int32? sdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSubjectDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, sdSubjectName, sdDate, sdStatus);
		
		if (transaction == null)
		this.SDSubjectId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.SDSubjectId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String sdSubjectName, System.DateTime? sdDate, System.Int32? sdStatus)
	{
		Insert(sdSubjectName, sdDate, sdStatus, null);
	}
	/// <summary>
	/// Insert current TMSSubjectDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(SDSubjectName, SDDate, SDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSSubjectDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? sdSubjectId, System.String sdSubjectName, System.DateTime? sdDate, System.Int32? sdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSubjectDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@sdSubjectId"].Value = sdSubjectId;
		dbCommand.Parameters["@sdSubjectName"].Value = sdSubjectName;
		dbCommand.Parameters["@sdDate"].Value = sdDate;
		dbCommand.Parameters["@sdStatus"].Value = sdStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? sdSubjectId, System.String sdSubjectName, System.DateTime? sdDate, System.Int32? sdStatus)
	{
		Update(sdSubjectId, sdSubjectName, sdDate, sdStatus, null);
	}
	
	public static void Update(TMSSubjectDetails tMSSubjectDetails)
	{
		tMSSubjectDetails.Update();
	}
	
	public static void Update(TMSSubjectDetails tMSSubjectDetails, DbTransaction transaction)
	{
		tMSSubjectDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSSubjectDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@sdSubjectId"].SourceColumn = "SD_SubjectId";
		dbCommand.Parameters["@sdSubjectName"].SourceColumn = "SD_SubjectName";
		dbCommand.Parameters["@sdDate"].SourceColumn = "SD_Date";
		dbCommand.Parameters["@sdStatus"].SourceColumn = "SD_Status";
		
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
	public static void Delete(System.Int64? sdSubjectId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSubjectDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, sdSubjectId);
		
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
	public static void Delete(System.Int64? sdSubjectId)
	{
		Delete(
		sdSubjectId);
	}
	
	/// <summary>
	/// Delete current TMSSubjectDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSubjectDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, SDSubjectId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.SDSubjectId = null;
	}
	
	/// <summary>
	/// Delete current TMSSubjectDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSSubjectDetails[] Search(System.Int64? sdSubjectId, System.String sdSubjectName, System.DateTime? sdDate, System.Int32? sdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSubjectDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, sdSubjectId, sdSubjectName, sdDate, sdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSSubjectDetails.MapFrom(ds);
	}
	
	
	public static TMSSubjectDetails[] Search(TMSSubjectDetails searchObject)
	{
		return Search ( searchObject.SDSubjectId, searchObject.SDSubjectName, searchObject.SDDate, searchObject.SDStatus);
	}
	
	/// <summary>
	/// Returns all TMSSubjectDetails objects.
	/// </summary>
	/// <returns>List of all TMSSubjectDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSSubjectDetails[] Search()
	{
		return Search ( null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

