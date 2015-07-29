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
public partial class TMSSchoolSubCategory
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_SchoolSubCategory]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _sscSubCategoryId;
	private System.Int64? _sscCategoryId;
	private System.String _sscSubCategoryName;
	private System.DateTime? _sscDate;
	private System.Int32? _sscStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? SSCSubCategoryId
	{
		get
		{
			return _sscSubCategoryId;
		}
		set
		{
			_sscSubCategoryId = value;
		}
	}
	
	public System.Int64? SSCCategoryId
	{
		get
		{
			return _sscCategoryId;
		}
		set
		{
			_sscCategoryId = value;
		}
	}
	
	public System.String SSCSubCategoryName
	{
		get
		{
			return _sscSubCategoryName;
		}
		set
		{
			_sscSubCategoryName = value;
		}
	}
	
	public System.DateTime? SSCDate
	{
		get
		{
			return _sscDate;
		}
		set
		{
			_sscDate = value;
		}
	}
	
	public System.Int32? SSCStatus
	{
		get
		{
			return _sscStatus;
		}
		set
		{
			_sscStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("SSC_SubCategoryId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SSC_CategoryId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SSC_SubCategoryName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SSC_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("SSC_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (SSCSubCategoryId == null)
		dr["SSC_SubCategoryId"] = DBNull.Value;
		else
		dr["SSC_SubCategoryId"] = SSCSubCategoryId;
		
		if (SSCCategoryId == null)
		dr["SSC_CategoryId"] = DBNull.Value;
		else
		dr["SSC_CategoryId"] = SSCCategoryId;
		
		if (SSCSubCategoryName == null)
		dr["SSC_SubCategoryName"] = DBNull.Value;
		else
		dr["SSC_SubCategoryName"] = SSCSubCategoryName;
		
		if (SSCDate == null)
		dr["SSC_Date"] = DBNull.Value;
		else
		dr["SSC_Date"] = SSCDate;
		
		if (SSCStatus == null)
		dr["SSC_Status"] = DBNull.Value;
		else
		dr["SSC_Status"] = SSCStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		SSCSubCategoryId = dr["SSC_SubCategoryId"] != DBNull.Value ? Convert.ToInt64(dr["SSC_SubCategoryId"]) : SSCSubCategoryId = null;
		SSCCategoryId = dr["SSC_CategoryId"] != DBNull.Value ? Convert.ToInt64(dr["SSC_CategoryId"]) : SSCCategoryId = null;
		SSCSubCategoryName = dr["SSC_SubCategoryName"] != DBNull.Value ? Convert.ToString(dr["SSC_SubCategoryName"]) : SSCSubCategoryName = null;
		SSCDate = dr["SSC_Date"] != DBNull.Value ? Convert.ToDateTime(dr["SSC_Date"]) : SSCDate = null;
		SSCStatus = dr["SSC_Status"] != DBNull.Value ? Convert.ToInt32(dr["SSC_Status"]) : SSCStatus = null;
	}
	
	public static TMSSchoolSubCategory[] MapFrom(DataSet ds)
	{
		List<TMSSchoolSubCategory> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSSchoolSubCategory>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_SchoolSubCategory] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_SchoolSubCategory] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSSchoolSubCategory instance = new TMSSchoolSubCategory();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSSchoolSubCategory Get(System.Int64 sscSubCategoryId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSSchoolSubCategory instance;
		
		
		instance = new TMSSchoolSubCategory();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSchoolSubCategory_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, sscSubCategoryId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
        if (ds == null || ds.Tables[0].Rows.Count == 0) //throw new ApplicationException("Could not get TMSSchoolSubCategory ID:" + sscSubCategoryId.ToString()+ " from Database.");
            // Return results.
            return null;
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? sscCategoryId, System.String sscSubCategoryName, System.DateTime? sscDate, System.Int32? sscStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSchoolSubCategory_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, sscCategoryId, sscSubCategoryName, sscDate, sscStatus);
		
		if (transaction == null)
		this.SSCSubCategoryId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.SSCSubCategoryId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? sscCategoryId, System.String sscSubCategoryName, System.DateTime? sscDate, System.Int32? sscStatus)
	{
		Insert(sscCategoryId, sscSubCategoryName, sscDate, sscStatus, null);
	}
	/// <summary>
	/// Insert current TMSSchoolSubCategory to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(SSCCategoryId, SSCSubCategoryName, SSCDate, SSCStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSSchoolSubCategory to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? sscSubCategoryId, System.Int64? sscCategoryId, System.String sscSubCategoryName, System.DateTime? sscDate, System.Int32? sscStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSchoolSubCategory_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@sscSubCategoryId"].Value = sscSubCategoryId;
		dbCommand.Parameters["@sscCategoryId"].Value = sscCategoryId;
		dbCommand.Parameters["@sscSubCategoryName"].Value = sscSubCategoryName;
		dbCommand.Parameters["@sscDate"].Value = sscDate;
		dbCommand.Parameters["@sscStatus"].Value = sscStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? sscSubCategoryId, System.Int64? sscCategoryId, System.String sscSubCategoryName, System.DateTime? sscDate, System.Int32? sscStatus)
	{
		Update(sscSubCategoryId, sscCategoryId, sscSubCategoryName, sscDate, sscStatus, null);
	}
	
	public static void Update(TMSSchoolSubCategory tMSSchoolSubCategory)
	{
		tMSSchoolSubCategory.Update();
	}
	
	public static void Update(TMSSchoolSubCategory tMSSchoolSubCategory, DbTransaction transaction)
	{
		tMSSchoolSubCategory.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSSchoolSubCategory_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@sscSubCategoryId"].SourceColumn = "SSC_SubCategoryId";
		dbCommand.Parameters["@sscCategoryId"].SourceColumn = "SSC_CategoryId";
		dbCommand.Parameters["@sscSubCategoryName"].SourceColumn = "SSC_SubCategoryName";
		dbCommand.Parameters["@sscDate"].SourceColumn = "SSC_Date";
		dbCommand.Parameters["@sscStatus"].SourceColumn = "SSC_Status";
		
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
	public static void Delete(System.Int64? sscSubCategoryId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSchoolSubCategory_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, sscSubCategoryId);
		
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
	public static void Delete(System.Int64? sscSubCategoryId)
	{
		Delete(
		sscSubCategoryId);
	}
	
	/// <summary>
	/// Delete current TMSSchoolSubCategory from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSchoolSubCategory_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, SSCSubCategoryId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.SSCSubCategoryId = null;
	}
	
	/// <summary>
	/// Delete current TMSSchoolSubCategory from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSSchoolSubCategory[] Search(System.Int64? sscSubCategoryId, System.Int64? sscCategoryId, System.String sscSubCategoryName, System.DateTime? sscDate, System.Int32? sscStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSchoolSubCategory_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, sscSubCategoryId, sscCategoryId, sscSubCategoryName, sscDate, sscStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSSchoolSubCategory.MapFrom(ds);
	}
	
	
	public static TMSSchoolSubCategory[] Search(TMSSchoolSubCategory searchObject)
	{
		return Search ( searchObject.SSCSubCategoryId, searchObject.SSCCategoryId, searchObject.SSCSubCategoryName, searchObject.SSCDate, searchObject.SSCStatus);
	}
	
	/// <summary>
	/// Returns all TMSSchoolSubCategory objects.
	/// </summary>
	/// <returns>List of all TMSSchoolSubCategory objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSSchoolSubCategory[] Search()
	{
		return Search ( null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

