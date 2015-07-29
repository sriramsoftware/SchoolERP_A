/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 7/30/2012 11:33:12 AM                                    */
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
public partial class TMSBookMaintance
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_BookMaintance]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _bmMaintainceId;
	private System.Int64? _bmBookDetailId;
	private System.Int64? _bmLibrarianId;
	private System.Int64? _bmDamageById;
	private System.String _bmTotalDamageCopies;
	private System.String _bmDamageAvailableCopies;
	private System.String _bmCostPerCopies;
	private System.String _bmTotalCost;
	private System.String _bmFor;
	private System.String _bmDamageType;
	private System.String _bmDamageByName;
	private System.DateTime? _bmDate;
	private System.Int32? _bmStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? BMMaintainceId
	{
		get
		{
			return _bmMaintainceId;
		}
		set
		{
			_bmMaintainceId = value;
		}
	}
	
	public System.Int64? BMBookDetailId
	{
		get
		{
			return _bmBookDetailId;
		}
		set
		{
			_bmBookDetailId = value;
		}
	}
	
	public System.Int64? BMLibrarianId
	{
		get
		{
			return _bmLibrarianId;
		}
		set
		{
			_bmLibrarianId = value;
		}
	}
	
	public System.Int64? BMDamageById
	{
		get
		{
			return _bmDamageById;
		}
		set
		{
			_bmDamageById = value;
		}
	}
	
	public System.String BMTotalDamageCopies
	{
		get
		{
			return _bmTotalDamageCopies;
		}
		set
		{
			_bmTotalDamageCopies = value;
		}
	}
	
	public System.String BMDamageAvailableCopies
	{
		get
		{
			return _bmDamageAvailableCopies;
		}
		set
		{
			_bmDamageAvailableCopies = value;
		}
	}
	
	public System.String BMCostPerCopies
	{
		get
		{
			return _bmCostPerCopies;
		}
		set
		{
			_bmCostPerCopies = value;
		}
	}
	
	public System.String BMTotalCost
	{
		get
		{
			return _bmTotalCost;
		}
		set
		{
			_bmTotalCost = value;
		}
	}
	
	public System.String BMFor
	{
		get
		{
			return _bmFor;
		}
		set
		{
			_bmFor = value;
		}
	}
	
	public System.String BMDamageType
	{
		get
		{
			return _bmDamageType;
		}
		set
		{
			_bmDamageType = value;
		}
	}
	
	public System.String BMDamageByName
	{
		get
		{
			return _bmDamageByName;
		}
		set
		{
			_bmDamageByName = value;
		}
	}
	
	public System.DateTime? BMDate
	{
		get
		{
			return _bmDate;
		}
		set
		{
			_bmDate = value;
		}
	}
	
	public System.Int32? BMStatus
	{
		get
		{
			return _bmStatus;
		}
		set
		{
			_bmStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("BM_MaintainceId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BM_BookDetailId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BM_LibrarianId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BM_DamageById", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BM_TotalDamageCopies", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BM_DamageAvailableCopies", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BM_CostPerCopies", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BM_TotalCost", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BM_For", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BM_DamageType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BM_DamageByName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BM_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("BM_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (BMMaintainceId == null)
		dr["BM_MaintainceId"] = DBNull.Value;
		else
		dr["BM_MaintainceId"] = BMMaintainceId;
		
		if (BMBookDetailId == null)
		dr["BM_BookDetailId"] = DBNull.Value;
		else
		dr["BM_BookDetailId"] = BMBookDetailId;
		
		if (BMLibrarianId == null)
		dr["BM_LibrarianId"] = DBNull.Value;
		else
		dr["BM_LibrarianId"] = BMLibrarianId;
		
		if (BMDamageById == null)
		dr["BM_DamageById"] = DBNull.Value;
		else
		dr["BM_DamageById"] = BMDamageById;
		
		if (BMTotalDamageCopies == null)
		dr["BM_TotalDamageCopies"] = DBNull.Value;
		else
		dr["BM_TotalDamageCopies"] = BMTotalDamageCopies;
		
		if (BMDamageAvailableCopies == null)
		dr["BM_DamageAvailableCopies"] = DBNull.Value;
		else
		dr["BM_DamageAvailableCopies"] = BMDamageAvailableCopies;
		
		if (BMCostPerCopies == null)
		dr["BM_CostPerCopies"] = DBNull.Value;
		else
		dr["BM_CostPerCopies"] = BMCostPerCopies;
		
		if (BMTotalCost == null)
		dr["BM_TotalCost"] = DBNull.Value;
		else
		dr["BM_TotalCost"] = BMTotalCost;
		
		if (BMFor == null)
		dr["BM_For"] = DBNull.Value;
		else
		dr["BM_For"] = BMFor;
		
		if (BMDamageType == null)
		dr["BM_DamageType"] = DBNull.Value;
		else
		dr["BM_DamageType"] = BMDamageType;
		
		if (BMDamageByName == null)
		dr["BM_DamageByName"] = DBNull.Value;
		else
		dr["BM_DamageByName"] = BMDamageByName;
		
		if (BMDate == null)
		dr["BM_Date"] = DBNull.Value;
		else
		dr["BM_Date"] = BMDate;
		
		if (BMStatus == null)
		dr["BM_Status"] = DBNull.Value;
		else
		dr["BM_Status"] = BMStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		BMMaintainceId = dr["BM_MaintainceId"] != DBNull.Value ? Convert.ToInt64(dr["BM_MaintainceId"]) : BMMaintainceId = null;
		BMBookDetailId = dr["BM_BookDetailId"] != DBNull.Value ? Convert.ToInt64(dr["BM_BookDetailId"]) : BMBookDetailId = null;
		BMLibrarianId = dr["BM_LibrarianId"] != DBNull.Value ? Convert.ToInt64(dr["BM_LibrarianId"]) : BMLibrarianId = null;
		BMDamageById = dr["BM_DamageById"] != DBNull.Value ? Convert.ToInt64(dr["BM_DamageById"]) : BMDamageById = null;
		BMTotalDamageCopies = dr["BM_TotalDamageCopies"] != DBNull.Value ? Convert.ToString(dr["BM_TotalDamageCopies"]) : BMTotalDamageCopies = null;
		BMDamageAvailableCopies = dr["BM_DamageAvailableCopies"] != DBNull.Value ? Convert.ToString(dr["BM_DamageAvailableCopies"]) : BMDamageAvailableCopies = null;
		BMCostPerCopies = dr["BM_CostPerCopies"] != DBNull.Value ? Convert.ToString(dr["BM_CostPerCopies"]) : BMCostPerCopies = null;
		BMTotalCost = dr["BM_TotalCost"] != DBNull.Value ? Convert.ToString(dr["BM_TotalCost"]) : BMTotalCost = null;
		BMFor = dr["BM_For"] != DBNull.Value ? Convert.ToString(dr["BM_For"]) : BMFor = null;
		BMDamageType = dr["BM_DamageType"] != DBNull.Value ? Convert.ToString(dr["BM_DamageType"]) : BMDamageType = null;
		BMDamageByName = dr["BM_DamageByName"] != DBNull.Value ? Convert.ToString(dr["BM_DamageByName"]) : BMDamageByName = null;
		BMDate = dr["BM_Date"] != DBNull.Value ? Convert.ToDateTime(dr["BM_Date"]) : BMDate = null;
		BMStatus = dr["BM_Status"] != DBNull.Value ? Convert.ToInt32(dr["BM_Status"]) : BMStatus = null;
	}
	
	public static TMSBookMaintance[] MapFrom(DataSet ds)
	{
		List<TMSBookMaintance> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSBookMaintance>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_BookMaintance] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_BookMaintance] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSBookMaintance instance = new TMSBookMaintance();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSBookMaintance Get(System.Int64 bmMaintainceId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSBookMaintance instance;
		
		
		instance = new TMSBookMaintance();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBookMaintance_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, bmMaintainceId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSBookMaintance ID:" + bmMaintainceId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? bmBookDetailId, System.Int64? bmLibrarianId, System.Int64? bmDamageById, System.String bmTotalDamageCopies, System.String bmDamageAvailableCopies, System.String bmCostPerCopies, System.String bmTotalCost, System.String bmFor, System.String bmDamageType, System.String bmDamageByName, System.DateTime? bmDate, System.Int32? bmStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBookMaintance_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, bmBookDetailId, bmLibrarianId, bmDamageById, bmTotalDamageCopies, bmDamageAvailableCopies, bmCostPerCopies, bmTotalCost, bmFor, bmDamageType, bmDamageByName, bmDate, bmStatus);
		
		if (transaction == null)
		this.BMMaintainceId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.BMMaintainceId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? bmBookDetailId, System.Int64? bmLibrarianId, System.Int64? bmDamageById, System.String bmTotalDamageCopies, System.String bmDamageAvailableCopies, System.String bmCostPerCopies, System.String bmTotalCost, System.String bmFor, System.String bmDamageType, System.String bmDamageByName, System.DateTime? bmDate, System.Int32? bmStatus)
	{
		Insert(bmBookDetailId, bmLibrarianId, bmDamageById, bmTotalDamageCopies, bmDamageAvailableCopies, bmCostPerCopies, bmTotalCost, bmFor, bmDamageType, bmDamageByName, bmDate, bmStatus, null);
	}
	/// <summary>
	/// Insert current TMSBookMaintance to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(BMBookDetailId, BMLibrarianId, BMDamageById, BMTotalDamageCopies, BMDamageAvailableCopies, BMCostPerCopies, BMTotalCost, BMFor, BMDamageType, BMDamageByName, BMDate, BMStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSBookMaintance to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? bmMaintainceId, System.Int64? bmBookDetailId, System.Int64? bmLibrarianId, System.Int64? bmDamageById, System.String bmTotalDamageCopies, System.String bmDamageAvailableCopies, System.String bmCostPerCopies, System.String bmTotalCost, System.String bmFor, System.String bmDamageType, System.String bmDamageByName, System.DateTime? bmDate, System.Int32? bmStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBookMaintance_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@bmMaintainceId"].Value = bmMaintainceId;
		dbCommand.Parameters["@bmBookDetailId"].Value = bmBookDetailId;
		dbCommand.Parameters["@bmLibrarianId"].Value = bmLibrarianId;
		dbCommand.Parameters["@bmDamageById"].Value = bmDamageById;
		dbCommand.Parameters["@bmTotalDamageCopies"].Value = bmTotalDamageCopies;
		dbCommand.Parameters["@bmDamageAvailableCopies"].Value = bmDamageAvailableCopies;
		dbCommand.Parameters["@bmCostPerCopies"].Value = bmCostPerCopies;
		dbCommand.Parameters["@bmTotalCost"].Value = bmTotalCost;
		dbCommand.Parameters["@bmFor"].Value = bmFor;
		dbCommand.Parameters["@bmDamageType"].Value = bmDamageType;
		dbCommand.Parameters["@bmDamageByName"].Value = bmDamageByName;
		dbCommand.Parameters["@bmDate"].Value = bmDate;
		dbCommand.Parameters["@bmStatus"].Value = bmStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? bmMaintainceId, System.Int64? bmBookDetailId, System.Int64? bmLibrarianId, System.Int64? bmDamageById, System.String bmTotalDamageCopies, System.String bmDamageAvailableCopies, System.String bmCostPerCopies, System.String bmTotalCost, System.String bmFor, System.String bmDamageType, System.String bmDamageByName, System.DateTime? bmDate, System.Int32? bmStatus)
	{
		Update(bmMaintainceId, bmBookDetailId, bmLibrarianId, bmDamageById, bmTotalDamageCopies, bmDamageAvailableCopies, bmCostPerCopies, bmTotalCost, bmFor, bmDamageType, bmDamageByName, bmDate, bmStatus, null);
	}
	
	public static void Update(TMSBookMaintance tMSBookMaintance)
	{
		tMSBookMaintance.Update();
	}
	
	public static void Update(TMSBookMaintance tMSBookMaintance, DbTransaction transaction)
	{
		tMSBookMaintance.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSBookMaintance_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@bmMaintainceId"].SourceColumn = "BM_MaintainceId";
		dbCommand.Parameters["@bmBookDetailId"].SourceColumn = "BM_BookDetailId";
		dbCommand.Parameters["@bmLibrarianId"].SourceColumn = "BM_LibrarianId";
		dbCommand.Parameters["@bmDamageById"].SourceColumn = "BM_DamageById";
		dbCommand.Parameters["@bmTotalDamageCopies"].SourceColumn = "BM_TotalDamageCopies";
		dbCommand.Parameters["@bmDamageAvailableCopies"].SourceColumn = "BM_DamageAvailableCopies";
		dbCommand.Parameters["@bmCostPerCopies"].SourceColumn = "BM_CostPerCopies";
		dbCommand.Parameters["@bmTotalCost"].SourceColumn = "BM_TotalCost";
		dbCommand.Parameters["@bmFor"].SourceColumn = "BM_For";
		dbCommand.Parameters["@bmDamageType"].SourceColumn = "BM_DamageType";
		dbCommand.Parameters["@bmDamageByName"].SourceColumn = "BM_DamageByName";
		dbCommand.Parameters["@bmDate"].SourceColumn = "BM_Date";
		dbCommand.Parameters["@bmStatus"].SourceColumn = "BM_Status";
		
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
	public static void Delete(System.Int64? bmMaintainceId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBookMaintance_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, bmMaintainceId);
		
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
	public static void Delete(System.Int64? bmMaintainceId)
	{
		Delete(
		bmMaintainceId);
	}
	
	/// <summary>
	/// Delete current TMSBookMaintance from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBookMaintance_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, BMMaintainceId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.BMMaintainceId = null;
	}
	
	/// <summary>
	/// Delete current TMSBookMaintance from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSBookMaintance[] Search(System.Int64? bmMaintainceId, System.Int64? bmBookDetailId, System.Int64? bmLibrarianId, System.Int64? bmDamageById, System.String bmTotalDamageCopies, System.String bmDamageAvailableCopies, System.String bmCostPerCopies, System.String bmTotalCost, System.String bmFor, System.String bmDamageType, System.String bmDamageByName, System.DateTime? bmDate, System.Int32? bmStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBookMaintance_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, bmMaintainceId, bmBookDetailId, bmLibrarianId, bmDamageById, bmTotalDamageCopies, bmDamageAvailableCopies, bmCostPerCopies, bmTotalCost, bmFor, bmDamageType, bmDamageByName, bmDate, bmStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSBookMaintance.MapFrom(ds);
	}
	
	
	public static TMSBookMaintance[] Search(TMSBookMaintance searchObject)
	{
		return Search ( searchObject.BMMaintainceId, searchObject.BMBookDetailId, searchObject.BMLibrarianId, searchObject.BMDamageById, searchObject.BMTotalDamageCopies, searchObject.BMDamageAvailableCopies, searchObject.BMCostPerCopies, searchObject.BMTotalCost, searchObject.BMFor, searchObject.BMDamageType, searchObject.BMDamageByName, searchObject.BMDate, searchObject.BMStatus);
	}
	
	/// <summary>
	/// Returns all TMSBookMaintance objects.
	/// </summary>
	/// <returns>List of all TMSBookMaintance objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSBookMaintance[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

