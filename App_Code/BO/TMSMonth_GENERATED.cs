/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 6/28/2012 3:27:54 PM                                    */
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
public partial class TMSMonth
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_Month]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _mhID;
	private System.String _mhName;
	private System.DateTime? _mhDate;
	private System.Int32? _mhStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? MhID
	{
		get
		{
			return _mhID;
		}
		set
		{
			_mhID = value;
		}
	}
	
	public System.String MhName
	{
		get
		{
			return _mhName;
		}
		set
		{
			_mhName = value;
		}
	}
	
	public System.DateTime? MhDate
	{
		get
		{
			return _mhDate;
		}
		set
		{
			_mhDate = value;
		}
	}
	
	public System.Int32? MhStatus
	{
		get
		{
			return _mhStatus;
		}
		set
		{
			_mhStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("Mh_ID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("Mh_Name", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("Mh_date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("Mh_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (MhID == null)
		dr["Mh_ID"] = DBNull.Value;
		else
		dr["Mh_ID"] = MhID;
		
		if (MhName == null)
		dr["Mh_Name"] = DBNull.Value;
		else
		dr["Mh_Name"] = MhName;
		
		if (MhDate == null)
		dr["Mh_date"] = DBNull.Value;
		else
		dr["Mh_date"] = MhDate;
		
		if (MhStatus == null)
		dr["Mh_Status"] = DBNull.Value;
		else
		dr["Mh_Status"] = MhStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		MhID = dr["Mh_ID"] != DBNull.Value ? Convert.ToInt64(dr["Mh_ID"]) : MhID = null;
		MhName = dr["Mh_Name"] != DBNull.Value ? Convert.ToString(dr["Mh_Name"]) : MhName = null;
		MhDate = dr["Mh_date"] != DBNull.Value ? Convert.ToDateTime(dr["Mh_date"]) : MhDate = null;
		MhStatus = dr["Mh_Status"] != DBNull.Value ? Convert.ToInt32(dr["Mh_Status"]) : MhStatus = null;
	}
	
	public static TMSMonth[] MapFrom(DataSet ds)
	{
		List<TMSMonth> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSMonth>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_Month] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_Month] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSMonth instance = new TMSMonth();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSMonth Get(System.Int64 mhID)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSMonth instance;
		
		
		instance = new TMSMonth();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSMonth_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, mhID);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSMonth ID:" + mhID.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String mhName, System.DateTime? mhDate, System.Int32? mhStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSMonth_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, mhName, mhDate, mhStatus);
		
		if (transaction == null)
		this.MhID = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.MhID = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String mhName, System.DateTime? mhDate, System.Int32? mhStatus)
	{
		Insert(mhName, mhDate, mhStatus, null);
	}
	/// <summary>
	/// Insert current TMSMonth to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(MhName, MhDate, MhStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSMonth to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? mhID, System.String mhName, System.DateTime? mhDate, System.Int32? mhStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSMonth_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@mhID"].Value = mhID;
		dbCommand.Parameters["@mhName"].Value = mhName;
		dbCommand.Parameters["@mhDate"].Value = mhDate;
		dbCommand.Parameters["@mhStatus"].Value = mhStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? mhID, System.String mhName, System.DateTime? mhDate, System.Int32? mhStatus)
	{
		Update(mhID, mhName, mhDate, mhStatus, null);
	}
	
	public static void Update(TMSMonth tMSMonth)
	{
		tMSMonth.Update();
	}
	
	public static void Update(TMSMonth tMSMonth, DbTransaction transaction)
	{
		tMSMonth.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSMonth_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@mhID"].SourceColumn = "Mh_ID";
		dbCommand.Parameters["@mhName"].SourceColumn = "Mh_Name";
		dbCommand.Parameters["@mhDate"].SourceColumn = "Mh_date";
		dbCommand.Parameters["@mhStatus"].SourceColumn = "Mh_Status";
		
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
	public static void Delete(System.Int64? mhID, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSMonth_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, mhID);
		
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
	public static void Delete(System.Int64? mhID)
	{
		Delete(
		mhID);
	}
	
	/// <summary>
	/// Delete current TMSMonth from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSMonth_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, MhID);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.MhID = null;
	}
	
	/// <summary>
	/// Delete current TMSMonth from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSMonth[] Search(System.Int64? mhID, System.String mhName, System.DateTime? mhDate, System.Int32? mhStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSMonth_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, mhID, mhName, mhDate, mhStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSMonth.MapFrom(ds);
	}
	
	
	public static TMSMonth[] Search(TMSMonth searchObject)
	{
		return Search ( searchObject.MhID, searchObject.MhName, searchObject.MhDate, searchObject.MhStatus);
	}
	
	/// <summary>
	/// Returns all TMSMonth objects.
	/// </summary>
	/// <returns>List of all TMSMonth objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSMonth[] Search()
	{
		return Search ( null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

