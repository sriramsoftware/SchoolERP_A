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
public partial class TMSFacultyType
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_FacultyType]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _ftFacultyId;
	private System.String _ftFacultyName;
	private System.DateTime? _ftDate;
	private System.Int32? _ftStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? FTFacultyId
	{
		get
		{
			return _ftFacultyId;
		}
		set
		{
			_ftFacultyId = value;
		}
	}
	
	public System.String FTFacultyName
	{
		get
		{
			return _ftFacultyName;
		}
		set
		{
			_ftFacultyName = value;
		}
	}
	
	public System.DateTime? FTDate
	{
		get
		{
			return _ftDate;
		}
		set
		{
			_ftDate = value;
		}
	}
	
	public System.Int32? FTStatus
	{
		get
		{
			return _ftStatus;
		}
		set
		{
			_ftStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("FT_FacultyId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("FT_FacultyName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FT_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("FT_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (FTFacultyId == null)
		dr["FT_FacultyId"] = DBNull.Value;
		else
		dr["FT_FacultyId"] = FTFacultyId;
		
		if (FTFacultyName == null)
		dr["FT_FacultyName"] = DBNull.Value;
		else
		dr["FT_FacultyName"] = FTFacultyName;
		
		if (FTDate == null)
		dr["FT_Date"] = DBNull.Value;
		else
		dr["FT_Date"] = FTDate;
		
		if (FTStatus == null)
		dr["FT_Status"] = DBNull.Value;
		else
		dr["FT_Status"] = FTStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		FTFacultyId = dr["FT_FacultyId"] != DBNull.Value ? Convert.ToInt64(dr["FT_FacultyId"]) : FTFacultyId = null;
		FTFacultyName = dr["FT_FacultyName"] != DBNull.Value ? Convert.ToString(dr["FT_FacultyName"]) : FTFacultyName = null;
		FTDate = dr["FT_Date"] != DBNull.Value ? Convert.ToDateTime(dr["FT_Date"]) : FTDate = null;
		FTStatus = dr["FT_Status"] != DBNull.Value ? Convert.ToInt32(dr["FT_Status"]) : FTStatus = null;
	}
	
	public static TMSFacultyType[] MapFrom(DataSet ds)
	{
		List<TMSFacultyType> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSFacultyType>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_FacultyType] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_FacultyType] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSFacultyType instance = new TMSFacultyType();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSFacultyType Get(System.Int64 ftFacultyId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSFacultyType instance;
		
		
		instance = new TMSFacultyType();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFacultyType_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ftFacultyId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSFacultyType ID:" + ftFacultyId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String ftFacultyName, System.DateTime? ftDate, System.Int32? ftStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFacultyType_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ftFacultyName, ftDate, ftStatus);
		
		if (transaction == null)
		this.FTFacultyId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.FTFacultyId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String ftFacultyName, System.DateTime? ftDate, System.Int32? ftStatus)
	{
		Insert(ftFacultyName, ftDate, ftStatus, null);
	}
	/// <summary>
	/// Insert current TMSFacultyType to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(FTFacultyName, FTDate, FTStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSFacultyType to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? ftFacultyId, System.String ftFacultyName, System.DateTime? ftDate, System.Int32? ftStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFacultyType_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ftFacultyId"].Value = ftFacultyId;
		dbCommand.Parameters["@ftFacultyName"].Value = ftFacultyName;
		dbCommand.Parameters["@ftDate"].Value = ftDate;
		dbCommand.Parameters["@ftStatus"].Value = ftStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? ftFacultyId, System.String ftFacultyName, System.DateTime? ftDate, System.Int32? ftStatus)
	{
		Update(ftFacultyId, ftFacultyName, ftDate, ftStatus, null);
	}
	
	public static void Update(TMSFacultyType tMSFacultyType)
	{
		tMSFacultyType.Update();
	}
	
	public static void Update(TMSFacultyType tMSFacultyType, DbTransaction transaction)
	{
		tMSFacultyType.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSFacultyType_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ftFacultyId"].SourceColumn = "FT_FacultyId";
		dbCommand.Parameters["@ftFacultyName"].SourceColumn = "FT_FacultyName";
		dbCommand.Parameters["@ftDate"].SourceColumn = "FT_Date";
		dbCommand.Parameters["@ftStatus"].SourceColumn = "FT_Status";
		
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
	public static void Delete(System.Int64? ftFacultyId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFacultyType_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ftFacultyId);
		
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
	public static void Delete(System.Int64? ftFacultyId)
	{
		Delete(
		ftFacultyId);
	}
	
	/// <summary>
	/// Delete current TMSFacultyType from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFacultyType_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, FTFacultyId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.FTFacultyId = null;
	}
	
	/// <summary>
	/// Delete current TMSFacultyType from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSFacultyType[] Search(System.Int64? ftFacultyId, System.String ftFacultyName, System.DateTime? ftDate, System.Int32? ftStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFacultyType_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ftFacultyId, ftFacultyName, ftDate, ftStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSFacultyType.MapFrom(ds);
	}
	
	
	public static TMSFacultyType[] Search(TMSFacultyType searchObject)
	{
		return Search ( searchObject.FTFacultyId, searchObject.FTFacultyName, searchObject.FTDate, searchObject.FTStatus);
	}
	
	/// <summary>
	/// Returns all TMSFacultyType objects.
	/// </summary>
	/// <returns>List of all TMSFacultyType objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSFacultyType[] Search()
	{
		return Search ( null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

