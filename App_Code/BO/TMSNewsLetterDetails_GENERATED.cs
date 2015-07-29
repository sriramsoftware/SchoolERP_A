/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 9/17/2012 2:41:06 PM                                    */
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
public partial class TMSNewsLetterDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_NewsLetterDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _ndNewsDetailsId;
	private System.String _ndTitle;
	private System.String _ndSubject;
	private System.String _ndDescription;
	private System.String _ndExtra;
	private System.DateTime? _ndDate;
	private System.Int32? _ndStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? NDNewsDetailsId
	{
		get
		{
			return _ndNewsDetailsId;
		}
		set
		{
			_ndNewsDetailsId = value;
		}
	}
	
	public System.String NDTitle
	{
		get
		{
			return _ndTitle;
		}
		set
		{
			_ndTitle = value;
		}
	}
	
	public System.String NDSubject
	{
		get
		{
			return _ndSubject;
		}
		set
		{
			_ndSubject = value;
		}
	}
	
	public System.String NDDescription
	{
		get
		{
			return _ndDescription;
		}
		set
		{
			_ndDescription = value;
		}
	}
	
	public System.String NDExtra
	{
		get
		{
			return _ndExtra;
		}
		set
		{
			_ndExtra = value;
		}
	}
	
	public System.DateTime? NDDate
	{
		get
		{
			return _ndDate;
		}
		set
		{
			_ndDate = value;
		}
	}
	
	public System.Int32? NDStatus
	{
		get
		{
			return _ndStatus;
		}
		set
		{
			_ndStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("ND_NewsDetailsId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ND_Title", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ND_Subject", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ND_Description", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ND_Extra", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ND_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("ND_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (NDNewsDetailsId == null)
		dr["ND_NewsDetailsId"] = DBNull.Value;
		else
		dr["ND_NewsDetailsId"] = NDNewsDetailsId;
		
		if (NDTitle == null)
		dr["ND_Title"] = DBNull.Value;
		else
		dr["ND_Title"] = NDTitle;
		
		if (NDSubject == null)
		dr["ND_Subject"] = DBNull.Value;
		else
		dr["ND_Subject"] = NDSubject;
		
		if (NDDescription == null)
		dr["ND_Description"] = DBNull.Value;
		else
		dr["ND_Description"] = NDDescription;
		
		if (NDExtra == null)
		dr["ND_Extra"] = DBNull.Value;
		else
		dr["ND_Extra"] = NDExtra;
		
		if (NDDate == null)
		dr["ND_Date"] = DBNull.Value;
		else
		dr["ND_Date"] = NDDate;
		
		if (NDStatus == null)
		dr["ND_Status"] = DBNull.Value;
		else
		dr["ND_Status"] = NDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		NDNewsDetailsId = dr["ND_NewsDetailsId"] != DBNull.Value ? Convert.ToInt64(dr["ND_NewsDetailsId"]) : NDNewsDetailsId = null;
		NDTitle = dr["ND_Title"] != DBNull.Value ? Convert.ToString(dr["ND_Title"]) : NDTitle = null;
		NDSubject = dr["ND_Subject"] != DBNull.Value ? Convert.ToString(dr["ND_Subject"]) : NDSubject = null;
		NDDescription = dr["ND_Description"] != DBNull.Value ? Convert.ToString(dr["ND_Description"]) : NDDescription = null;
		NDExtra = dr["ND_Extra"] != DBNull.Value ? Convert.ToString(dr["ND_Extra"]) : NDExtra = null;
		NDDate = dr["ND_Date"] != DBNull.Value ? Convert.ToDateTime(dr["ND_Date"]) : NDDate = null;
		NDStatus = dr["ND_Status"] != DBNull.Value ? Convert.ToInt32(dr["ND_Status"]) : NDStatus = null;
	}
	
	public static TMSNewsLetterDetails[] MapFrom(DataSet ds)
	{
		List<TMSNewsLetterDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSNewsLetterDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_NewsLetterDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_NewsLetterDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSNewsLetterDetails instance = new TMSNewsLetterDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSNewsLetterDetails Get(System.Int64 ndNewsDetailsId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSNewsLetterDetails instance;
		
		
		instance = new TMSNewsLetterDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSNewsLetterDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ndNewsDetailsId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSNewsLetterDetails ID:" + ndNewsDetailsId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String ndTitle, System.String ndSubject, System.String ndDescription, System.String ndExtra, System.DateTime? ndDate, System.Int32? ndStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSNewsLetterDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ndTitle, ndSubject, ndDescription, ndExtra, ndDate, ndStatus);
		
		if (transaction == null)
		this.NDNewsDetailsId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.NDNewsDetailsId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String ndTitle, System.String ndSubject, System.String ndDescription, System.String ndExtra, System.DateTime? ndDate, System.Int32? ndStatus)
	{
		Insert(ndTitle, ndSubject, ndDescription, ndExtra, ndDate, ndStatus, null);
	}
	/// <summary>
	/// Insert current TMSNewsLetterDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(NDTitle, NDSubject, NDDescription, NDExtra, NDDate, NDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSNewsLetterDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? ndNewsDetailsId, System.String ndTitle, System.String ndSubject, System.String ndDescription, System.String ndExtra, System.DateTime? ndDate, System.Int32? ndStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSNewsLetterDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ndNewsDetailsId"].Value = ndNewsDetailsId;
		dbCommand.Parameters["@ndTitle"].Value = ndTitle;
		dbCommand.Parameters["@ndSubject"].Value = ndSubject;
		dbCommand.Parameters["@ndDescription"].Value = ndDescription;
		dbCommand.Parameters["@ndExtra"].Value = ndExtra;
		dbCommand.Parameters["@ndDate"].Value = ndDate;
		dbCommand.Parameters["@ndStatus"].Value = ndStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? ndNewsDetailsId, System.String ndTitle, System.String ndSubject, System.String ndDescription, System.String ndExtra, System.DateTime? ndDate, System.Int32? ndStatus)
	{
		Update(ndNewsDetailsId, ndTitle, ndSubject, ndDescription, ndExtra, ndDate, ndStatus, null);
	}
	
	public static void Update(TMSNewsLetterDetails tMSNewsLetterDetails)
	{
		tMSNewsLetterDetails.Update();
	}
	
	public static void Update(TMSNewsLetterDetails tMSNewsLetterDetails, DbTransaction transaction)
	{
		tMSNewsLetterDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSNewsLetterDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ndNewsDetailsId"].SourceColumn = "ND_NewsDetailsId";
		dbCommand.Parameters["@ndTitle"].SourceColumn = "ND_Title";
		dbCommand.Parameters["@ndSubject"].SourceColumn = "ND_Subject";
		dbCommand.Parameters["@ndDescription"].SourceColumn = "ND_Description";
		dbCommand.Parameters["@ndExtra"].SourceColumn = "ND_Extra";
		dbCommand.Parameters["@ndDate"].SourceColumn = "ND_Date";
		dbCommand.Parameters["@ndStatus"].SourceColumn = "ND_Status";
		
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
	public static void Delete(System.Int64? ndNewsDetailsId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSNewsLetterDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ndNewsDetailsId);
		
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
	public static void Delete(System.Int64? ndNewsDetailsId)
	{
		Delete(
		ndNewsDetailsId);
	}
	
	/// <summary>
	/// Delete current TMSNewsLetterDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSNewsLetterDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, NDNewsDetailsId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.NDNewsDetailsId = null;
	}
	
	/// <summary>
	/// Delete current TMSNewsLetterDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSNewsLetterDetails[] Search(System.Int64? ndNewsDetailsId, System.String ndTitle, System.String ndSubject, System.String ndDescription, System.String ndExtra, System.DateTime? ndDate, System.Int32? ndStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSNewsLetterDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ndNewsDetailsId, ndTitle, ndSubject, ndDescription, ndExtra, ndDate, ndStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSNewsLetterDetails.MapFrom(ds);
	}
	
	
	public static TMSNewsLetterDetails[] Search(TMSNewsLetterDetails searchObject)
	{
		return Search ( searchObject.NDNewsDetailsId, searchObject.NDTitle, searchObject.NDSubject, searchObject.NDDescription, searchObject.NDExtra, searchObject.NDDate, searchObject.NDStatus);
	}
	
	/// <summary>
	/// Returns all TMSNewsLetterDetails objects.
	/// </summary>
	/// <returns>List of all TMSNewsLetterDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSNewsLetterDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

