/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 5/24/2012 4:59:36 PM                                    */
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
public partial class TMSCountry
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_Country]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _cntrId;
	private System.String _cntrCountry;
	private System.Int32? _cntrStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? CNTRId
	{
		get
		{
			return _cntrId;
		}
		set
		{
			_cntrId = value;
		}
	}
	
	public System.String CNTRCountry
	{
		get
		{
			return _cntrCountry;
		}
		set
		{
			_cntrCountry = value;
		}
	}
	
	public System.Int32? CNTRStatus
	{
		get
		{
			return _cntrStatus;
		}
		set
		{
			_cntrStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("CNTR_Id", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("CNTR_Country", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("CNTR_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (CNTRId == null)
		dr["CNTR_Id"] = DBNull.Value;
		else
		dr["CNTR_Id"] = CNTRId;
		
		if (CNTRCountry == null)
		dr["CNTR_Country"] = DBNull.Value;
		else
		dr["CNTR_Country"] = CNTRCountry;
		
		if (CNTRStatus == null)
		dr["CNTR_Status"] = DBNull.Value;
		else
		dr["CNTR_Status"] = CNTRStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		CNTRId = dr["CNTR_Id"] != DBNull.Value ? Convert.ToInt64(dr["CNTR_Id"]) : CNTRId = null;
		CNTRCountry = dr["CNTR_Country"] != DBNull.Value ? Convert.ToString(dr["CNTR_Country"]) : CNTRCountry = null;
		CNTRStatus = dr["CNTR_Status"] != DBNull.Value ? Convert.ToInt32(dr["CNTR_Status"]) : CNTRStatus = null;
	}
	
	public static TMSCountry[] MapFrom(DataSet ds)
	{
		List<TMSCountry> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSCountry>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_Country] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_Country] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSCountry instance = new TMSCountry();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSCountry Get(System.Int64 cntrId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSCountry instance;
		
		
		instance = new TMSCountry();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCountry_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, cntrId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSCountry ID:" + cntrId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String cntrCountry, System.Int32? cntrStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCountry_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, cntrCountry, cntrStatus);
		
		if (transaction == null)
		this.CNTRId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.CNTRId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String cntrCountry, System.Int32? cntrStatus)
	{
		Insert(cntrCountry, cntrStatus, null);
	}
	/// <summary>
	/// Insert current TMSCountry to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(CNTRCountry, CNTRStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSCountry to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? cntrId, System.String cntrCountry, System.Int32? cntrStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCountry_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@cntrId"].Value = cntrId;
		dbCommand.Parameters["@cntrCountry"].Value = cntrCountry;
		dbCommand.Parameters["@cntrStatus"].Value = cntrStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? cntrId, System.String cntrCountry, System.Int32? cntrStatus)
	{
		Update(cntrId, cntrCountry, cntrStatus, null);
	}
	
	public static void Update(TMSCountry tMSCountry)
	{
		tMSCountry.Update();
	}
	
	public static void Update(TMSCountry tMSCountry, DbTransaction transaction)
	{
		tMSCountry.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSCountry_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@cntrId"].SourceColumn = "CNTR_Id";
		dbCommand.Parameters["@cntrCountry"].SourceColumn = "CNTR_Country";
		dbCommand.Parameters["@cntrStatus"].SourceColumn = "CNTR_Status";
		
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
	public static void Delete(System.Int64? cntrId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCountry_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, cntrId);
		
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
	public static void Delete(System.Int64? cntrId)
	{
		Delete(
		cntrId);
	}
	
	/// <summary>
	/// Delete current TMSCountry from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCountry_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, CNTRId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.CNTRId = null;
	}
	
	/// <summary>
	/// Delete current TMSCountry from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSCountry[] Search(System.Int64? cntrId, System.String cntrCountry, System.Int32? cntrStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCountry_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, cntrId, cntrCountry, cntrStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSCountry.MapFrom(ds);
	}
	
	
	public static TMSCountry[] Search(TMSCountry searchObject)
	{
		return Search ( searchObject.CNTRId, searchObject.CNTRCountry, searchObject.CNTRStatus);
	}
	
	/// <summary>
	/// Returns all TMSCountry objects.
	/// </summary>
	/// <returns>List of all TMSCountry objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSCountry[] Search()
	{
		return Search ( null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

