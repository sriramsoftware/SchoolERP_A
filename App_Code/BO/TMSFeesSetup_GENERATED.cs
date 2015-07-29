/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 25/07/2015 04:17:54 PM                                    */
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
public partial class TMSFeesSetup
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_FeesSetup]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _feesSetupID;
	private System.Int32? _schoolCategoryID;
	private System.Int32? _feesCategoryID;
	private System.Int64? _feesTermID;
	private System.Int32? _feesHeadID;
	private System.Int32? _studentTypeID;
	private System.Decimal? _feesAmount;
	private System.DateTime? _createdDate;
	private System.Boolean? _isDelete;
	
	#endregion
	
	
	#region Properties
	public System.Int64? FeesSetupID
	{
		get
		{
			return _feesSetupID;
		}
		set
		{
			_feesSetupID = value;
		}
	}
	
	public System.Int32? SchoolCategoryID
	{
		get
		{
			return _schoolCategoryID;
		}
		set
		{
			_schoolCategoryID = value;
		}
	}
	
	public System.Int32? FeesCategoryID
	{
		get
		{
			return _feesCategoryID;
		}
		set
		{
			_feesCategoryID = value;
		}
	}
	
	public System.Int64? FeesTermID
	{
		get
		{
			return _feesTermID;
		}
		set
		{
			_feesTermID = value;
		}
	}
	
	public System.Int32? FeesHeadID
	{
		get
		{
			return _feesHeadID;
		}
		set
		{
			_feesHeadID = value;
		}
	}
	
	public System.Int32? StudentTypeID
	{
		get
		{
			return _studentTypeID;
		}
		set
		{
			_studentTypeID = value;
		}
	}
	
	public System.Decimal? FeesAmount
	{
		get
		{
			return _feesAmount;
		}
		set
		{
			_feesAmount = value;
		}
	}
	
	public System.DateTime? CreatedDate
	{
		get
		{
			return _createdDate;
		}
		set
		{
			_createdDate = value;
		}
	}
	
	public System.Boolean? IsDelete
	{
		get
		{
			return _isDelete;
		}
		set
		{
			_isDelete = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("FeesSetupID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SchoolCategoryID", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("FeesCategoryID", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("FeesTermID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("FeesHeadID", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("StudentTypeID", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("FeesAmount", typeof(System.Decimal) );
		ds.Tables[TABLE_NAME].Columns.Add("CreatedDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("IsDelete", typeof(System.Boolean) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (FeesSetupID == null)
		dr["FeesSetupID"] = DBNull.Value;
		else
		dr["FeesSetupID"] = FeesSetupID;
		
		if (SchoolCategoryID == null)
		dr["SchoolCategoryID"] = DBNull.Value;
		else
		dr["SchoolCategoryID"] = SchoolCategoryID;
		
		if (FeesCategoryID == null)
		dr["FeesCategoryID"] = DBNull.Value;
		else
		dr["FeesCategoryID"] = FeesCategoryID;
		
		if (FeesTermID == null)
		dr["FeesTermID"] = DBNull.Value;
		else
		dr["FeesTermID"] = FeesTermID;
		
		if (FeesHeadID == null)
		dr["FeesHeadID"] = DBNull.Value;
		else
		dr["FeesHeadID"] = FeesHeadID;
		
		if (StudentTypeID == null)
		dr["StudentTypeID"] = DBNull.Value;
		else
		dr["StudentTypeID"] = StudentTypeID;
		
		if (FeesAmount == null)
		dr["FeesAmount"] = DBNull.Value;
		else
		dr["FeesAmount"] = FeesAmount;
		
		if (CreatedDate == null)
		dr["CreatedDate"] = DBNull.Value;
		else
		dr["CreatedDate"] = CreatedDate;
		
		if (IsDelete == null)
		dr["IsDelete"] = DBNull.Value;
		else
		dr["IsDelete"] = IsDelete;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		FeesSetupID = dr["FeesSetupID"] != DBNull.Value ? Convert.ToInt64(dr["FeesSetupID"]) : FeesSetupID = null;
		SchoolCategoryID = dr["SchoolCategoryID"] != DBNull.Value ? Convert.ToInt32(dr["SchoolCategoryID"]) : SchoolCategoryID = null;
		FeesCategoryID = dr["FeesCategoryID"] != DBNull.Value ? Convert.ToInt32(dr["FeesCategoryID"]) : FeesCategoryID = null;
		FeesTermID = dr["FeesTermID"] != DBNull.Value ? Convert.ToInt64(dr["FeesTermID"]) : FeesTermID = null;
		FeesHeadID = dr["FeesHeadID"] != DBNull.Value ? Convert.ToInt32(dr["FeesHeadID"]) : FeesHeadID = null;
		StudentTypeID = dr["StudentTypeID"] != DBNull.Value ? Convert.ToInt32(dr["StudentTypeID"]) : StudentTypeID = null;
		FeesAmount = dr["FeesAmount"] != DBNull.Value ? Convert.ToDecimal(dr["FeesAmount"]) : FeesAmount = null;
		CreatedDate = dr["CreatedDate"] != DBNull.Value ? Convert.ToDateTime(dr["CreatedDate"]) : CreatedDate = null;
		IsDelete = dr["IsDelete"] != DBNull.Value ? Convert.ToBoolean(dr["IsDelete"]) : IsDelete = null;
	}
	
	public static TMSFeesSetup[] MapFrom(DataSet ds)
	{
		List<TMSFeesSetup> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSFeesSetup>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_FeesSetup] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_FeesSetup] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSFeesSetup instance = new TMSFeesSetup();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSFeesSetup Get(System.Int64 feesSetupID)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSFeesSetup instance;
		
		
		instance = new TMSFeesSetup();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesSetup_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, feesSetupID);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSFeesSetup ID:" + feesSetupID.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int32? schoolCategoryID, System.Int32? feesCategoryID, System.Int64? feesTermID, System.Int32? feesHeadID, System.Int32? studentTypeID, System.Decimal? feesAmount, System.DateTime? createdDate, System.Boolean? isDelete, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesSetup_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, schoolCategoryID, feesCategoryID, feesTermID, feesHeadID, studentTypeID, feesAmount, createdDate, isDelete);
		
		if (transaction == null)
		this.FeesSetupID = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.FeesSetupID = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int32? schoolCategoryID, System.Int32? feesCategoryID, System.Int64? feesTermID, System.Int32? feesHeadID, System.Int32? studentTypeID, System.Decimal? feesAmount, System.DateTime? createdDate, System.Boolean? isDelete)
	{
		Insert(schoolCategoryID, feesCategoryID, feesTermID, feesHeadID, studentTypeID, feesAmount, createdDate, isDelete, null);
	}
	/// <summary>
	/// Insert current TMSFeesSetup to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(SchoolCategoryID, FeesCategoryID, FeesTermID, FeesHeadID, StudentTypeID, FeesAmount, CreatedDate, IsDelete, transaction);
	}
	
	/// <summary>
	/// Insert current TMSFeesSetup to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? feesSetupID, System.Int32? schoolCategoryID, System.Int32? feesCategoryID, System.Int64? feesTermID, System.Int32? feesHeadID, System.Int32? studentTypeID, System.Decimal? feesAmount, System.DateTime? createdDate, System.Boolean? isDelete, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesSetup_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@feesSetupID"].Value = feesSetupID;
		dbCommand.Parameters["@schoolCategoryID"].Value = schoolCategoryID;
		dbCommand.Parameters["@feesCategoryID"].Value = feesCategoryID;
		dbCommand.Parameters["@feesTermID"].Value = feesTermID;
		dbCommand.Parameters["@feesHeadID"].Value = feesHeadID;
		dbCommand.Parameters["@studentTypeID"].Value = studentTypeID;
		dbCommand.Parameters["@feesAmount"].Value = feesAmount;
		dbCommand.Parameters["@createdDate"].Value = createdDate;
		dbCommand.Parameters["@isDelete"].Value = isDelete;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? feesSetupID, System.Int32? schoolCategoryID, System.Int32? feesCategoryID, System.Int64? feesTermID, System.Int32? feesHeadID, System.Int32? studentTypeID, System.Decimal? feesAmount, System.DateTime? createdDate, System.Boolean? isDelete)
	{
		Update(feesSetupID, schoolCategoryID, feesCategoryID, feesTermID, feesHeadID, studentTypeID, feesAmount, createdDate, isDelete, null);
	}
	
	public static void Update(TMSFeesSetup tMSFeesSetup)
	{
		tMSFeesSetup.Update();
	}
	
	public static void Update(TMSFeesSetup tMSFeesSetup, DbTransaction transaction)
	{
		tMSFeesSetup.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSFeesSetup_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@feesSetupID"].SourceColumn = "FeesSetupID";
		dbCommand.Parameters["@schoolCategoryID"].SourceColumn = "SchoolCategoryID";
		dbCommand.Parameters["@feesCategoryID"].SourceColumn = "FeesCategoryID";
		dbCommand.Parameters["@feesTermID"].SourceColumn = "FeesTermID";
		dbCommand.Parameters["@feesHeadID"].SourceColumn = "FeesHeadID";
		dbCommand.Parameters["@studentTypeID"].SourceColumn = "StudentTypeID";
		dbCommand.Parameters["@feesAmount"].SourceColumn = "FeesAmount";
		dbCommand.Parameters["@createdDate"].SourceColumn = "CreatedDate";
		dbCommand.Parameters["@isDelete"].SourceColumn = "IsDelete";
		
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
	public static void Delete(System.Int64? feesSetupID, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesSetup_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, feesSetupID);
		
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
	public static void Delete(System.Int64? feesSetupID)
	{
		Delete(
		feesSetupID);
	}
	
	/// <summary>
	/// Delete current TMSFeesSetup from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesSetup_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, FeesSetupID);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.FeesSetupID = null;
	}
	
	/// <summary>
	/// Delete current TMSFeesSetup from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSFeesSetup[] Search(System.Int64? feesSetupID, System.Int32? schoolCategoryID, System.Int32? feesCategoryID, System.Int64? feesTermID, System.Int32? feesHeadID, System.Int32? studentTypeID, System.Decimal? feesAmount, System.DateTime? createdDate, System.Boolean? isDelete)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesSetup_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, feesSetupID, schoolCategoryID, feesCategoryID, feesTermID, feesHeadID, studentTypeID, feesAmount, createdDate, isDelete);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSFeesSetup.MapFrom(ds);
	}
	
	
	public static TMSFeesSetup[] Search(TMSFeesSetup searchObject)
	{
		return Search ( searchObject.FeesSetupID, searchObject.SchoolCategoryID, searchObject.FeesCategoryID, searchObject.FeesTermID, searchObject.FeesHeadID, searchObject.StudentTypeID, searchObject.FeesAmount, searchObject.CreatedDate, searchObject.IsDelete);
	}
	
	/// <summary>
	/// Returns all TMSFeesSetup objects.
	/// </summary>
	/// <returns>List of all TMSFeesSetup objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSFeesSetup[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

