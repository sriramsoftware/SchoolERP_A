/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 11/6/2012 11:58:53 AM                                    */
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
public partial class TMSCoScholasticGradeDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_CoScholasticGradeDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _sgpGradeId;
	private System.String _sgpGradeName;
	private System.Int32? _sgpGradePoint;
	private System.DateTime? _sgpDate;
	private System.Int32? _sgpStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? SGPGradeId
	{
		get
		{
			return _sgpGradeId;
		}
		set
		{
			_sgpGradeId = value;
		}
	}
	
	public System.String SGPGradeName
	{
		get
		{
			return _sgpGradeName;
		}
		set
		{
			_sgpGradeName = value;
		}
	}
	
	public System.Int32? SGPGradePoint
	{
		get
		{
			return _sgpGradePoint;
		}
		set
		{
			_sgpGradePoint = value;
		}
	}
	
	public System.DateTime? SGPDate
	{
		get
		{
			return _sgpDate;
		}
		set
		{
			_sgpDate = value;
		}
	}
	
	public System.Int32? SGPStatus
	{
		get
		{
			return _sgpStatus;
		}
		set
		{
			_sgpStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("SGP_GradeId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SGP_GradeName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SGP_GradePoint", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("SGP_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("SGP_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (SGPGradeId == null)
		dr["SGP_GradeId"] = DBNull.Value;
		else
		dr["SGP_GradeId"] = SGPGradeId;
		
		if (SGPGradeName == null)
		dr["SGP_GradeName"] = DBNull.Value;
		else
		dr["SGP_GradeName"] = SGPGradeName;
		
		if (SGPGradePoint == null)
		dr["SGP_GradePoint"] = DBNull.Value;
		else
		dr["SGP_GradePoint"] = SGPGradePoint;
		
		if (SGPDate == null)
		dr["SGP_Date"] = DBNull.Value;
		else
		dr["SGP_Date"] = SGPDate;
		
		if (SGPStatus == null)
		dr["SGP_Status"] = DBNull.Value;
		else
		dr["SGP_Status"] = SGPStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		SGPGradeId = dr["SGP_GradeId"] != DBNull.Value ? Convert.ToInt64(dr["SGP_GradeId"]) : SGPGradeId = null;
		SGPGradeName = dr["SGP_GradeName"] != DBNull.Value ? Convert.ToString(dr["SGP_GradeName"]) : SGPGradeName = null;
		SGPGradePoint = dr["SGP_GradePoint"] != DBNull.Value ? Convert.ToInt32(dr["SGP_GradePoint"]) : SGPGradePoint = null;
		SGPDate = dr["SGP_Date"] != DBNull.Value ? Convert.ToDateTime(dr["SGP_Date"]) : SGPDate = null;
		SGPStatus = dr["SGP_Status"] != DBNull.Value ? Convert.ToInt32(dr["SGP_Status"]) : SGPStatus = null;
	}
	
	public static TMSCoScholasticGradeDetails[] MapFrom(DataSet ds)
	{
		List<TMSCoScholasticGradeDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSCoScholasticGradeDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_CoScholasticGradeDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_CoScholasticGradeDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSCoScholasticGradeDetails instance = new TMSCoScholasticGradeDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSCoScholasticGradeDetails Get(System.Int64 sgpGradeId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSCoScholasticGradeDetails instance;
		
		
		instance = new TMSCoScholasticGradeDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCoScholasticGradeDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, sgpGradeId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
        if (ds == null || ds.Tables[0].Rows.Count == 0) //throw new ApplicationException("Could not get TMSCoScholasticGradeDetails ID:" + sgpGradeId.ToString()+ " from Database.");
            // Return results.
            return null;
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String sgpGradeName, System.Int32? sgpGradePoint, System.DateTime? sgpDate, System.Int32? sgpStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCoScholasticGradeDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, sgpGradeName, sgpGradePoint, sgpDate, sgpStatus);
		
		if (transaction == null)
		this.SGPGradeId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.SGPGradeId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String sgpGradeName, System.Int32? sgpGradePoint, System.DateTime? sgpDate, System.Int32? sgpStatus)
	{
		Insert(sgpGradeName, sgpGradePoint, sgpDate, sgpStatus, null);
	}
	/// <summary>
	/// Insert current TMSCoScholasticGradeDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(SGPGradeName, SGPGradePoint, SGPDate, SGPStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSCoScholasticGradeDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? sgpGradeId, System.String sgpGradeName, System.Int32? sgpGradePoint, System.DateTime? sgpDate, System.Int32? sgpStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCoScholasticGradeDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@sgpGradeId"].Value = sgpGradeId;
		dbCommand.Parameters["@sgpGradeName"].Value = sgpGradeName;
		dbCommand.Parameters["@sgpGradePoint"].Value = sgpGradePoint;
		dbCommand.Parameters["@sgpDate"].Value = sgpDate;
		dbCommand.Parameters["@sgpStatus"].Value = sgpStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? sgpGradeId, System.String sgpGradeName, System.Int32? sgpGradePoint, System.DateTime? sgpDate, System.Int32? sgpStatus)
	{
		Update(sgpGradeId, sgpGradeName, sgpGradePoint, sgpDate, sgpStatus, null);
	}
	
	public static void Update(TMSCoScholasticGradeDetails tMSCoScholasticGradeDetails)
	{
		tMSCoScholasticGradeDetails.Update();
	}
	
	public static void Update(TMSCoScholasticGradeDetails tMSCoScholasticGradeDetails, DbTransaction transaction)
	{
		tMSCoScholasticGradeDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSCoScholasticGradeDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@sgpGradeId"].SourceColumn = "SGP_GradeId";
		dbCommand.Parameters["@sgpGradeName"].SourceColumn = "SGP_GradeName";
		dbCommand.Parameters["@sgpGradePoint"].SourceColumn = "SGP_GradePoint";
		dbCommand.Parameters["@sgpDate"].SourceColumn = "SGP_Date";
		dbCommand.Parameters["@sgpStatus"].SourceColumn = "SGP_Status";
		
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
	public static void Delete(System.Int64? sgpGradeId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCoScholasticGradeDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, sgpGradeId);
		
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
	public static void Delete(System.Int64? sgpGradeId)
	{
		Delete(
		sgpGradeId);
	}
	
	/// <summary>
	/// Delete current TMSCoScholasticGradeDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCoScholasticGradeDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, SGPGradeId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.SGPGradeId = null;
	}
	
	/// <summary>
	/// Delete current TMSCoScholasticGradeDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSCoScholasticGradeDetails[] Search(System.Int64? sgpGradeId, System.String sgpGradeName, System.Int32? sgpGradePoint, System.DateTime? sgpDate, System.Int32? sgpStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCoScholasticGradeDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, sgpGradeId, sgpGradeName, sgpGradePoint, sgpDate, sgpStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSCoScholasticGradeDetails.MapFrom(ds);
	}
	
	
	public static TMSCoScholasticGradeDetails[] Search(TMSCoScholasticGradeDetails searchObject)
	{
		return Search ( searchObject.SGPGradeId, searchObject.SGPGradeName, searchObject.SGPGradePoint, searchObject.SGPDate, searchObject.SGPStatus);
	}
	
	/// <summary>
	/// Returns all TMSCoScholasticGradeDetails objects.
	/// </summary>
	/// <returns>List of all TMSCoScholasticGradeDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSCoScholasticGradeDetails[] Search()
	{
		return Search ( null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

