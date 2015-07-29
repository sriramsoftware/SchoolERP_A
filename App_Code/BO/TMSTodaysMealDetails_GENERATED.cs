/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 7/10/2012 11:37:46 AM                                    */
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
public partial class TMSTodaysMealDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_TodaysMealDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _tmdMealId;
	private System.Int64? _tmdSchooId;
	private System.Int64? _tmdSchoolSubId;
	private System.DateTime? _tmdMealDate;
	private System.String _tmdMealImage;
	private System.String _tmdMealMenu;
	private System.String _tmdMealDescription;
	private System.DateTime? _tmdDate;
	private System.Int32? _tmdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? TMDMealId
	{
		get
		{
			return _tmdMealId;
		}
		set
		{
			_tmdMealId = value;
		}
	}
	
	public System.Int64? TMDSchooId
	{
		get
		{
			return _tmdSchooId;
		}
		set
		{
			_tmdSchooId = value;
		}
	}
	
	public System.Int64? TMDSchoolSubId
	{
		get
		{
			return _tmdSchoolSubId;
		}
		set
		{
			_tmdSchoolSubId = value;
		}
	}
	
	public System.DateTime? TMDMealDate
	{
		get
		{
			return _tmdMealDate;
		}
		set
		{
			_tmdMealDate = value;
		}
	}
	
	public System.String TMDMealImage
	{
		get
		{
			return _tmdMealImage;
		}
		set
		{
			_tmdMealImage = value;
		}
	}
	
	public System.String TMDMealMenu
	{
		get
		{
			return _tmdMealMenu;
		}
		set
		{
			_tmdMealMenu = value;
		}
	}
	
	public System.String TMDMealDescription
	{
		get
		{
			return _tmdMealDescription;
		}
		set
		{
			_tmdMealDescription = value;
		}
	}
	
	public System.DateTime? TMDDate
	{
		get
		{
			return _tmdDate;
		}
		set
		{
			_tmdDate = value;
		}
	}
	
	public System.Int32? TMDStatus
	{
		get
		{
			return _tmdStatus;
		}
		set
		{
			_tmdStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("TMD_MealId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("TMD_SchooId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("TMD_SchoolSubId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("TMD_MealDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("TMD_MealImage", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TMD_MealMenu", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TMD_MealDescription", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TMD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("TMD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (TMDMealId == null)
		dr["TMD_MealId"] = DBNull.Value;
		else
		dr["TMD_MealId"] = TMDMealId;
		
		if (TMDSchooId == null)
		dr["TMD_SchooId"] = DBNull.Value;
		else
		dr["TMD_SchooId"] = TMDSchooId;
		
		if (TMDSchoolSubId == null)
		dr["TMD_SchoolSubId"] = DBNull.Value;
		else
		dr["TMD_SchoolSubId"] = TMDSchoolSubId;
		
		if (TMDMealDate == null)
		dr["TMD_MealDate"] = DBNull.Value;
		else
		dr["TMD_MealDate"] = TMDMealDate;
		
		if (TMDMealImage == null)
		dr["TMD_MealImage"] = DBNull.Value;
		else
		dr["TMD_MealImage"] = TMDMealImage;
		
		if (TMDMealMenu == null)
		dr["TMD_MealMenu"] = DBNull.Value;
		else
		dr["TMD_MealMenu"] = TMDMealMenu;
		
		if (TMDMealDescription == null)
		dr["TMD_MealDescription"] = DBNull.Value;
		else
		dr["TMD_MealDescription"] = TMDMealDescription;
		
		if (TMDDate == null)
		dr["TMD_Date"] = DBNull.Value;
		else
		dr["TMD_Date"] = TMDDate;
		
		if (TMDStatus == null)
		dr["TMD_Status"] = DBNull.Value;
		else
		dr["TMD_Status"] = TMDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		TMDMealId = dr["TMD_MealId"] != DBNull.Value ? Convert.ToInt64(dr["TMD_MealId"]) : TMDMealId = null;
		TMDSchooId = dr["TMD_SchooId"] != DBNull.Value ? Convert.ToInt64(dr["TMD_SchooId"]) : TMDSchooId = null;
		TMDSchoolSubId = dr["TMD_SchoolSubId"] != DBNull.Value ? Convert.ToInt64(dr["TMD_SchoolSubId"]) : TMDSchoolSubId = null;
		TMDMealDate = dr["TMD_MealDate"] != DBNull.Value ? Convert.ToDateTime(dr["TMD_MealDate"]) : TMDMealDate = null;
		TMDMealImage = dr["TMD_MealImage"] != DBNull.Value ? Convert.ToString(dr["TMD_MealImage"]) : TMDMealImage = null;
		TMDMealMenu = dr["TMD_MealMenu"] != DBNull.Value ? Convert.ToString(dr["TMD_MealMenu"]) : TMDMealMenu = null;
		TMDMealDescription = dr["TMD_MealDescription"] != DBNull.Value ? Convert.ToString(dr["TMD_MealDescription"]) : TMDMealDescription = null;
		TMDDate = dr["TMD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["TMD_Date"]) : TMDDate = null;
		TMDStatus = dr["TMD_Status"] != DBNull.Value ? Convert.ToInt32(dr["TMD_Status"]) : TMDStatus = null;
	}
	
	public static TMSTodaysMealDetails[] MapFrom(DataSet ds)
	{
		List<TMSTodaysMealDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSTodaysMealDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_TodaysMealDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_TodaysMealDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSTodaysMealDetails instance = new TMSTodaysMealDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSTodaysMealDetails Get(System.Int64 tmdMealId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSTodaysMealDetails instance;
		
		
		instance = new TMSTodaysMealDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTodaysMealDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, tmdMealId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSTodaysMealDetails ID:" + tmdMealId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? tmdSchooId, System.Int64? tmdSchoolSubId, System.DateTime? tmdMealDate, System.String tmdMealImage, System.String tmdMealMenu, System.String tmdMealDescription, System.DateTime? tmdDate, System.Int32? tmdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTodaysMealDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, tmdSchooId, tmdSchoolSubId, tmdMealDate, tmdMealImage, tmdMealMenu, tmdMealDescription, tmdDate, tmdStatus);
		
		if (transaction == null)
		this.TMDMealId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.TMDMealId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? tmdSchooId, System.Int64? tmdSchoolSubId, System.DateTime? tmdMealDate, System.String tmdMealImage, System.String tmdMealMenu, System.String tmdMealDescription, System.DateTime? tmdDate, System.Int32? tmdStatus)
	{
		Insert(tmdSchooId, tmdSchoolSubId, tmdMealDate, tmdMealImage, tmdMealMenu, tmdMealDescription, tmdDate, tmdStatus, null);
	}
	/// <summary>
	/// Insert current TMSTodaysMealDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(TMDSchooId, TMDSchoolSubId, TMDMealDate, TMDMealImage, TMDMealMenu, TMDMealDescription, TMDDate, TMDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSTodaysMealDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? tmdMealId, System.Int64? tmdSchooId, System.Int64? tmdSchoolSubId, System.DateTime? tmdMealDate, System.String tmdMealImage, System.String tmdMealMenu, System.String tmdMealDescription, System.DateTime? tmdDate, System.Int32? tmdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTodaysMealDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@tmdMealId"].Value = tmdMealId;
		dbCommand.Parameters["@tmdSchooId"].Value = tmdSchooId;
		dbCommand.Parameters["@tmdSchoolSubId"].Value = tmdSchoolSubId;
		dbCommand.Parameters["@tmdMealDate"].Value = tmdMealDate;
		dbCommand.Parameters["@tmdMealImage"].Value = tmdMealImage;
		dbCommand.Parameters["@tmdMealMenu"].Value = tmdMealMenu;
		dbCommand.Parameters["@tmdMealDescription"].Value = tmdMealDescription;
		dbCommand.Parameters["@tmdDate"].Value = tmdDate;
		dbCommand.Parameters["@tmdStatus"].Value = tmdStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? tmdMealId, System.Int64? tmdSchooId, System.Int64? tmdSchoolSubId, System.DateTime? tmdMealDate, System.String tmdMealImage, System.String tmdMealMenu, System.String tmdMealDescription, System.DateTime? tmdDate, System.Int32? tmdStatus)
	{
		Update(tmdMealId, tmdSchooId, tmdSchoolSubId, tmdMealDate, tmdMealImage, tmdMealMenu, tmdMealDescription, tmdDate, tmdStatus, null);
	}
	
	public static void Update(TMSTodaysMealDetails tMSTodaysMealDetails)
	{
		tMSTodaysMealDetails.Update();
	}
	
	public static void Update(TMSTodaysMealDetails tMSTodaysMealDetails, DbTransaction transaction)
	{
		tMSTodaysMealDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSTodaysMealDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@tmdMealId"].SourceColumn = "TMD_MealId";
		dbCommand.Parameters["@tmdSchooId"].SourceColumn = "TMD_SchooId";
		dbCommand.Parameters["@tmdSchoolSubId"].SourceColumn = "TMD_SchoolSubId";
		dbCommand.Parameters["@tmdMealDate"].SourceColumn = "TMD_MealDate";
		dbCommand.Parameters["@tmdMealImage"].SourceColumn = "TMD_MealImage";
		dbCommand.Parameters["@tmdMealMenu"].SourceColumn = "TMD_MealMenu";
		dbCommand.Parameters["@tmdMealDescription"].SourceColumn = "TMD_MealDescription";
		dbCommand.Parameters["@tmdDate"].SourceColumn = "TMD_Date";
		dbCommand.Parameters["@tmdStatus"].SourceColumn = "TMD_Status";
		
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
	public static void Delete(System.Int64? tmdMealId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTodaysMealDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, tmdMealId);
		
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
	public static void Delete(System.Int64? tmdMealId)
	{
		Delete(
		tmdMealId);
	}
	
	/// <summary>
	/// Delete current TMSTodaysMealDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTodaysMealDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, TMDMealId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.TMDMealId = null;
	}
	
	/// <summary>
	/// Delete current TMSTodaysMealDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSTodaysMealDetails[] Search(System.Int64? tmdMealId, System.Int64? tmdSchooId, System.Int64? tmdSchoolSubId, System.DateTime? tmdMealDate, System.String tmdMealImage, System.String tmdMealMenu, System.String tmdMealDescription, System.DateTime? tmdDate, System.Int32? tmdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTodaysMealDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, tmdMealId, tmdSchooId, tmdSchoolSubId, tmdMealDate, tmdMealImage, tmdMealMenu, tmdMealDescription, tmdDate, tmdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSTodaysMealDetails.MapFrom(ds);
	}
	
	
	public static TMSTodaysMealDetails[] Search(TMSTodaysMealDetails searchObject)
	{
		return Search ( searchObject.TMDMealId, searchObject.TMDSchooId, searchObject.TMDSchoolSubId, searchObject.TMDMealDate, searchObject.TMDMealImage, searchObject.TMDMealMenu, searchObject.TMDMealDescription, searchObject.TMDDate, searchObject.TMDStatus);
	}
	
	/// <summary>
	/// Returns all TMSTodaysMealDetails objects.
	/// </summary>
	/// <returns>List of all TMSTodaysMealDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSTodaysMealDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

