/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 8/24/2012 11:21:35 AM                                    */
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
public partial class TMSGraceDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_GraceDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _gdGraceId;
	private System.Int64? _gdSchoolId;
	private System.Int64? _sdSubjectId;
	private System.String _sdGraceMarks;
	private System.DateTime? _sdDate;
	private System.Int32? _sdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? GDGraceId
	{
		get
		{
			return _gdGraceId;
		}
		set
		{
			_gdGraceId = value;
		}
	}
	
	public System.Int64? GDSchoolId
	{
		get
		{
			return _gdSchoolId;
		}
		set
		{
			_gdSchoolId = value;
		}
	}
	
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
	
	public System.String SDGraceMarks
	{
		get
		{
			return _sdGraceMarks;
		}
		set
		{
			_sdGraceMarks = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("GD_GraceId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("GD_SchoolId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SD_SubjectId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SD_GraceMarks", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("SD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (GDGraceId == null)
		dr["GD_GraceId"] = DBNull.Value;
		else
		dr["GD_GraceId"] = GDGraceId;
		
		if (GDSchoolId == null)
		dr["GD_SchoolId"] = DBNull.Value;
		else
		dr["GD_SchoolId"] = GDSchoolId;
		
		if (SDSubjectId == null)
		dr["SD_SubjectId"] = DBNull.Value;
		else
		dr["SD_SubjectId"] = SDSubjectId;
		
		if (SDGraceMarks == null)
		dr["SD_GraceMarks"] = DBNull.Value;
		else
		dr["SD_GraceMarks"] = SDGraceMarks;
		
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
		GDGraceId = dr["GD_GraceId"] != DBNull.Value ? Convert.ToInt64(dr["GD_GraceId"]) : GDGraceId = null;
		GDSchoolId = dr["GD_SchoolId"] != DBNull.Value ? Convert.ToInt64(dr["GD_SchoolId"]) : GDSchoolId = null;
		SDSubjectId = dr["SD_SubjectId"] != DBNull.Value ? Convert.ToInt64(dr["SD_SubjectId"]) : SDSubjectId = null;
		SDGraceMarks = dr["SD_GraceMarks"] != DBNull.Value ? Convert.ToString(dr["SD_GraceMarks"]) : SDGraceMarks = null;
		SDDate = dr["SD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["SD_Date"]) : SDDate = null;
		SDStatus = dr["SD_Status"] != DBNull.Value ? Convert.ToInt32(dr["SD_Status"]) : SDStatus = null;
	}
	
	public static TMSGraceDetails[] MapFrom(DataSet ds)
	{
		List<TMSGraceDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSGraceDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_GraceDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_GraceDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSGraceDetails instance = new TMSGraceDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSGraceDetails Get(System.Int64 gdGraceId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSGraceDetails instance;
		
		
		instance = new TMSGraceDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSGraceDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, gdGraceId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSGraceDetails ID:" + gdGraceId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? gdSchoolId, System.Int64? sdSubjectId, System.String sdGraceMarks, System.DateTime? sdDate, System.Int32? sdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSGraceDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, gdSchoolId, sdSubjectId, sdGraceMarks, sdDate, sdStatus);
		
		if (transaction == null)
		this.GDGraceId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.GDGraceId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? gdSchoolId, System.Int64? sdSubjectId, System.String sdGraceMarks, System.DateTime? sdDate, System.Int32? sdStatus)
	{
		Insert(gdSchoolId, sdSubjectId, sdGraceMarks, sdDate, sdStatus, null);
	}
	/// <summary>
	/// Insert current TMSGraceDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(GDSchoolId, SDSubjectId, SDGraceMarks, SDDate, SDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSGraceDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? gdGraceId, System.Int64? gdSchoolId, System.Int64? sdSubjectId, System.String sdGraceMarks, System.DateTime? sdDate, System.Int32? sdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSGraceDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@gdGraceId"].Value = gdGraceId;
		dbCommand.Parameters["@gdSchoolId"].Value = gdSchoolId;
		dbCommand.Parameters["@sdSubjectId"].Value = sdSubjectId;
		dbCommand.Parameters["@sdGraceMarks"].Value = sdGraceMarks;
		dbCommand.Parameters["@sdDate"].Value = sdDate;
		dbCommand.Parameters["@sdStatus"].Value = sdStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? gdGraceId, System.Int64? gdSchoolId, System.Int64? sdSubjectId, System.String sdGraceMarks, System.DateTime? sdDate, System.Int32? sdStatus)
	{
		Update(gdGraceId, gdSchoolId, sdSubjectId, sdGraceMarks, sdDate, sdStatus, null);
	}
	
	public static void Update(TMSGraceDetails tMSGraceDetails)
	{
		tMSGraceDetails.Update();
	}
	
	public static void Update(TMSGraceDetails tMSGraceDetails, DbTransaction transaction)
	{
		tMSGraceDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSGraceDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@gdGraceId"].SourceColumn = "GD_GraceId";
		dbCommand.Parameters["@gdSchoolId"].SourceColumn = "GD_SchoolId";
		dbCommand.Parameters["@sdSubjectId"].SourceColumn = "SD_SubjectId";
		dbCommand.Parameters["@sdGraceMarks"].SourceColumn = "SD_GraceMarks";
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
	public static void Delete(System.Int64? gdGraceId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSGraceDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, gdGraceId);
		
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
	public static void Delete(System.Int64? gdGraceId)
	{
		Delete(
		gdGraceId);
	}
	
	/// <summary>
	/// Delete current TMSGraceDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSGraceDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, GDGraceId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.GDGraceId = null;
	}
	
	/// <summary>
	/// Delete current TMSGraceDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSGraceDetails[] Search(System.Int64? gdGraceId, System.Int64? gdSchoolId, System.Int64? sdSubjectId, System.String sdGraceMarks, System.DateTime? sdDate, System.Int32? sdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSGraceDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, gdGraceId, gdSchoolId, sdSubjectId, sdGraceMarks, sdDate, sdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSGraceDetails.MapFrom(ds);
	}
	
	
	public static TMSGraceDetails[] Search(TMSGraceDetails searchObject)
	{
		return Search ( searchObject.GDGraceId, searchObject.GDSchoolId, searchObject.SDSubjectId, searchObject.SDGraceMarks, searchObject.SDDate, searchObject.SDStatus);
	}
	
	/// <summary>
	/// Returns all TMSGraceDetails objects.
	/// </summary>
	/// <returns>List of all TMSGraceDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSGraceDetails[] Search()
	{
		return Search ( null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

