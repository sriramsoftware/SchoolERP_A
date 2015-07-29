/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 22/07/2015 10:03:08 PM                                    */
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
public partial class TMSFeesTerm
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_FeesTerm]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _feesTermID;
	private System.Int32? _feeCategoryID;
	private System.Int32? _month;
	private System.String _feesTerm;
	
	#endregion
	
	
	#region Properties
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
	
	public System.Int32? FeeCategoryID
	{
		get
		{
			return _feeCategoryID;
		}
		set
		{
			_feeCategoryID = value;
		}
	}
	
	public System.Int32? Month
	{
		get
		{
			return _month;
		}
		set
		{
			_month = value;
		}
	}
	
	public System.String FeesTerm
	{
		get
		{
			return _feesTerm;
		}
		set
		{
			_feesTerm = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("FeesTermID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("FeeCategoryID", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("Month", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("FeesTerm", typeof(System.String) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (FeesTermID == null)
		dr["FeesTermID"] = DBNull.Value;
		else
		dr["FeesTermID"] = FeesTermID;
		
		if (FeeCategoryID == null)
		dr["FeeCategoryID"] = DBNull.Value;
		else
		dr["FeeCategoryID"] = FeeCategoryID;
		
		if (Month == null)
		dr["Month"] = DBNull.Value;
		else
		dr["Month"] = Month;
		
		if (FeesTerm == null)
		dr["FeesTerm"] = DBNull.Value;
		else
		dr["FeesTerm"] = FeesTerm;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		FeesTermID = dr["FeesTermID"] != DBNull.Value ? Convert.ToInt64(dr["FeesTermID"]) : FeesTermID = null;
		FeeCategoryID = dr["FeeCategoryID"] != DBNull.Value ? Convert.ToInt32(dr["FeeCategoryID"]) : FeeCategoryID = null;
		Month = dr["Month"] != DBNull.Value ? Convert.ToInt32(dr["Month"]) : Month = null;
		FeesTerm = dr["FeesTerm"] != DBNull.Value ? Convert.ToString(dr["FeesTerm"]) : FeesTerm = null;
	}
	
	public static TMSFeesTerm[] MapFrom(DataSet ds)
	{
		List<TMSFeesTerm> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSFeesTerm>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_FeesTerm] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_FeesTerm] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSFeesTerm instance = new TMSFeesTerm();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSFeesTerm Get(System.Int64 feesTermID)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSFeesTerm instance;
		
		
		instance = new TMSFeesTerm();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesTerm_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, feesTermID);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSFeesTerm ID:" + feesTermID.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int32? feeCategoryID, System.Int32? month, System.String feesTerm, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesTerm_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, feeCategoryID, month, feesTerm);
		
		if (transaction == null)
		this.FeesTermID = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.FeesTermID = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int32? feeCategoryID, System.Int32? month, System.String feesTerm)
	{
		Insert(feeCategoryID, month, feesTerm, null);
	}
	/// <summary>
	/// Insert current TMSFeesTerm to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(FeeCategoryID, Month, FeesTerm, transaction);
	}
	
	/// <summary>
	/// Insert current TMSFeesTerm to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? feesTermID, System.Int32? feeCategoryID, System.Int32? month, System.String feesTerm, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesTerm_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@feesTermID"].Value = feesTermID;
		dbCommand.Parameters["@feeCategoryID"].Value = feeCategoryID;
		dbCommand.Parameters["@month"].Value = month;
		dbCommand.Parameters["@feesTerm"].Value = feesTerm;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? feesTermID, System.Int32? feeCategoryID, System.Int32? month, System.String feesTerm)
	{
		Update(feesTermID, feeCategoryID, month, feesTerm, null);
	}
	
	public static void Update(TMSFeesTerm tMSFeesTerm)
	{
		tMSFeesTerm.Update();
	}
	
	public static void Update(TMSFeesTerm tMSFeesTerm, DbTransaction transaction)
	{
		tMSFeesTerm.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSFeesTerm_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@feesTermID"].SourceColumn = "FeesTermID";
		dbCommand.Parameters["@feeCategoryID"].SourceColumn = "FeeCategoryID";
		dbCommand.Parameters["@month"].SourceColumn = "Month";
		dbCommand.Parameters["@feesTerm"].SourceColumn = "FeesTerm";
		
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
	public static void Delete(System.Int64? feesTermID, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesTerm_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, feesTermID);
		
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
	public static void Delete(System.Int64? feesTermID)
	{
		Delete(
		feesTermID);
	}
	
	/// <summary>
	/// Delete current TMSFeesTerm from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesTerm_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, FeesTermID);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.FeesTermID = null;
	}
	
	/// <summary>
	/// Delete current TMSFeesTerm from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSFeesTerm[] Search(System.Int64? feesTermID, System.Int32? feeCategoryID, System.Int32? month, System.String feesTerm)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesTerm_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, feesTermID, feeCategoryID, month, feesTerm);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSFeesTerm.MapFrom(ds);
	}
	
	
	public static TMSFeesTerm[] Search(TMSFeesTerm searchObject)
	{
		return Search ( searchObject.FeesTermID, searchObject.FeeCategoryID, searchObject.Month, searchObject.FeesTerm);
	}
	
	/// <summary>
	/// Returns all TMSFeesTerm objects.
	/// </summary>
	/// <returns>List of all TMSFeesTerm objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSFeesTerm[] Search()
	{
		return Search ( null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

